using CHSMonitoring.Infrastructure.Interfaces.Workers;
using CHSMonitoring.Infrastructure.Models;
using CHSMonitoring.Infrastructure.Models.ServiceMessageAddress;
using HtmlAgilityPack;

namespace CHSMonitoring.Infrastructure.Services;

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
    /// Получение данных из Html документа в виде моделей 
    /// </summary>
    /// <param name="htmlDocument"></param>
    /// <returns></returns>
    public Dictionary<string, List<ServiceMessage>> GetServiceMessages(HtmlDocument htmlDocument)
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
        var supplyMessageDescriptionDict  = _tdContentParserService.GetServiceMessages(eventsDictionary);
        
        return supplyMessageDescriptionDict;
    }
}