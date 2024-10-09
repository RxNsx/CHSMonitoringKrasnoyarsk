using CHSMonitoringKrasnoyarsk.Models;
using HtmlAgilityPack;

namespace CHSMonitoringKrasnoyarsk.Interfaces;

/// <summary>
/// Интерфейс для разбора данных из td элементов
/// </summary>
public interface ITdContentParserService
{
    /// <summary>
    /// Получить информацию по районам
    /// </summary>
    /// <param name="htmlDocument"></param>
    /// <returns></returns>
    public List<List<TableDescription>> GetDistrictTableDescriptionsFromHtmlDocument(HtmlDocument htmlDocument);
}