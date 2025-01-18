using CHSMonitoring.API.Models.SupplyMessageDescription;
using CHSMonitoring.API.Models;
using HtmlAgilityPack;

namespace CHSMonitoring.API.Interfaces;

/// <summary>
/// Интерфейс для получения данных из Html документа
/// </summary>
public interface IHtmlParserService
{
    public Dictionary<string, List<SupplyMessageDescription>> GetSupplyMessageDescriptions(HtmlDocument htmlDocument);
}