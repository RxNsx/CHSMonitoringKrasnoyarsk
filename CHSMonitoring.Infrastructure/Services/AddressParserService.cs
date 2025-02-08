using System.Text;
using CHSMonitoring.Infrastructure.Extensions;
using CHSMonitoring.Infrastructure.Interfaces;
using CHSMonitoring.Infrastructure.Models.Enums;
using CHSMonitoring.Infrastructure.Models.ServiceMessageAddress;

namespace CHSMonitoring.Infrastructure.Services;

/// <summary>
/// Сервис получения адресов
/// </summary>
internal sealed class AddressParserService : IAddressParserService
{
    private readonly List<(Guid Id, string StreetName)> _streetEnumDescriptions;
    private readonly List<string> _plannedEnumDescriptions;

    /// <summary>
    /// Конструктор
    /// </summary>
    public AddressParserService()
    {
        _streetEnumDescriptions = Enum.GetValues(typeof(StreetNameEnum))
            .Cast<StreetNameEnum>()
            .Select(x => (Id: x.GetGuidValue(), StreetName: x.GetDescriptionValue()))
            .ToList();
        _plannedEnumDescriptions = Enum.GetValues(typeof(PlannedSupplyTypeEnum))
            .Cast<PlannedSupplyTypeEnum>()
            .Select(x => x.GetDescriptionValue())
            .ToList();
    }
    
    public Dictionary<string, List<string>> GetAddressDictFromAddressText(string addressesText)
    {
        var splittedAddressesList = addressesText
            .Split(';', StringSplitOptions.TrimEntries)
            .ToList();
        splittedAddressesList = ReplaceAddreses(splittedAddressesList);
        var addresses = splittedAddressesList
            .Where(x => _streetEnumDescriptions.Any(t => x.Contains(t.StreetName, StringComparison.InvariantCultureIgnoreCase)))
            .ToList();

        var addressDictionary = new Dictionary<string, List<string>>();
        if (addresses.Any())
        {
            //Разделить двойные адреса
            addresses = SplitDoubleAddresses(addresses);
            foreach (var addressItem in addresses)
            {
                //Выбираем точное вхождение улицы
                var streetNameResult = GetResultStreetName(addressItem);
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
        
        //TODO: Распарсить номера домов строения итп в другом месте
        // HashSet<(string streetNames, string number)> uniqueAddresses = new();
        // var regexAddressWithSlash = new Regex(@"\b\d+[а-яА-Я]?\d*/\d+\b", RegexOptions.Compiled);
        // var regexRegularAddress = new Regex(@"^[а-яА-Я]", RegexOptions.Compiled);
        // var regexAddressStartWithNumbers = new Regex(@"^\d", RegexOptions.Compiled);
        // foreach (var item in addressDictionary)
        // {
        //     if (item.Value.Any())
        //     {
        //         foreach (var number in item.Value)
        //         {
        //             var match = regexAddressWithSlash.Match(number);
        //             if (match.Success)
        //             {
        //                 if (uniqueAddresses.Add((item.Key, match.Value)))
        //                 {
        //                     addressList.Add(Address.Create(item.Key, match.Value));
        //                 }
        //                 continue;
        //             }
        //             
        //             if (!number.Contains("-"))
        //             {
        //                 if (regexRegularAddress.IsMatch(number))
        //                 {
        //                     var pureNumber = new string(number.Where(x => char.IsDigit(x)).ToArray()); 
        //                     if (uniqueAddresses.Add((item.Key, pureNumber)))
        //                     {
        //                         addressList.Add(Address.Create(item.Key, pureNumber));
        //                     }
        //                 }
        //                 else
        //                 {
        //                     if (uniqueAddresses.Add((item.Key, number)))
        //                     {
        //                         addressList.Add(Address.Create(item.Key, number));
        //                     }
        //                 }
        //                 continue;
        //             }
        //         
        //             var splitNumber = number.Split("-", StringSplitOptions.TrimEntries);
        //             if (splitNumber.Length == 2 
        //                 && regexAddressStartWithNumbers.IsMatch(splitNumber[0]) && regexAddressStartWithNumbers.IsMatch(splitNumber[1]))
        //             {
        //                 //TODO: Решить вопрос с парсингом адресов тут формата 13a 13ст1 32а ст1
        //                 
        //                 var normalizedNumber = int.Parse(splitNumber[0].NormalizedSplitNumber());
        //                 var normalizedNumber2 = int.Parse(splitNumber[1].NormalizedSplitNumber());
        //                 for (var initialNumber = Math.Min(normalizedNumber, normalizedNumber2); initialNumber <= Math.Max(normalizedNumber,normalizedNumber2); initialNumber++)
        //                 {
        //                     if (uniqueAddresses.Add((item.Key, initialNumber.ToString())))
        //                     {
        //                         addressList.Add(Address.Create(item.Key, initialNumber.ToString()));
        //                     }
        //                 }
        //             }
        //         }
        //     }
        //     else
        //     {
        //         addressList.Add(Address.Create(item.Key, string.Empty));
        //     }
        // }
        //
        // return addressList;

        // _serviceMessage.SetDescription(string.Join(",", additionalDescriptionList));
        // _serviceMessage.SetAddressList(addressList);
        // return addressList;
    }

    public (string description, string outputText) GetPlannedDescriptionMessage(string addressesText)
    {
        var plannedIndexOfText = _plannedEnumDescriptions
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
    /// Замена вхождений где буква Е должна быть буквой Ё
    /// </summary>
    /// <param name="addresses"></param>
    /// <returns></returns>
    private List<string> ReplaceAddreses(List<string> addresses)
    {
        var replaceAddresses = new List<(string original, string replaceAddress)>()
        {
            new("Алеши Тимошенкова", "Алёши Тимошенкова"),
            new("Артемовская", "Артёмовская"),
            new("Березовая", "Берёзовая"),
            new("Веселая", "Весёлая"),
            new("Взлетная", "Взлётная"),
            new("Водометный", "Водомётный"),
            new("Зеленый", "Зелёный"),
            new("Озерная", "Озёрная"),
            new("Таежная", "Таёжная"),
            new("Черемуховая", "Черёмуховая"),
            new("Шелковая", "Шёлковая"),
            new("СК Березка-2", "СК Берёзка-2"),
            new("СТ Березка", "СТ Берёзка"),
            new("СТ Дом матери и ребенка", "СТ Дом матери и ребёнка"),
        };
        
        for (var i = 0; i < addresses.Count; i ++)
        {
            foreach (var replacement in replaceAddresses)
            {
                if (addresses[i].Contains(replacement.original))
                {
                    addresses[i] = addresses[i].Replace(replacement.original, replacement.replaceAddress);
                }
            }
        }

        return addresses;
    }
    
    /// <summary>
    /// Получаем точное вхождение когда вариантов улиц несколько
    /// </summary>
    /// <param name="streetNameOccursList"></param>
    /// <param name="addressItem"></param>
    /// <returns></returns>
    private string GetResultStreetName(string addressItem)
    {
        ///Получаем улицу из общего словаря
        var matchStreetCount = _streetEnumDescriptions
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
                        if (!matchStreet.StreetName.Equals(strictedAddressItem, StringComparison.InvariantCultureIgnoreCase))
                        {
                            matchStreetCount.Remove(matchStreet);
                            continue;
                        }

                        return matchStreet.StreetName;
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
        foreach (var streetName in _streetEnumDescriptions)
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
}