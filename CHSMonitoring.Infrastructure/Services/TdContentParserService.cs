using CHSMonitoring.Domain.Entities;
using CHSMonitoring.Domain.Enums;
using CHSMonitoring.Infrastructure.Common;
using CHSMonitoring.Infrastructure.Extensions;
using CHSMonitoring.Infrastructure.Interfaces;
using CHSMonitoring.Infrastructure.Interfaces.Workers;
using CHSMonitoring.Infrastructure.Models;
using CHSMonitoring.Infrastructure.Models.Enums;
using CHSMonitoring.Infrastructure.Models.ServiceMessageAddress;
using Microsoft.Extensions.DependencyInjection;

namespace CHSMonitoring.Infrastructure.Services;

/// <summary>
/// Cервис разбора данных из td
/// </summary>
public class TdContentParserService : ITdContentParserService
{
    private readonly IAddressParserService _addressParserService;
    private readonly IOrganizationParserService _organizationParserService;
    private readonly IDateParserService _dateParserService;
    
    /// <summary>
    /// Конструктор
    /// </summary>
    public TdContentParserService(IServiceScopeFactory serviceScopeFactory)
    {
        var scope = serviceScopeFactory.CreateScope();
        _addressParserService = scope.ServiceProvider.GetRequiredService<IAddressParserService>();
        _organizationParserService = scope.ServiceProvider.GetRequiredService<IOrganizationParserService>();
        _dateParserService = scope.ServiceProvider.GetRequiredService<IDateParserService>();
    }

    /// <summary>
    /// Получение сообщений об отключениях из данных парсинга
    /// </summary>
    /// <param name="tableDescriptions"></param>
    public async Task<List<ServiceAddress>> GetServiceMessages(List<TableDescription> tableDescriptions)
    {
        var districtDataDict = GetDistrictsDataFromTableDescriptions(tableDescriptions);
        
        var supplyTypesEnums = Enum.GetValues(typeof(ServiceTypeEnum))
            .Cast<ServiceTypeEnum>()
            .Select(x => x.GetDescriptionValue())
            .ToList();

        var supplyTypeIndexes = new Dictionary<string, List<int>>();
        foreach (var item in districtDataDict)
        {
            var indexesOfSupplies = item.Value
                .Where(x => supplyTypesEnums.Any(t => x.InnerText.NormalizeText().Contains(t, StringComparison.InvariantCultureIgnoreCase)))
                .Select(x => x.Index)
                .ToList();

            if (!supplyTypeIndexes.TryAdd(item.Key, indexesOfSupplies))
            {
                throw new ArgumentException("dict.TryAdd(item.Key, indexesOfSupplies)");
            }
        }
        
        supplyTypeIndexes = AddTheEndOfSupplyInfo(supplyTypeIndexes);
        var tableDescriptionList = new List<List<TableDescription>>();
        foreach (var item in supplyTypeIndexes)
        {
            for (var i = 1; i < item.Value.Count; i++)
            {
                var pointer1 = item.Value[i - 1];
                var pointer2 = item.Value[i];
                tableDescriptionList.Add(districtDataDict[item.Key]
                    .Where(x => x.Index >= pointer1 && x.Index < pointer2)
                    .ToList());
            }
        }
        
        //TODO: Check concurrent flow
        var serviceAddressDict = new Dictionary<string, List<ServiceMessage>>();
        var createMessageDate = DateTime.UtcNow;
        
        foreach (var tableDescriptionItem in tableDescriptionList)
        {
            var districtKey = supplyTypeIndexes.FirstOrDefault(x => x.Value.Contains(tableDescriptionItem[0].Index)).Key;
            var serviceAddressMessageBuilder = new ServiceMessageBuilder();

            for (var i = 0; i < tableDescriptionItem.Count; i = i + 3)
            {
                var organizationText = tableDescriptionItem[i].InnerText.NormalizeText();
                var addressesText = tableDescriptionItem[i + 1].InnerText.NormalizeText();
                var dateInfoText = tableDescriptionItem[i + 2].InnerText.NormalizeText();

                serviceAddressMessageBuilder.BuildOrganization(organizationText);
            
                var plannedDescriptionMessage = _addressParserService.GetPlannedDescriptionMessage(addressesText);
                serviceAddressMessageBuilder.AddDescription(plannedDescriptionMessage.description);
                
                var addressDictionary = _addressParserService.GetAddressDictFromAddressText(plannedDescriptionMessage.outputText);
                var addressList = await _addressParserService.ParseAddressNumbers(addressDictionary).ConfigureAwait(false);
                serviceAddressMessageBuilder.AddAddressesList(addressList);
            
                serviceAddressMessageBuilder.AddDateInfo(dateInfoText, createMessageDate);
                serviceAddressMessageBuilder.AddDistrictName(districtKey);
                var serviceMessage = serviceAddressMessageBuilder.BuildServiceAddressMessage();
            
                
                if(serviceAddressDict.ContainsKey(districtKey))
                {
                    serviceAddressDict[districtKey].Add(serviceMessage);
                }
                else
                {
                    serviceAddressDict.Add(districtKey, new List<ServiceMessage>() {serviceMessage});
                }
            }
        }

        return GetServiceAddressList(serviceAddressDict);
    }

    /// <summary>
    /// Выбор индексов для считывания информации между индексом а и б
    /// </summary>
    /// <param name="supplyTypeIndexes"></param>
    /// <returns></returns>
    private Dictionary<string, List<int>> AddTheEndOfSupplyInfo(Dictionary<string, List<int>> supplyTypeIndexes)
    {
        //Количество записей в таблице на одно событие
        const int supplyItems = 3;
        var notEmptySupplies = supplyTypeIndexes
            .Where(x => x.Value.Any())
            .Select(x => x)
            .ToList();
        
        foreach (var item in notEmptySupplies)
        {
            var preLastMarkerValue = supplyTypeIndexes[item.Key].Last();
            supplyTypeIndexes[item.Key].Add(preLastMarkerValue + supplyItems);
        }

        return supplyTypeIndexes;
    }

