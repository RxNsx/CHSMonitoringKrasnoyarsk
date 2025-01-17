using CHSMonitoringKrasnoyarsk.Enums;
using CHSMonitoringKrasnoyarsk.Extensions;
using CHSMonitoringKrasnoyarsk.Interfaces;
using CHSMonitoringKrasnoyarsk.Models.SupplyDescription;

namespace CHSMonitoringKrasnoyarsk.Services;

public class AddressParserService : IAddressParserService
{
    private readonly ILogger<AddressParserService> _logger;
    
    /// <summary>
    /// Конструктор
    /// </summary>
    /// <param name="loggerFactory"></param>
    public AddressParserService(ILoggerFactory loggerFactory)
    {
        _logger = loggerFactory.CreateLogger<AddressParserService>();
    }
    
    public List<Address> ParseAddresses(List<string> addresses)
    {
        _logger.LogInformation("Starting get addresses");
        var streetNames = Enum.GetValues(typeof(StreetNameEnum))
            .Cast<StreetNameEnum>()
            .Select(x => x.GetDescriptionValue())
            .ToList();

        var itemToRemove = addresses.FirstOrDefault(x => streetNames.Any(t => x.Contains(t)));
        if (itemToRemove is null)
        {
            _logger.LogError("ItemToRemove is null");
            throw new ArgumentNullException(nameof(itemToRemove), "ItemToRemove must be not null");
        }
        var streetName = streetNames.FirstOrDefault(x => itemToRemove.Contains(x));
        if (string.IsNullOrEmpty(streetName))
        {
            _logger.LogError("StreetName is null");
            throw new ArgumentNullException(nameof(itemToRemove), "StreetName must be not null");
        }
        
        var indexOfOccurs = itemToRemove.IndexOf(streetName, StringComparison.Ordinal);
        itemToRemove = itemToRemove.Remove(indexOfOccurs, streetName.Length).Trim();

        var numbers = itemToRemove
            .Split(",", StringSplitOptions.TrimEntries)
            .Where(x => !string.IsNullOrWhiteSpace(x))
            .ToList();

        List<Address> addressList = new();
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

        _logger.LogInformation($"Addresses received: {addressList.Count}");
        return addressList;
    }
}