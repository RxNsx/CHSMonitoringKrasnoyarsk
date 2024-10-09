using System.Net;
using System.Text;
using CHSMonitoringKrasnoyarsk.Interfaces;
using HtmlAgilityPack;

namespace CHSMonitoringKrasnoyarsk.Workers;

/// <summary>
/// Воркер парсинга веб страницы 005 красноярск рф
/// </summary>
public class ChsParserWorker : BackgroundService
{
    private readonly ILogger<ChsParserWorker> _logger;
    private readonly IHttpClientService _httpClientService;

    private readonly string? _url;

    /// <summary>
    /// Конструктор
    /// </summary>
    /// <param name="loggerFactory"></param>
    /// <param name="httpClientService"></param>
    /// <param name="configuration"></param>
    public ChsParserWorker(ILoggerFactory loggerFactory, IHttpClientService httpClientService, IConfiguration configuration)
    {
        _httpClientService = httpClientService;
        _logger = loggerFactory.CreateLogger<ChsParserWorker>();
        
        if(string.IsNullOrEmpty(configuration.GetSection("CHSMonitoringKrasnoyarsk:Url").Value))
        {
            _url = "http://93.92.65.26/aspx/GorodM.htm";
        }
        _url = configuration.GetSection("CHSMonitoringKrasnoyarsk:Url").Value;
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        while (!stoppingToken.IsCancellationRequested)
        {
            var htmlDocument = await _httpClientService.GetHtmlDocumentByUrl(_url, stoppingToken)
                .ConfigureAwait(false);
            
            var tdContents = htmlDocument.DocumentNode.SelectNodes("//td")
                .Where(td => td.InnerText != "&nbsp;" && td.InnerText != string.Empty)
                .Select((td, index) => new
                {
                    Value = td.InnerText,
                    Index = index
                })
                .ToList();
            
            var districts = tdContents
                .Where((x, index) => x.Value.Contains("район", StringComparison.OrdinalIgnoreCase))
                .ToList();
            
            tdContents.RemoveAll(x => x.Value.Contains("район", StringComparison.OrdinalIgnoreCase));
            await Task.Delay(5000, stoppingToken);
        }
    }
    
    public override Task StopAsync(CancellationToken stoppingToken)
    {
        _logger.LogInformation("Сервис парсинга остановлен: {time}", DateTimeOffset.Now);
        return base.StopAsync(stoppingToken);
    }

    public override void Dispose()
    {
        _logger.LogInformation("Сервис парсинга удален из памяти: {time}", DateTimeOffset.Now);
        base.Dispose();
    }
}