    /// <summary>
    /// Получение информации по районам
    /// </summary>
    /// <param name="tableDescriptions"></param>
    /// <returns></returns>
    private Dictionary<string, List<TableDescription>> GetDistrictsDataFromTableDescriptions(List<TableDescription> tableDescriptions)
    {
        var districtValues = new List<List<TableDescription>>();
        var districts = tableDescriptions
            .Where(x => x.InnerText.Contains("район", StringComparison.OrdinalIgnoreCase))
            .ToList();
        
        for (var i = 0; i < districts.Count; i++)
        {
            if (i + 1 == districts.Count)
            {
                var endList = tableDescriptions.GetRange(districts[i].Index, tableDescriptions.Last().Index + 1 - districts[i].Index);
                districtValues.Add(endList);
            }
            else
            {
                var newList = tableDescriptions.GetRange(districts[i].Index, districts[i + 1].Index - districts[i].Index);
                districtValues.Add(newList);
            }
        }

        foreach (var districtValue in districts)
        {
            districtValue.InnerText = districtValue.InnerText.NormalizeText();
        }
        
        return RestrictionTableDescriptionToDict(districtValues);
    }

    /// <summary>
    /// Распределяет полученный список по словарю (Район, Сообщения об отключениях)
    /// </summary>
    /// <param name="tableDescriptions"></param>
    /// <returns></returns>
    /// <exception cref="ArgumentException"></exception>
    private Dictionary<string, List<TableDescription>> RestrictionTableDescriptionToDict(List<List<TableDescription>> tableDescriptions)
    {
        var dict = new Dictionary<string, List<TableDescription>>();
        var districtNames = Enum.GetValues(typeof(DistrictEnum))
            .Cast<DistrictEnum>()
            .Select(x => x.GetDescriptionValue())
            .ToList();

        tableDescriptions = RemovePlannedTableDescription(tableDescriptions);
        foreach (var tableDescriptionList in tableDescriptions)
        {
            foreach (var tableDescription in tableDescriptionList.ToList())
            {
                if (districtNames.Any(x => districtNames.Contains(tableDescription.InnerText)))
                {
                    var districtNameKey = tableDescription.InnerText.NormalizeText();
                    tableDescriptionList.Remove(tableDescription);
                    
                    if (!dict.TryAdd(districtNameKey, tableDescriptionList))
                    {
                        throw new ArgumentException("dict.TryAdd(districtNameKey, tableDescriptionList)");
                    }
                }
            }
        }

        return dict;
    }

    /// <summary>
    /// Убирает запись Запланированное на завтра
    /// </summary>
    /// <param name="tableDescriptions"></param>
    /// <returns></returns>
    private List<List<TableDescription>> RemovePlannedTableDescription(List<List<TableDescription>> tableDescriptions)
    {
        List<string> plannedCollection = new()
        {
            PlannedSupplyTypeEnum.Planned.GetDescriptionValue(),
            PlannedSupplyTypeEnum.Planned2.GetDescriptionValue(),

        };
        
        foreach (var item in tableDescriptions)
        {
            var removePlannedItems = item
                .Select(x => x.InnerText.NormalizeText())
                .Where(x => plannedCollection.Any(t => x.Contains(t, StringComparison.InvariantCultureIgnoreCase))).ToList();
            if (removePlannedItems.Any())
            {
                foreach (var removeItem in removePlannedItems)
                {
                    var item1 = item.FirstOrDefault(x => x.InnerText.NormalizeText().Contains(removeItem, StringComparison.InvariantCultureIgnoreCase));
                    item.Remove(item1!);
                }
            }
        }

        return tableDescriptions;
    }

    /// <summary>
    /// Получение списка адресов с отключениями
    /// </summary>
    /// <param name="serviceMessages"></param>
    /// <returns></returns>
    public List<ServiceAddress> GetServiceAddressList(Dictionary<string, List<ServiceMessage>> serviceMessages)
    {
        List<ServiceAddress> serviceAddressList = [];
        foreach (var serviceMessage in serviceMessages.SelectMany(x => x.Value).ToList())
        {
            var addressList = serviceMessage.AddressList;
            foreach (var address in addressList)
            {
                serviceAddressList.Add(new ServiceAddress()
                {
                    DistrictId = CommonData.DistrictsData.FirstOrDefault(x => x.DistrictName.Equals(serviceMessage.DistrictName, StringComparison.InvariantCultureIgnoreCase)).Id,
                    StreetId = CommonData.StreetsData.FirstOrDefault(x => x.StreetName.Equals(address.StreetName,StringComparison.InvariantCultureIgnoreCase)).Id,
                    ServiceTypeId = CommonData.ServiceTypesData.FirstOrDefault(x => x.ServiceTypeName.Equals(serviceMessage.Organization.SupplyTypeName, StringComparison.InvariantCultureIgnoreCase)).Id,
                    HouseNumber = address.Number,
                    Description = serviceMessage.Description,
                    DateTimeFromString = serviceMessage.DateInfo.DateFromString,
                    DateTimeToString = serviceMessage.DateInfo.DateToString,
                    From = serviceMessage.DateInfo.DateFrom,
                    To = serviceMessage.DateInfo.DateTo,
                    CreatedDate = serviceMessage.CreatedDate,
                    IsReadOnly = true
                });
            }
        }

        return serviceAddressList;
    }
}