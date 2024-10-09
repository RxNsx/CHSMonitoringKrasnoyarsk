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
            
        var districts = tdContents
            .Where(x => x.InnerText.Contains("район", StringComparison.OrdinalIgnoreCase))
            .ToList();

        var districtValues = new List<List<TableDescription>>();
        for (int i = 0; i < districts.Count; i++)
        {
            if (i + 1 == districts.Count)
            {
                var endList = tdContents.GetRange(districts[i].Index, tdContents.Last().Index - districts[i].Index);
                districtValues.Add(endList);
            }
            else
            {
                var newList = tdContents.GetRange(districts[i].Index, districts[i + 1].Index - districts[i].Index);
                districtValues.Add(newList);
            }
        }

        return districtValues;
    }
}