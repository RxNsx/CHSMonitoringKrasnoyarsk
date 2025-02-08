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
        return addressDictionary;
    }

    public async Task<List<Address>> ParseAddressNumbers(Dictionary<string, List<string>> addressDictionary)
    {
         // TODO: Распарсить номера домов строения итп в другом месте
         HashSet<(string streetNames, string number)> uniqueAddresses = new();
         var addressList = new List<Address>();
         
         foreach (var item in addressDictionary)
         {
             if (!item.Value.Any())
             {
                 addressList.Add(Address.Create(item.Key, string.Empty));
                 continue;
             }

             var numbersList = item.Value
                 .RemoveInBracketValues()
                 .ReplaceStSymbolsInNumbers();
             foreach (var number in numbersList)
             {
                 try
                 {
                     var street = await _streetRepository.GetStreetAsync(item.Key, default).ConfigureAwait(false);
                     ArgumentNullException.ThrowIfNull(street);
                     
                     var isHouseNumberContainsInStreet = street.HouseNumbers.Split(",")
                         .Any(x => x.Contains(number, StringComparison.InvariantCultureIgnoreCase));
                     
                     //TODO: Проверить все варианты улиц до момента встречи символа - (диапазона улиц)
                     //TODO: Подходят все варианты (тестировать)
                     if (!number.Contains("-", StringComparison.InvariantCultureIgnoreCase))
                     {
                         if (uniqueAddresses.Add((item.Key, number)))
                         {
                             addressList.Add(Address.Create(item.Key, number));
                         }
                     }
                     else
                     {
                         //Выбрать диапазон
                         var houseNumbersFromRange = GetStreetNumberRange(street, number);
                         await _streetRepository.UpdateStreetHouseNumbersAsync(street.Id, houseNumbersFromRange.Select(x => x.houseNumber).ToList(), default);
                     }
                 }
                 catch (Exception exception)
                 {
                     _logger.LogError($"");
                     Console.WriteLine(exception);
                     throw;
                 }
             }
         }

         return addressList;
    }

    public (string description, string outputText) GetPlannedDescriptionMessage(string addressesText)
    {
        var plannedIndexOfText = CommonData.PlannedData
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
                        var check = string.IsNullOrEmpty(subString);
                        
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
            
            var indexStartNumber = houseNumbersList.OrderBy(x => x).ToList().IndexOf(resultStartNumber);
            var indexEndNumber = houseNumbersList.OrderBy(x => x).ToList().IndexOf(resultEndNumber);
        
            //TODO: Если стартового числа нет, взять ближайшее число из любого полученного адреса
            //Проверить порядок символов (индексы чисел идущих друг за другом, после чего выбрать самую длинную последовательность чисел)
            //и от неё оттолкнуться и забрать диапазоном ОТ и ДО

            //TODO: Добавить варианты из диапазона которые найдены если их нет
            //Не обновлять тут, отдать конечный вариант наружу для сохранности консистентности?
            // await _streetRepository.UpdateStreetHouseNumbersAsync(street.Id, new List<string>() { resultStartNumber, resultEndNumber }, default)
            //     .ConfigureAwait(false);
        
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