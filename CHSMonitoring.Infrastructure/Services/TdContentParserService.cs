using CHSMonitoring.Domain.Entities;
using CHSMonitoring.Infrastructure.Extensions;
using CHSMonitoring.Infrastructure.Interfaces.Workers;
using CHSMonitoring.Infrastructure.Models;
using CHSMonitoring.Infrastructure.Models.Enums;
using CHSMonitoring.Infrastructure.Models.ServiceMessageAddress;

namespace CHSMonitoring.Infrastructure.Services;

/// <summary>
/// Cервис разбора данных из td
/// </summary>
public class TdContentParserService : ITdContentParserService
{
    /// <summary>
    /// Конструктор
    /// </summary>
    public TdContentParserService()
    {
        
    }

    /// <summary>
    /// Получение сообщений об отключениях из данных парсинга
    /// </summary>
    /// <param name="tableDescriptions"></param>
    public List<ServiceAddress> GetServiceMessages(List<TableDescription> tableDescriptions)
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
                .Where(x => supplyTypesEnums.Any(t => x.InnerText.Contains(t)))
                .Select(x => x.Index)
                .ToList();

            if (!supplyTypeIndexes.TryAdd(item.Key, indexesOfSupplies))
            {
                throw new ArgumentException("dict.TryAdd(item.Key, indexesOfSupplies)");
            }
        }
        
        supplyTypeIndexes = AddTheEndOfSupplyInfo(supplyTypeIndexes);
        
        var supplyDescriptionList = new Dictionary<string, List<ServiceMessage>>();
        foreach (var item in supplyTypeIndexes)
        {
            for (var i = 1; i < item.Value.Count; i++)
            {
                var pointer1 = item.Value[i - 1];
                var pointer2 = item.Value[i];

                var tableDescriptionItemList = districtDataDict[item.Key]
                    .Where(x => x.Index >= pointer1 && x.Index < pointer2)
                    .ToList();

                if (tableDescriptionItemList.Any())
                {
                    var supplyDescriptionBuilder = new ServiceMessageBuilder();
                    var organizationText = tableDescriptionItemList[0].InnerText.NormalizeText();
                    var addressesText = tableDescriptionItemList[1].InnerText.NormalizeText();
                    var dateInfoText = tableDescriptionItemList[2].InnerText.NormalizeText();

                    supplyDescriptionBuilder.BuildOrganization(organizationText);
                    supplyDescriptionBuilder.BuildAddressesList(addressesText);
                    supplyDescriptionBuilder.BuildDateInfo(dateInfoText);
                    supplyDescriptionBuilder.BuildDistrictName(item.Key);
                    var supplyMessageDescription = supplyDescriptionBuilder.BuildSupplyMessageDescription();

                    if (!supplyDescriptionList.TryGetValue(item.Key, out _))
                    {
                        supplyDescriptionList.Add(item.Key, new List<ServiceMessage> { supplyMessageDescription });
                    }
                    else
                    {
                        supplyDescriptionList[item.Key].Add(supplyMessageDescription);
                    }
                }
            }
        }

        return GetServiceAddressList(supplyDescriptionList);
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
                    var districtNameKey = tableDescription.InnerText;
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
        foreach (var item in tableDescriptions)
        {
            var removePlanned = item.FirstOrDefault(x => x.InnerText.Contains(PlannedSupplyTypeEnum.Planned.GetDescriptionValue()));
            if (removePlanned != null)
            {
                item.Remove(removePlanned);
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
        List<ServiceAddress> serviceAddresses = [];
        foreach (var serviceMessage in serviceMessages.SelectMany(x => x.Value).ToList())
        {
            var addressList = serviceMessage.AddressList;
            foreach (var address in addressList)
            {
                var serviceAddress = new ServiceAddress();
                serviceAddress.DistrictName = serviceMessage.DistrictName;
                serviceAddress.StreetName = address.StreetName;
                serviceAddress.HouseNumber = address.Number;
                serviceAddress.Description = serviceMessage.Description;
                serviceAddress.ServiceType = serviceMessage.Organization.SupplyTypeName;
                        
                serviceAddress.DateTimeFromString = serviceMessage.DateInfo.DateFromString;
                serviceAddress.DateTimeToString = serviceMessage.DateInfo.DateToString;
                serviceAddress.From = serviceMessage.DateInfo.DateFrom;
                serviceAddress.To = serviceMessage.DateInfo.DateTo;
                serviceAddress.CreatedDate = serviceMessage.CreatedDate;
                        
                serviceAddresses.Add(serviceAddress);
            }
        }

        return serviceAddresses;
    }
}