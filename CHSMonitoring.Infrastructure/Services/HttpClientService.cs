using System.Text;
using CHSMonitoring.Infrastructure.Interfaces.Workers;
using HtmlAgilityPack;

namespace CHSMonitoring.Infrastructure.Services;

public class HttpClientService : IHttpClientService
{
    private readonly HttpClient _httpClient;

    /// <summary>
    /// Конструктор
    /// </summary>
    /// <param name="httpClientFactory"></param>
    public HttpClientService(IHttpClientFactory httpClientFactory)
    {
        _httpClient = httpClientFactory.CreateClient("client");
    }

    public async Task<HtmlDocument> GetHtmlDocumentByUrlAsync(string url, CancellationToken stoppingToken)
    {
        var reply = await _httpClient.GetByteArrayAsync("http://93.92.65.26/aspx/GorodM.htm", stoppingToken)
            .ConfigureAwait(false);

        Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
        var encoding1251 = Encoding.GetEncoding("windows-1251");
            
        var convertedBytes = Encoding.Convert(encoding1251, Encoding.UTF8, reply);
        var result = Encoding.UTF8.GetString(convertedBytes);
        var htmlDocument = new HtmlDocument();
        htmlDocument.LoadHtml(result);

        return htmlDocument;
    }
}