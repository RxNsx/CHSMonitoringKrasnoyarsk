using System.Text;
using System.Text.RegularExpressions;
using CHSMonitoring.Infrastructure.Extensions;
using CHSMonitoring.Infrastructure.Models.Enums;
using CHSMonitoring.Infrastructure.Models.ServiceMessageAddress;

namespace CHSMonitoring.Infrastructure.Models.Parsers;

/// <summary>
/// Парсер адресов
/// </summary>
public static class AddressParser
{
    /// <summary>
    /// Получить адреса из строки
    /// </summary>
    /// <param name="addresses"></param>
    /// <returns></returns>
    /// <exception cref="ArgumentNullException"></exception>
    public static List<Address> ParseAddresses(List<string> addresses)
    {
        var streetNames = Enum.GetValues(typeof(StreetNameEnum))
            .Cast<StreetNameEnum>()
            .Select(x => x.GetDescriptionValue())
            .ToList();
        var concreteAddresses = addresses
            .Where(x => streetNames.Any(t => x.Contains(t, StringComparison.InvariantCultureIgnoreCase)))
            .ToList();
        if (!concreteAddresses.Any())
        {
            Console.WriteLine($"Addresses: {string.Join(", ", addresses)}");
            throw new ArgumentNullException(nameof(concreteAddresses), "concreteAddresses must be not null");
        }

        #region Определение двойных адресов
        
        var doubleStreets = new List<string>();
        foreach (var streetName in streetNames)
        {
            var doubleStreet = concreteAddresses
                .Where(x => x.Contains($"/{streetName}", StringComparison.InvariantCultureIgnoreCase))
                .ToList();
            doubleStreets.AddRange(doubleStreet);
        }
        
        foreach (var doubleStreet in doubleStreets)
        {
            concreteAddresses.Remove(doubleStreet);
            concreteAddresses.AddRange(doubleStreet.Split("/", StringSplitOptions.TrimEntries));
        }
        
        #endregion
        
        List<Address> addressList = new();
        var addressDictionary = new Dictionary<string, List<string>>();
        foreach (var addressItem in concreteAddresses)
        {
            //Выбираем все улицы которые могут подойти по названию
            var streetNameOccursList = streetNames
                .Where(x => streetNames.Any(t => addressItem.Contains(x, StringComparison.InvariantCultureIgnoreCase)))
                .ToList();
            //Выбираем точное вхождение улицы
            var streetNameResult = GetResultStreetName(streetNameOccursList, addressItem);
            var streetHouseNumberResult = GetResultStreetNumbers(addressItem, streetNameResult);
            var numbers = streetHouseNumberResult
                .Split(",", StringSplitOptions.TrimEntries)
                .Where(x => !string.IsNullOrWhiteSpace(x))
                .ToList();
            addressDictionary.Add(streetNameResult, numbers);
        }

        
        HashSet<(string streetNames, string number)> uniqueAddresses = new();
        var regexAddressWithSlash = new Regex(@"\b\d+[а-яА-Я]?\d*/\d+\b", RegexOptions.Compiled);
        var regexRegularAddress = new Regex(@"^[а-яА-Я]", RegexOptions.Compiled);
        foreach (var item in addressDictionary)
        {
            if (item.Value.Any())
            {
                foreach (var number in item.Value)
                {
                    var match = regexAddressWithSlash.Match(number);
                    if (match.Success)
                    {
                        if (uniqueAddresses.Add((item.Key, match.Value)))
                        {
                            addressList.Add(Address.Create(item.Key, match.Value));
                        }
                        continue;
                    }
                    
                    if (!number.Contains("-"))
                    {
                        if (regexRegularAddress.IsMatch(number))
                        {
                            var pureNumber = new string(number.Where(x => char.IsDigit(x)).ToArray()); 
                            if (uniqueAddresses.Add((item.Key, pureNumber)))
                            {
                                addressList.Add(Address.Create(item.Key, pureNumber));
                            }
                        }
                        else
                        {
                            if (uniqueAddresses.Add((item.Key, number)))
                            {
                                addressList.Add(Address.Create(item.Key, number));
                            }
                        }
                        continue;
                    }
                
                    var splitNumber = number.Split("-", StringSplitOptions.TrimEntries);
                    if (splitNumber.Length == 2 && Regex.IsMatch(splitNumber[0], @"^\d") && Regex.IsMatch(splitNumber[1], @"\d"))
                    {
                        var normalizedNumber = int.Parse(splitNumber[0].NormalizedSplitNumber());
                        var normalizedNumber2 = int.Parse(splitNumber[1].NormalizedSplitNumber());
                        for (var initialNumber = Math.Min(normalizedNumber, normalizedNumber2); initialNumber <= Math.Max(normalizedNumber,normalizedNumber2); initialNumber++)
                        {
                            if (uniqueAddresses.Add((item.Key, initialNumber.ToString())))
                            {
                                addressList.Add(Address.Create(item.Key, initialNumber.ToString()));
                            }
                        }
                    }
                }
            }
            else
            {
                addressList.Add(Address.Create(item.Key, string.Empty));
            }
        }
        
        return addressList;
    }

    /// <summary>
    /// Получаем точное вхождение когда вариантов улиц несколько
    /// </summary>
    /// <param name="streetNameOccursList"></param>
    /// <param name="addressItem"></param>
    /// <returns></returns>
    private static string GetResultStreetName(List<string> streetNameOccursList, string addressItem)
    {
        if (addressItem.Contains("ВРК:", StringComparison.InvariantCultureIgnoreCase))
        {
            var result = addressItem.Substring("ВРК:".Length, addressItem.Length - "ВРК:".Length).Trim();
            var indexOfSpace = result.IndexOf(" ", StringComparison.InvariantCultureIgnoreCase);
            if (indexOfSpace != -1)
            {
                result = result.Substring(0, indexOfSpace);
            }
            
            return streetNameOccursList.FirstOrDefault(x => result.Equals(x, StringComparison.InvariantCultureIgnoreCase));
        }
        
        if (streetNameOccursList.Count > 1)
        {
            var sb = new StringBuilder();
            foreach (var symbol in addressItem)
            {
                sb.Append(symbol);
                if (streetNameOccursList.Any(x => x.Equals(sb.ToString(), StringComparison.InvariantCultureIgnoreCase)))
                {
                    return sb.ToString();
                }
            }
        }
        else if (streetNameOccursList.Count == 1)
        {
            return streetNameOccursList.First();
        }

        return string.Empty;
    }

    /// <summary>
    /// Получаем номера домов конкретной улицы
    /// </summary>
    /// <param name="addressItem"></param>
    /// <param name="streetNameResult"></param>
    /// <returns></returns>
    private static string GetResultStreetNumbers(string addressItem, string streetNameResult)
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
}