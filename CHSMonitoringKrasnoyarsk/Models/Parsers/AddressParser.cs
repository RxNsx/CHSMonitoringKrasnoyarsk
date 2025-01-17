using CHSMonitoringKrasnoyarsk.Enums;
using CHSMonitoringKrasnoyarsk.Extensions;
using CHSMonitoringKrasnoyarsk.Models.SupplyMessageDescription;

namespace CHSMonitoringKrasnoyarsk.Models.Parsers;

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

        var itemToRemove = addresses.FirstOrDefault(x => streetNames.Any(t => x.Contains(t)));
        if (itemToRemove is null)
        {
            throw new ArgumentNullException(nameof(itemToRemove), "ItemToRemove must be not null");
        }
        var streetName = streetNames.FirstOrDefault(x => itemToRemove.Contains(x));
        if (string.IsNullOrEmpty(streetName))
        {
            throw new ArgumentNullException(nameof(itemToRemove), "StreetName must be not null");
        }
        
        var indexOfOccurs = itemToRemove.IndexOf(streetName, StringComparison.InvariantCultureIgnoreCase);
        itemToRemove = itemToRemove.Remove(indexOfOccurs, streetName.Length).Trim();

        var numbers = itemToRemove
            .Split(",", StringSplitOptions.TrimEntries)
            .Where(x => !string.IsNullOrWhiteSpace(x))
            .ToList();

        List<Address> addressList = new();

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

        return addressList;
    }
}