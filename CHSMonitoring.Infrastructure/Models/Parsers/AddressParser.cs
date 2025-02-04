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
        }
        
        foreach (var doubleStreet in doubleStreets)
        {
            concreteAddresses.AddRange(doubleStreet.Split("/", StringSplitOptions.TrimEntries));
        }
        
        #endregion
        
        List<Address> addressList = new();
        foreach (var addressItem in concreteAddresses)
        {
            //Выбираем все улицы которые могут подойти по названию
            var streetNameOccursList = streetNames
                .Where(x => streetNames.Any(t => addressItem.Contains(x, StringComparison.InvariantCultureIgnoreCase)))
                .ToList();
            //Выбираем точное вхождение улицы
            var streetNameResult = GetResultStreetName(streetNameOccursList, addressItem);
            
            var indexOfOccurs = addressItem.IndexOf(streetNameResult, StringComparison.InvariantCultureIgnoreCase);
            var resultedAddressWithoutNumbers = addressItem.Remove(indexOfOccurs, streetNameResult.Length).Trim();
            
            var numbers = resultedAddressWithoutNumbers
                .Split(",", StringSplitOptions.TrimEntries)
                .Where(x => !string.IsNullOrWhiteSpace(x))
                .ToList();
            
            if (numbers.Any())
            {
                foreach (var number in numbers)
                {
                    var match = Regex.Match(number, @"\b\d+[а-яА-Я]?\d*/\d+\b");
                    if (match.Success)
                    {
                        addressList.Add(Address.Create(streetNameResult, match.Value));
                    }
                    
                    if (!number.Contains("-"))
                    {
                        if (Regex.IsMatch(number, @"^[а-яА-Я]"))
                        {
                            var pureNumber = string.Join("",number.Where(x => char.IsDigit(x)));
                            addressList.Add(Address.Create(streetNameResult, pureNumber));
                        }
                        else
                        {
                            addressList.Add(Address.Create(streetNameResult, number));
                        }
                    }
                
                    var splitNumber = number.Split("-", StringSplitOptions.TrimEntries);
                    if (splitNumber.Length == 2 && Regex.IsMatch(splitNumber[0], @"^\d") && Regex.IsMatch(splitNumber[1], @"\d"))
                    {
                        var normalizedNumber = splitNumber[0].NormalizedSplitNumber();
                        var normalizedNumber2 = splitNumber[1].NormalizedSplitNumber();
                        var number1 = int.Parse(normalizedNumber);
                        var number2 = int.Parse(normalizedNumber2);
            
                        for (var streetNumber = number1; streetNumber <= number2; streetNumber++)
                        {
                            addressList.Add(Address.Create(streetNameResult, streetNumber.ToString()));
                        }
                    }
                }
            }
            else
            {
                addressList.Add(Address.Create(streetNameResult, string.Empty));
            }
        }
        
        return addressList;
    }

    private static string GetResultStreetName(List<string> streetNameOccursList, string addressItem)
    {
        if (streetNameOccursList.Count > 1)
        {
            var patternToCheck = string.Empty;
            for (var i = 0; i < addressItem.Length; i++)
            {
                foreach (var symbol in addressItem)
                {
                    patternToCheck += symbol;
                    if (streetNameOccursList.Any(x => patternToCheck.Equals(x, StringComparison.InvariantCultureIgnoreCase)))
                    {
                        return streetNameOccursList.FirstOrDefault(x => patternToCheck.Equals(x, StringComparison.InvariantCultureIgnoreCase));
                    }
                }
            }
        }
        else if (streetNameOccursList.Count == 1)
        {
            return streetNameOccursList.First();
        }

        return string.Empty;
    }
}