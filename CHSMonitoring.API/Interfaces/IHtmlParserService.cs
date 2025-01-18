using CHSMonitoring.API.Models;
using CHSMonitoring.API.Models.ServiceMessageAddress;
using HtmlAgilityPack;

namespace CHSMonitoring.API.Interfaces;

/// <summary>
/// Интерфейс для получения данных из Html документа
/// </summary>
public interface IHtmlParserService
{
    public Dictionary<string, List<ServiceMessage>> GetServiceMessages(HtmlDocument htmlDocument);
}