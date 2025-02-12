using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;
using CHSMonitoring.Domain.Entities;
using CHSMonitoring.Infrastructure.Common;
using CHSMonitoring.Infrastructure.Extensions;
using CHSMonitoring.Infrastructure.Interfaces;
using CHSMonitoring.Infrastructure.Models.Enums;
using CHSMonitoring.Infrastructure.Models.ServiceMessageAddress;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace CHSMonitoring.Infrastructure.Services;

/// <summary>
/// Сервис получения адресов
/// </summary>
public sealed class AddressParserService : IAddressParserService
{
    private readonly IStreetRepository _streetRepository;
    private readonly ILogger<AddressParserService> _logger;

    /// <summary>
    /// Конструктор
    /// </summary>
    public AddressParserService(IServiceScopeFactory scopeFactory, ILoggerFactory loggerFactory)
    {
        _logger = loggerFactory.CreateLogger<AddressParserService>();
        var scope = scopeFactory.CreateScope();
        _streetRepository = scope.ServiceProvider.GetRequiredService<IStreetRepository>();
    }
    
    public Dictionary<string, List<string>> GetAddressDictFromAddressText(string addressesText)
    {
        var splittedAddressesList = addressesText
            .Split(';', StringSplitOptions.TrimEntries)
            .ToList();
        splittedAddressesList.ReplaceAddresesLetters();
        
        var addresses = splittedAddressesList
            .Where(x => CommonData.StreetsData.Any(t => x.Contains(t.StreetName, StringComparison.InvariantCultureIgnoreCase)))
            .ToList();

        var addressDictionary = new Dictionary<string, List<string>>();
        if (addresses.Any())
        {
            //Разделить двойные адреса
            addresses = SplitDoubleAddresses(addresses);
            foreach (var addressItem in addresses)
            {
                //Выбираем точное вхождение улицы
                var streetNameResult = GetStreetName(addressItem);
                var streetHouseNumberResult = GetResultStreetNumbers(addressItem, streetNameResult);
                var numbers = streetHouseNumberResult
                    .Split(",", StringSplitOptions.TrimEntries)
                    .Where(x => !string.IsNullOrWhiteSpace(x))
                    .ToList();
        
                if (!addressDictionary.ContainsKey(streetNameResult))
                {
                    addressDictionary.Add(streetNameResult, numbers);
                }
                else
                {
                    foreach (var number in numbers)
                    {
                        addressDictionary[streetNameResult].Add(number);
                    }
                }
            }
        }
        return addressDictionary
            .Where(x => !string.IsNullOrEmpty(x.Key))
            .ToDictionary();
    }

    public async Task<List<Address>> ParseAddressNumbers(Dictionary<string, List<string>> addressDictionary)
    {
         // TODO: Распарсить номера домов строения итп в другом месте
         var addressList = new List<Address>();
         
         foreach (var addressDictItem in addressDictionary)
         {
             var street = await _streetRepository.GetStreetAsync(addressDictItem.Key, default).ConfigureAwait(false);
             ArgumentNullException.ThrowIfNull(street);
             
             if (!addressDictItem.Value.Any())
             {
                 addressList.Add(Address.Create(street.Name, string.Empty));
                 continue;
             }

             var numbersList = addressDictItem.Value
                 .RemoveWhiteSpaces()
                 .RemoveInBracketValues()
                 .ReplaceStSymbolsInNumbers()
                 .ReplaceKSymbolsInNumbers();
             HashSet<(string streetNames, string number)> uniqueAddresses = new();
             foreach (var number in numbersList)
             {
                 if (!number.Contains("-", StringComparison.InvariantCultureIgnoreCase))
                 {
                     if (uniqueAddresses.Add((street.Name, number)))
                     {
                         addressList.Add(Address.Create(street.Name, number));
                     }
                 }
                 else
                 {
                     //Выбрать диапазон
                     var houseNumbersFromRange = GetStreetNumberRange(street, number);
                     //Вытащить и преобразовать все варианты, без дубликатов
                     if (houseNumbersFromRange.Any())
                     {
                         foreach (var houseNumuber in houseNumbersFromRange)
                         {
                             if (uniqueAddresses.Add((street.Name, houseNumuber.houseNumber)))
                             {
                                 addressList.Add(Address.Create(street.Name, houseNumuber.houseNumber));
                             }
                         }
                     }
                 }
             }
             
             //Сохранить информацию по домам из полученного списка
             await _streetRepository.UpdateStreetHouseNumbersAsync(street.Id, uniqueAddresses.Select(x => x.number).ToList(), default);
             uniqueAddresses.Clear();
         }

         //Вернуть список чтобы преобразовать в ServiceAddress
         return addressList;
    }

