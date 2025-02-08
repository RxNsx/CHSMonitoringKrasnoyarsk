using HtmlAgilityPack;

namespace CHSMonitoring.Infrastructure.Interfaces.Workers;

/// <summary>
/// Интерфейс управления http клиентом
/// </summary>
public interface IHttpClientService
{
    /// <summary>
    /// Получение html документа по url c сайта 005красноярск.рф
    /// </summary>
    /// <param name="url"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<HtmlDocument> GetChsHtmlDocumentByUrlAsync(string url, CancellationToken cancellationToken);

    /// <summary>
    /// Получить html документа по url с сайта ginfo
    /// </summary>
    /// <param name="url"></param>
    /// <param name="stoppingToken"></param>
    /// <returns></returns>
    Task<HtmlDocument> GetGInfoHtmlDocumentByUrlAsync(string url, CancellationToken stoppingToken);
}