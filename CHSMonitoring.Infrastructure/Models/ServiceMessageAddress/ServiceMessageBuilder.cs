using CHSMonitoring.Infrastructure.Abstractions;
using CHSMonitoring.Infrastructure.Extensions;
using CHSMonitoring.Infrastructure.Models.Enums;
using CHSMonitoring.Infrastructure.Models.Parsers;

namespace CHSMonitoring.Infrastructure.Models.ServiceMessageAddress;

/// <summary>
/// Строитель объекта ServiceMessage
/// </summary>
public sealed class ServiceMessageBuilder : ServiceBuilder
{
    private ServiceMessage _serviceMessage = new();

    internal override void BuildOrganization(string organizationText)
    {
        var organization = OrganizationParser.ParseOrganization(organizationText);
        _serviceMessage.SetOrganization(organization);
    }

    internal override void BuildAddressesList(string addressesText)
    {
        var streetDescriptionEnums = Enum.GetValues(typeof(StreetNameEnum))
            .Cast<StreetNameEnum>()
            .Select(x => x.GetDescriptionValue())
            .ToList();

        var plannedDescriptionEnums = Enum.GetValues(typeof(PlannedSupplyTypeEnum))
            .Cast<PlannedSupplyTypeEnum>()
            .Select(x => x.GetDescriptionValue())
            .ToList();
        
        var splittedAddressesList = addressesText
            .Split(';', StringSplitOptions.TrimEntries)
            .ToList();
                            
        ///Получение дополнительных описаний адресов
        var additionalDescriptionList = splittedAddressesList
            .Where(x => plannedDescriptionEnums.Any(t => x.Contains(t, StringComparison.InvariantCultureIgnoreCase)))
            .ToList();
        foreach (var additionalDescription in additionalDescriptionList)
        {
            splittedAddressesList.Remove(additionalDescription);
        }
                            
        var addresses = splittedAddressesList
            .Where(x => streetDescriptionEnums.Any(t => x.Contains(t)))
            .ToList();
        
        var addressList = new List<Address>();
        if (!addresses.Any())
        {
            foreach (var address in splittedAddressesList)
            {
                addressList.Add(Address.Create(address, string.Empty));
            }
        }
        else
        {
            addressList = AddressParser.ParseAddresses(addresses);
        }

        _serviceMessage.SetDescription(string.Join(",", additionalDescriptionList));
        _serviceMessage.SetAddressList(addressList);
    }

    internal override void BuildDateInfo(string dateInfoText)
    {
        var splittedDateDescriptionList = dateInfoText
            .Split("\r\n", StringSplitOptions.TrimEntries)
            .Where(x => !string.IsNullOrWhiteSpace(x))
            .ToList();
        var dateInfo = DateParser.ParseDatesFromTo(splittedDateDescriptionList);
        _serviceMessage.SetDateInfo(dateInfo);
    }

    internal override ServiceMessage BuildSupplyMessageDescription()
    {
        return _serviceMessage;
    }
}