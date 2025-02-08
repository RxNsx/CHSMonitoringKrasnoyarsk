using System.Text.RegularExpressions;
using CHSMonitoring.Infrastructure.Abstractions;
using CHSMonitoring.Infrastructure.Common;
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

    internal override void AddAddressesList(string addressesText)
    {
        var plannedDescriptionEnums = Enum.GetValues(typeof(PlannedSupplyTypeEnum))
            .Cast<PlannedSupplyTypeEnum>()
            .Select(x => x.GetDescriptionValue())
            .ToList();

        ///Получение минимального индекса запланированного сообщения
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
        
        var splittedAddressesList = addressesText
            .Split(';', StringSplitOptions.TrimEntries)
            .ToList();
        splittedAddressesList = ReplaceAddreses(splittedAddressesList);
        var addresses = splittedAddressesList
            .Where(x => CommonData.StreetsData.Any(t => x.Contains(t.StreetName, StringComparison.InvariantCultureIgnoreCase)))
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

    internal override void AddDateInfo(string dateInfoText)
    {
        var pattern = @"(\d{1,2} [а-я]+ \d{1,2}-\d{1,2})";
        var splitted = Regex.Split(dateInfoText, pattern);

        var messagesToParse = splitted
            .Where(x => !string.IsNullOrWhiteSpace(x))
            .ToList();

        var dateInfo = DateParser.ParseDatesFromTo(messagesToParse);
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

    /// <summary>
    /// Обработка улиц с буквами Е Ё
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
}