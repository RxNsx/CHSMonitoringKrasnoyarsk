using HtmlAgilityPack;

namespace CHSMonitoringKrasnoyarsk.Interfaces;

/// <summary>
/// Интерфейс управления http клиентом
/// </summary>
public interface IHttpClientService
{
    /// <summary>
    /// Получение html документа по url
    /// </summary>
    /// <param name="url"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public Task<HtmlDocument> GetHtmlDocumentByUrl(string url, CancellationToken cancellationToken);
}