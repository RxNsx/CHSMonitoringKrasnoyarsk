using CHSMonitoring.Infrastructure.Extensions;
using CHSMonitoring.Infrastructure.Interfaces;
using CHSMonitoring.Infrastructure.Interfaces.Workers;
using HtmlAgilityPack;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace CHSMonitoring.Infrastructure.Workers;

public class GInfoWorker : BackgroundService
{
    private readonly IServiceScope _serviceScope;
    private readonly IStreetRepository _streetRepository;
    private readonly IStreetNameService _streetNameService;
    private readonly IHttpClientService _httpClientService;
    private readonly ILogger<GInfoWorker> _logger;
    private readonly string _url;
    
    /// <summary>
    /// Конструктор
    /// </summary>
    /// <param name="serviceScopeFactory"></param>
    /// <param name="loggerFactory"></param>
    public GInfoWorker(IServiceScopeFactory serviceScopeFactory, ILoggerFactory loggerFactory, IConfiguration configuration)
    {
        _serviceScope = serviceScopeFactory.CreateScope();
        _streetRepository = _serviceScope.ServiceProvider.GetRequiredService<IStreetRepository>();
        _streetNameService = _serviceScope.ServiceProvider.GetRequiredService<IStreetNameService>();
        _httpClientService = _serviceScope.ServiceProvider.GetRequiredService<IHttpClientService>();
        _logger = loggerFactory.CreateLogger<GInfoWorker>();
        _url = configuration.GetSection("GInfo:Url").Value;
    }
    
    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        await Task.Delay(TimeSpan.FromSeconds(5));

        var htmlDocument = await _httpClientService.GetGInfoHtmlDocumentByUrlAsync(_url, stoppingToken).ConfigureAwait(false);
        var links = htmlDocument.DocumentNode.SelectNodes("//a[@class='ulica_link']")
            .Select(x => new
            {
                Value = string.Concat("https://krasnoyarsk.ginfo.ru", x.Attributes["href"].Value)
            })
            .ToList();

        foreach (var link in links)
        {
            using var linkClient = new HttpClient();
            var streetTitleHouseNumbers = await linkClient.GetAsync(link.Value).ConfigureAwait(false);
            var houseNumbersContent = await streetTitleHouseNumbers.Content.ReadAsStringAsync().ConfigureAwait(false);
            var htmlDocumentHouseNumbers = new HtmlDocument();
            htmlDocumentHouseNumbers.LoadHtml(houseNumbersContent);

            var htmlStreetName = htmlDocumentHouseNumbers.DocumentNode.SelectSingleNode("//title")
                .InnerText
                .NormalizeActualDataText();
            var streetId = _streetNameService.GetStreetNameFromHtmlDocument(htmlStreetName);
            if (!streetId.HasValue || streetId.Value == Guid.Empty)
            {
                _logger.LogCritical($"Error, cannot get streetName from html street {htmlStreetName}");
            }
            _logger.LogInformation($"Success get streetName from html street {htmlStreetName}");

            var houseNumbersNodes = htmlDocumentHouseNumbers.DocumentNode.SelectNodes("//a[@class='dom_link']");
            if (houseNumbersNodes is not null)
            {
                //Перебираем все номера домов
                var innerTexts = houseNumbersNodes
                    .Select(x => x.InnerText)
                    .ToList();
                _logger.LogInformation($"Updating street house numbers {string.Join(",", innerTexts)}");
                await _streetRepository.UpdateStreetHouseNumbersAsync(streetId!.Value, innerTexts, stoppingToken).ConfigureAwait(false);
            }
            
            _logger.LogInformation("Reading data from GInfo...");
            await Task.Delay(TimeSpan.FromMilliseconds(1));
        }

        await Task.Delay(TimeSpan.FromHours(12), stoppingToken);
    }
}