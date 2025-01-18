using CHSMonitoring.API.Interfaces;
using CHSMonitoring.API.Models;
using CHSMonitoring.API.Models.SupplyMessageDescription;
using HtmlAgilityPack;

namespace CHSMonitoring.API.Services;

/// <summary>
/// Сервис для получения данных из Html документа
/// </summary>
public class HtmlParserService : IHtmlParserService
{
    private readonly ITdContentParserService _tdContentParserService;

    /// <summary>
    /// Конструктор
    /// </summary>
    /// <param name="tdContentParserService"></param>
    public HtmlParserService(ITdContentParserService tdContentParserService)
    {
        _tdContentParserService = tdContentParserService;
    }

    /// <summary>
    /// Получение данных из Html документа
    /// </summary>
    /// <param name="htmlDocument"></param>
    /// <returns></returns>
    public Dictionary<string, List<SupplyMessageDescription>> GetDistrictTableDescriptionsFromHtmlDocument(HtmlDocument htmlDocument)
    {
        var tdContents = htmlDocument.DocumentNode.SelectNodes("//td")
            .Where(td => td.InnerText != "&nbsp;" && td.InnerText != string.Empty)
            .Select((td, index) => new TableDescription
            {
                InnerText = td.InnerText,
                Index = index
            })
            .ToList();
            
        var districtValues = _tdContentParserService.GetDistrictsDataFromTableDescriptions(tdContents);
        var eventsDictionary = _tdContentParserService.RestrictionTableDescriptionToDict(districtValues);
        var supplyMessageDescriptionDict  = _tdContentParserService.GetSupplyAlarmDescriptions(eventsDictionary);
        
        return supplyMessageDescriptionDict;
    }
}