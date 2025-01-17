using CHSMonitoringKrasnoyarsk.Models;
using CHSMonitoringKrasnoyarsk.Models.SupplyMessageDescription;
using HtmlAgilityPack;

namespace CHSMonitoringKrasnoyarsk.Interfaces;

/// <summary>
/// Интерфейс для получения данных из Html документа
/// </summary>
public interface IHtmlParserService
{
    public Dictionary<string, List<SupplyMessageDescription>> GetDistrictTableDescriptionsFromHtmlDocument(HtmlDocument htmlDocument);
}