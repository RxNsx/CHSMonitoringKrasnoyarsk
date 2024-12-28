using System.Text.RegularExpressions;
using CHSMonitoringKrasnoyarsk.Enums;
using CHSMonitoringKrasnoyarsk.Extensions;
using CHSMonitoringKrasnoyarsk.Interfaces;
using CHSMonitoringKrasnoyarsk.Models;
using HtmlAgilityPack;

namespace CHSMonitoringKrasnoyarsk.Services;

/// <summary>
/// Cервис разбора данных из td
/// </summary>
public class TdContentParserService : ITdContentParserService
{
    public Dictionary<string, List<TableDescription>> GetDistrictTableDescriptionsFromHtmlDocument(HtmlDocument htmlDocument)
    {
        var tdContents = htmlDocument.DocumentNode.SelectNodes("//td")
            .Where(td => td.InnerText != "&nbsp;" && td.InnerText != string.Empty)
            .Select((td, index) => new TableDescription
            {
                InnerText = td.InnerText,
                Index = index
            })
            .ToList();
            
        var districtValues = GetDistrictsDataFromTableDescriptions(tdContents);
        var clearedDistrictValues = ClearEscapeSymbolsFromTdContent(districtValues);
        var eventsDictionary = RestrictionTableDescriptionToDict(clearedDistrictValues);
        
        return eventsDictionary;
    }

    /// <summary>
    /// Получение информации по районам
    /// </summary>
    /// <param name="tableDescriptions"></param>
    /// <returns></returns>
    private List<List<TableDescription>> GetDistrictsDataFromTableDescriptions(List<TableDescription> tableDescriptions)
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

        return districtValues;
    }
    
    
    /// <summary>
    /// Очищает символы переноса строки
    /// </summary>
    /// <param name="tableDescriptionLists"></param>
    /// <returns></returns>
    private List<List<TableDescription>> ClearEscapeSymbolsFromTdContent(List<List<TableDescription>> tableDescriptionLists)
    {
        try
        {
            foreach (var district in tableDescriptionLists)
            {
                foreach (var tableDescription in district)
                {
                    tableDescription.InnerText = tableDescription.InnerText.Trim();
            
                    var newLineSymbolsCount = Regex.Matches(tableDescription.InnerText, "\n").Count;
                    while (newLineSymbolsCount > 1)
                    {
                        if (string.IsNullOrEmpty(tableDescription.InnerText) &&
                            tableDescription.InnerText == "&nbsp;")
                        {
                            continue;
                        }
                        
                        tableDescription.InnerText =  tableDescription.InnerText.Replace("\n", "");
                        newLineSymbolsCount--;
                    }
                    
                    var carriageSymbolsCount = Regex.Matches(tableDescription.InnerText, "\r").Count;
                    while (carriageSymbolsCount > 0)
                    {
                        if (string.IsNullOrEmpty(tableDescription.InnerText) &&
                            tableDescription.InnerText == "&nbsp;")
                        {
                            continue;
                        }
                        
                        tableDescription.InnerText =  tableDescription.InnerText.Replace("\r", "");
                        carriageSymbolsCount--;
                    }

                    tableDescription.InnerText = tableDescription.InnerText.NormalizeSpacesInText();
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex);
            throw;
        }

        //TODO: Разделить по /r/n
        return tableDescriptionLists;
    }

    private Dictionary<string, List<TableDescription>> RestrictionTableDescriptionToDict(
        List<List<TableDescription>> tableDescriptions)
    {
        var dict = new Dictionary<string, List<TableDescription>>();
        
        var districtNames = Enum.GetValues(typeof(District))
            .Cast<District>()
            .Select(x => x.GetDescriptionValue())
            .ToList();
        
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

        // foreach (var dictionaryList in dict)
        // {
        //     if (dictionaryList.Value.Contains("Запланировано"))
        //     {
        //         
        //     }
        // }

        return dict;
    }
}