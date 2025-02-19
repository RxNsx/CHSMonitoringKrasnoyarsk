using System.Text.RegularExpressions;
using CHSMonitoring.Infrastructure.Abstractions;
using CHSMonitoring.Infrastructure.Parsers;

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

    internal override void AddAddressesList(List<Address> addressList)
    {
        _serviceMessage.SetAddressList(addressList);
    }

    internal override void AddDescription(string description)
    {
        _serviceMessage.SetDescription(description);
    }

    internal override void AddDateInfo(string dateInfoText, DateTime createdDate)
    {
        var pattern = @"(\d{1,2} [а-я]+ \d{1,2}-\d{1,2})";
        var splitted = Regex.Split(dateInfoText, pattern);

        var messagesToParse = splitted
            .Where(x => !string.IsNullOrWhiteSpace(x))
            .ToList();

        var dateInfo = DateParser.ParseDatesFromTo(messagesToParse);

        _serviceMessage.CreatedDate = createdDate;
        _serviceMessage.SetDateInfo(dateInfo);
    }

    internal override void AddDistrictName(string districtName)
    {
        _serviceMessage.SetDistrictName(districtName);
    }

    internal override ServiceMessage BuildServiceAddressMessage()
    {
        return _serviceMessage;
    }
}