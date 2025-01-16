using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using CHSMonitoringKrasnoyarsk.Interfaces;
using CHSMonitoringKrasnoyarsk.Models;
using HtmlAgilityPack;

namespace CHSMonitoringKrasnoyarsk.Workers;

/// <summary>
/// Воркер парсинга веб страницы 005 красноярск рф
/// </summary>
public class ChsParserWorker : BackgroundService
{
    private readonly ILogger<ChsParserWorker> _logger;
    private readonly IHttpClientService _httpClientService;
    private readonly IHtmlParserService _htmlParserService;

    private readonly string? _url;

    /// <summary>
    /// Конструктор
    /// </summary>
    /// <param name="loggerFactory"></param>
    /// <param name="httpClientService"></param>
    /// <param name="configuration"></param>
    /// <param name="htmlParserService"></param>
    public ChsParserWorker(ILoggerFactory loggerFactory, IHttpClientService httpClientService, IConfiguration configuration, IHtmlParserService htmlParserService)
    {
        _logger = loggerFactory.CreateLogger<ChsParserWorker>();
        
        _httpClientService = httpClientService;
        _htmlParserService = htmlParserService;
        
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
            try
            {
                var htmlDocument = await _httpClientService.GetHtmlDocumentByUrlAsync(_url, stoppingToken)
                    .ConfigureAwait(false);

                var districtsInfo = _htmlParserService.GetDistrictTableDescriptionsFromHtmlDocument(htmlDocument);
                if (!districtsInfo.Any())
                {
                    throw new ArgumentNullException("Пустой словарь");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

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