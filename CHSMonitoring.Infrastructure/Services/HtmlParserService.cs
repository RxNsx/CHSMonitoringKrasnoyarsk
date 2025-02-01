using System.Collections.Immutable;
using CHSMonitoring.Domain.Entities;
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
    public List<ServiceAddress> GetServiceMessages(HtmlDocument htmlDocument)
    {
        var tdContents = htmlDocument.DocumentNode.SelectNodes("//td")
            .Where(td => td.InnerText != "&nbsp;" && td.InnerText != string.Empty)
            .Select((td, index) => new TableDescription
            {
                InnerText = td.InnerText,
                Index = index
            })
            .ToList();
            
        return _tdContentParserService.GetServiceMessages(tdContents);
    }
}