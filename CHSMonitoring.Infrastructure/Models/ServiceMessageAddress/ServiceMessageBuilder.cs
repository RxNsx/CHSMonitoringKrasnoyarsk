using System.Text.RegularExpressions;
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

        ///Получение минимального индекса
        var plannedIndexOfText = plannedDescriptionEnums
            .DefaultIfEmpty()
            .Select(x => addressesText.IndexOf(x, StringComparison.InvariantCultureIgnoreCase))
            .Where(x => x != -1)
            .Min();
        if (plannedIndexOfText != 0)
        {
            var additionalDescriptionValue = addressesText.Substring(plannedIndexOfText, addressesText.Length - plannedIndexOfText);
            addressesText = addressesText.Remove(plannedIndexOfText, addressesText.Length - plannedIndexOfText).Trim();
            _serviceMessage.SetDescription(additionalDescriptionValue);
        }
        
        //TODO: Отсекать полностью строку если она начинается на какой то плановый вид обслуживания
        var splittedAddressesList = addressesText
            .Split(';', StringSplitOptions.TrimEntries)
            .ToList();
                            
        var addresses = splittedAddressesList
            .Where(x => streetDescriptionEnums.Any(t => x.Contains(t, StringComparison.InvariantCultureIgnoreCase)))
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

        // _serviceMessage.SetDescription(string.Join(",", additionalDescriptionList));
        _serviceMessage.SetAddressList(addressList);
    }

    internal override void BuildDateInfo(string dateInfoText)
    {
        var pattern = @"(\d{1,2} [а-я]+ \d{1,2}-\d{1,2})";
        var splitted = Regex.Split(dateInfoText, pattern);

        var messagesToParse = splitted
            .Where(x => !string.IsNullOrWhiteSpace(x))
            .ToList();

        var dateInfo = DateParser.ParseDatesFromTo(messagesToParse);
        _serviceMessage.SetDateInfo(dateInfo);
    }

    internal override void BuildDistrictName(string districtName)
    {
        _serviceMessage.SetDistrictName(districtName);
    }

    internal override ServiceMessage BuildServiceAddressMessage()
    {
        return _serviceMessage;
    }
}