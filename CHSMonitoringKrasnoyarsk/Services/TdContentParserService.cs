using System.Text.RegularExpressions;
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
    public List<List<TableDescription>> GetDistrictTableDescriptionsFromHtmlDocument(HtmlDocument htmlDocument)
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
        
        return clearedDistrictValues;
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

        return tableDescriptionLists;
    }
}