    public (string description, string outputText) GetPlannedDescriptionMessage(string addressesText)
    {
        var plannedIndexOfText = CommonData.PlannedOffData
            .DefaultIfEmpty()
            .Select(x => addressesText.IndexOf(x, StringComparison.InvariantCultureIgnoreCase))
            .Where(x => x != -1)
            .Min();
        if (plannedIndexOfText != 0)
        {
            var additionalDescriptionValue = addressesText.Substring(plannedIndexOfText, addressesText.Length - plannedIndexOfText);
            addressesText = addressesText.Remove(plannedIndexOfText, addressesText.Length - plannedIndexOfText).Trim();
            return (description: additionalDescriptionValue, outputText: addressesText);
        }
        
        return (description: string.Empty, outputText: addressesText);
    }
    
    /// <summary>
    /// Получаем точное вхождение когда вариантов улиц несколько
    /// </summary>
    /// <param name="streetNameOccursList"></param>
    /// <param name="addressItem"></param>
    /// <returns></returns>
    public string GetStreetName(string addressItem)
    {
        if (string.IsNullOrEmpty(addressItem))
        {
            return string.Empty;
        }
        
        ///Получаем улицу из общего словаря
        var matchStreetCount = CommonData.StreetsData
            .Where(x => addressItem.Contains(x.StreetName, StringComparison.InvariantCultureIgnoreCase))
            .ToList();

        if (matchStreetCount.Any())
        {
            var index = matchStreetCount
                .Select(x => addressItem.IndexOf(x.StreetName, StringComparison.InvariantCultureIgnoreCase))
                .Min();
            var strictedAddressItem = addressItem.Substring(index, addressItem.Length - index);
            
            if (matchStreetCount.Count == 1)
            {
                var value = matchStreetCount.FirstOrDefault(x => strictedAddressItem.Contains(x.StreetName, StringComparison.InvariantCultureIgnoreCase));
                return value.StreetName;
            }
            else if (matchStreetCount.Count > 1)
            {
                var sb = new StringBuilder();
                foreach (var symbol in strictedAddressItem)
                {
                    sb.Append(symbol);

                    var matchStreet = matchStreetCount.FirstOrDefault(x => x.StreetName.Equals(sb.ToString(), StringComparison.InvariantCultureIgnoreCase));
                    if (matchStreet.Id != Guid.Empty)
                    {
                        var subString = strictedAddressItem.Substring(sb.ToString().Length, strictedAddressItem.Length - sb.ToString().Length);
                        if ((matchStreet.StreetName.Equals(sb.ToString(), StringComparison.InvariantCultureIgnoreCase) && string.IsNullOrEmpty(subString))
                            || (matchStreet.StreetName.Equals(sb.ToString(), StringComparison.InvariantCultureIgnoreCase) && string.IsNullOrWhiteSpace(subString[0].ToString())))
                        {
                            return matchStreet.StreetName;
                        }
                        
                        matchStreetCount.Remove(matchStreet);
                    }
                }
            }
        }

        return string.Empty;
    }
        
