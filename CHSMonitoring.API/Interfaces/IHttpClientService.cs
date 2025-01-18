using HtmlAgilityPack;

namespace CHSMonitoring.API.Interfaces;

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
    public Task<HtmlDocument> GetHtmlDocumentByUrlAsync(string url, CancellationToken cancellationToken);
}