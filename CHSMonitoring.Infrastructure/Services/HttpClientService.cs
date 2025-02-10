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

    public async Task<HtmlDocument> GetChsHtmlDocumentByUrlAsync(string url, CancellationToken stoppingToken)
    {
        var reply = await _httpClient.GetByteArrayAsync("http://93.92.65.26/aspx/GorodM.htm", stoppingToken)
            .ConfigureAwait(false);

        Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
        var encoding1251 = Encoding.GetEncoding("windows-1251");
            
        var convertedBytes = Encoding.Convert(encoding1251, Encoding.UTF8, reply);
        var result = Encoding.UTF8.GetString(convertedBytes);
        var htmlDocument = new HtmlDocument();
        htmlDocument.LoadHtml(result);


        var count = htmlDocument.DocumentNode.SelectNodes("//td")
            .Where(td => td.InnerText != "&nbsp;" && td.InnerText != string.Empty)
            .Count();


        if (count > 50)
        {
            await HtmlTestBackupsSave(result).ConfigureAwait(false);
        }

        return htmlDocument;
    }

    public async Task<HtmlDocument> GetGInfoHtmlDocumentByUrlAsync(string url, CancellationToken stoppingToken)
    {
        using var client = new HttpClient();
        var response = await client.GetAsync(url).ConfigureAwait(false);
        var responseContent = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

        var htmlDocument = new HtmlDocument();
        htmlDocument.LoadHtml(responseContent);
        return htmlDocument;
    }

    /// <summary>
    /// Сохранить хороший вариант html страницы для последующего парсинга и анализа
    /// </summary>
    /// <param name="htmlString"></param>
    private async Task HtmlTestBackupsSave(string htmlString)
    {
        var currentDate = DateTime.UtcNow;
        var dateString = currentDate.ToShortDateString().Replace(".", string.Empty);
        var timeString = currentDate.ToShortTimeString().Replace(":", string.Empty);
        
        //Кодировка для кириллицы
        var encoding = Encoding.GetEncoding("windows-1251");
        await File.WriteAllBytesAsync($"E:\\Учёба 5 курс\\Diplom\\Files\\chsmonitoring_testcase_{dateString}_{timeString}.html", encoding.GetBytes(htmlString)).ConfigureAwait(false);
    }
}