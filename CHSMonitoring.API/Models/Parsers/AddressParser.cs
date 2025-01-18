using CHSMonitoring.API.Enums;
using CHSMonitoring.API.Extensions;
using CHSMonitoring.API.Models.ServiceMessageAddress;

namespace CHSMonitoring.API.Models.Parsers;

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
            var streetName = streetNames
                .FirstOrDefault(x => streetNames.Any(t => addressItem.Contains(x, StringComparison.InvariantCultureIgnoreCase)));
            var indexOfOccurs = addressItem.IndexOf(streetName, StringComparison.InvariantCultureIgnoreCase);
            var resultedAddressWithoutNumbers = addressItem.Remove(indexOfOccurs, streetName.Length).Trim();
            
            var numbers = resultedAddressWithoutNumbers
                .Split(",", StringSplitOptions.TrimEntries)
                .Where(x => !string.IsNullOrWhiteSpace(x))
                .ToList();
            
            
            if (numbers.Any())
            {
                foreach (var number in numbers)
                {
                    if (!number.Contains("-"))
                    {
                        addressList.Add(Address.Create(streetName, number));
                    }
                
                    var splitNumber = number.Split("-", StringSplitOptions.TrimEntries);
                    if (splitNumber.Length == 2)
                    {
                        var number1 = int.Parse(splitNumber[0]);
                        var number2 = int.Parse(splitNumber[1]);
            
                        for (var streetNumber = number1; streetNumber <= number2; streetNumber++)
                        {
                            addressList.Add(Address.Create(streetName, streetNumber.ToString()));
                        }
                    }
                }
            }
            else
            {
                addressList.Add(Address.Create(streetName, string.Empty));
            }
        }

        return addressList;
    }
}