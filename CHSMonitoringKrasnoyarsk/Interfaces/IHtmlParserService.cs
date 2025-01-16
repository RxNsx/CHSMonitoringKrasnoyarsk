using CHSMonitoringKrasnoyarsk.Models;
using HtmlAgilityPack;

namespace CHSMonitoringKrasnoyarsk.Interfaces;

/// <summary>
/// Интерфейс для получения данных из Html документа
/// </summary>
public interface IHtmlParserService
{
    public Dictionary<string, List<TableDescription>> GetDistrictTableDescriptionsFromHtmlDocument(HtmlDocument htmlDocument);
}