    /// <summary>
    /// Получаем номера домов конкретной улицы
    /// </summary>
    /// <param name="addressItem"></param>
    /// <param name="streetNameResult"></param>
    /// <returns></returns>
    private string GetResultStreetNumbers(string addressItem, string streetNameResult)
    {
        var indexOfOccurs = addressItem.IndexOf(streetNameResult, StringComparison.InvariantCultureIgnoreCase);
        if (indexOfOccurs != -1)
        {
            if (indexOfOccurs != 0)
            {
                var pureString = addressItem.Remove(0, indexOfOccurs);
                var numbers = pureString.Remove(0,streetNameResult.Length).Trim();
                return numbers;
            }

            var noPrefixNumber = addressItem.Remove(indexOfOccurs, streetNameResult.Length).Trim();
            return noPrefixNumber;
        }

        return string.Empty;
    }
    
    /// <summary>
    /// Разбиение двойных адресов на разные адреса
    /// </summary>
    /// <param name="addresses"></param>
    /// <returns></returns>
    public List<string> SplitDoubleAddresses(List<string> addresses)
    {
        var doubleStreets = new List<string>();
        foreach (var streetName in CommonData.StreetsData)
        {
            var doubleStreet = addresses
                .Where(x => x.Contains($"/{streetName}", StringComparison.InvariantCultureIgnoreCase))
                .ToList();
            doubleStreets.AddRange(doubleStreet);
        }
        foreach (var doubleStreet in doubleStreets)
        {
            addresses.Remove(doubleStreet);
            addresses.AddRange(doubleStreet.Split("/", StringSplitOptions.TrimEntries));
        }

        return addresses;
    }

    /// <summary>
    /// Получить информацию из адресов в диапазоне
    /// </summary>
    /// <param name="street">Название улицы</param>
    /// <param name="numberValue">Диапазонное значение адресов</param>
    /// <returns></returns>
    public List<(string streetName, string houseNumber)> GetStreetNumberRange(Street street, string numberValue)
    {
        var splitNumber = numberValue.Split("-", StringSplitOptions.TrimEntries)
            .ToList();

        var newHouseNumbersList = new List<(string streetName, string houseNumber)>();
        if (splitNumber.Count == 2)
        {
            var startNumber = splitNumber[0].NormalizedSplitNumber();
            var endNumber = splitNumber[1].NormalizedSplitNumber();

            var houseNumbersList = street.HouseNumbers.Split(",")
                .Select(x => x.Trim())
                .ToList();
            
            var resultStartNumber = houseNumbersList.FirstOrDefault(x => x.Equals(startNumber, StringComparison.InvariantCultureIgnoreCase));
            var resultEndNumber = houseNumbersList.FirstOrDefault(x => x.Equals(endNumber, StringComparison.InvariantCultureIgnoreCase));
            if (resultStartNumber is null)
            {
                houseNumbersList.Add(startNumber);
                resultStartNumber = startNumber;
            }
            if (resultEndNumber is null)
            {
                houseNumbersList.Add(endNumber);
                resultEndNumber = endNumber;
            }

            //TODO: Если стартового числа нет, взять ближайшее число из любого полученного адреса
            //Проверить порядок символов (индексы чисел идущих друг за другом, после чего выбрать самую длинную последовательность чисел)
            //и от неё оттолкнуться и забрать диапазоном ОТ и ДО

            //TODO: Добавить варианты из диапазона которые найдены если их нет
            //Не обновлять тут, отдать конечный вариант наружу для сохранности консистентности?
            // await _streetRepository.UpdateStreetHouseNumbersAsync(street.Id, new List<string>() { resultStartNumber, resultEndNumber }, default)
            //     .ConfigureAwait(false);



            houseNumbersList.ToList().Sort();
            var indexStartNumber = houseNumbersList.IndexOf(resultStartNumber);
            var indexEndNumber = houseNumbersList.IndexOf(resultEndNumber);
        

        
            //TODO: Выбрать вариант который парсится
            var initialNumber = Math.Min(indexStartNumber, indexEndNumber);
            var maxNumber = Math.Max(indexStartNumber, indexEndNumber);
        
            for (var i = initialNumber; i <= maxNumber; i++)
            {
                var houseNumberToAdd = houseNumbersList.Select((item, index) => (item, index))
                    .FirstOrDefault(x => x.index == i);
                newHouseNumbersList.Add((streetName: street.Name, houseNumber: houseNumberToAdd.item));
            }
        }

        return newHouseNumbersList;
    }
}