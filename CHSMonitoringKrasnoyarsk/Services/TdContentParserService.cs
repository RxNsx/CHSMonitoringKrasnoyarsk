using System.Text.RegularExpressions;
using CHSMonitoringKrasnoyarsk.Enums;
using CHSMonitoringKrasnoyarsk.Extensions;
using CHSMonitoringKrasnoyarsk.Interfaces;
using CHSMonitoringKrasnoyarsk.Models;
using CHSMonitoringKrasnoyarsk.Models.SupplyDescription;
using HtmlAgilityPack;

namespace CHSMonitoringKrasnoyarsk.Services;

/// <summary>
/// Cервис разбора данных из td
/// </summary>
public class TdContentParserService : ITdContentParserService
{
    /// <summary>
    /// Получение списка с индексами для каждого района
    /// </summary>
    /// <param name="districtValues"></param>
    /// <exception cref="ArgumentException"></exception>
    public void GetSupplyAlarmDescriptions(Dictionary<string, List<TableDescription>> districtValues)
    {
        var supplyTypesEnums = Enum.GetValues(typeof(SupplyTypeEnum))
            .Cast<SupplyTypeEnum>()
            .Select(x => x.GetDescriptionValue())
            .ToList();

        var supplyTypeIndexes = new Dictionary<string, List<int>>();
        foreach (var item in districtValues)
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
        
        var supplyAlarmDescriptions = new Dictionary<string, List<TableDescription>>();
        foreach (var item in supplyTypeIndexes)
        {
            if (item.Value.Any())
            {
                var streetDescriptionEnums = Enum.GetValues(typeof(StreetNameEnum))
                    .Cast<StreetNameEnum>()
                    .Select(x => x.GetDescriptionValue())
                    .ToList();

                var plannedDescriptionEnums = Enum.GetValues(typeof(PlannedSupplyTypeEnum))
                    .Cast<PlannedSupplyTypeEnum>()
                    .Select(x => x.GetDescriptionValue())
                    .ToList();
                
                for (var i = 1; i < item.Value.Count; i++)
                {
                    var pointer1 = item.Value[i - 1];
                    var pointer2 = item.Value[i];

                    var tableDescriptionItemList = districtValues[item.Key]
                        .Where(x => x.Index >= pointer1 && x.Index < pointer2)
                        .ToList();
                    
                    if (tableDescriptionItemList.Any())
                    {
                        if(!supplyAlarmDescriptions.TryGetValue(item.Key, out _))
                        {
                            var splittedOrganizationDescriptionList = tableDescriptionItemList[0].InnerText.Split("\r\n", StringSplitOptions.TrimEntries)
                                .ToList();
                            var organization = splittedOrganizationDescriptionList.CreateOrganizationFromList();

                            var splittedAddressesDescriptionList = tableDescriptionItemList[1].InnerText
                                .NormalizeText()
                                .Split(';', StringSplitOptions.TrimEntries)
                                .ToList();

                            var additionalDescriptionItem = splittedAddressesDescriptionList
                                .FirstOrDefault(x => plannedDescriptionEnums.Any(t => x.Contains(t, StringComparison.InvariantCultureIgnoreCase)));
                            splittedAddressesDescriptionList.Remove(additionalDescriptionItem);
                            
                            
                            //TODO: Распарсить адреса
                            var addresses = splittedAddressesDescriptionList
                                .Where(x => streetDescriptionEnums.Any(t => x.Contains(t)))
                                .ToList();
                            //TODO: Распарсить номера домов
                            var addressNumbers = splittedAddressesDescriptionList.Select(x => x.Split(" "));
                            
                            
                            //TODO: Вынести в отдельное дополнительное описание
                            var splittedDateDescriptionList = tableDescriptionItemList[2].InnerText.Split("\r\n", StringSplitOptions.TrimEntries);
                            //TODO: Распарсить даты
                            //TODO: В дате есть вариант "Отмена"
                        }
                    }
                }
            }
        }
    }

    /// <summary>
    /// Выбор индексов для считывания информации между индексом а и б
    /// </summary>
    /// <param name="supplyTypeIndexes"></param>
    /// <returns></returns>
    public Dictionary<string, List<int>> AddTheEndOfSupplyInfo(Dictionary<string, List<int>> supplyTypeIndexes)
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
    public List<List<TableDescription>> GetDistrictsDataFromTableDescriptions(List<TableDescription> tableDescriptions)
    {
        var districtValues = new List<List<TableDescription>>();
        var districts = tableDescriptions
            .Where(x => x.InnerText.Contains("район", StringComparison.OrdinalIgnoreCase))
            .ToList();
        
        for (var i = 0; i < districts.Count; i++)
        {
            if (i + 1 == districts.Count)
            {
                var endList = tableDescriptions.GetRange(districts[i].Index, tableDescriptions.Last().Index - districts[i].Index);
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
        
        return districtValues;
    }

    /// <summary>
    /// Распределяет полученный список по словарю (Район, Сообщения об отключениях)
    /// </summary>
    /// <param name="tableDescriptions"></param>
    /// <returns></returns>
    /// <exception cref="ArgumentException"></exception>
    public Dictionary<string, List<TableDescription>> RestrictionTableDescriptionToDict(List<List<TableDescription>> tableDescriptions)
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
    public List<List<TableDescription>> RemovePlannedTableDescription(List<List<TableDescription>> tableDescriptions)
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
}