using System.Reflection;
using CHSMonitoring.Infrastructure.Extensions;
using CHSMonitoring.Infrastructure.Interfaces;
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
    private readonly ILogger<GInfoWorker> _logger;
    
    private readonly string _url;
    private readonly int _refreshIntervalHours;

    /// <summary>
    /// Конструктор
    /// </summary>
    /// <param name="serviceScopeFactory"></param>
    /// <param name="loggerFactory"></param>
    /// <param name="configuration"></param>
    public GInfoWorker(IServiceScopeFactory serviceScopeFactory, ILoggerFactory loggerFactory, IConfiguration configuration)
    {
        _serviceScope = serviceScopeFactory.CreateScope();
        _streetRepository = _serviceScope.ServiceProvider.GetRequiredService<IStreetRepository>();
        _streetNameService = _serviceScope.ServiceProvider.GetRequiredService<IStreetNameService>();
        _logger = loggerFactory.CreateLogger<GInfoWorker>();

        if (!string.IsNullOrEmpty(configuration.GetSection("GInfo:Url").Value))
        {
            _url = configuration.GetSection("GInfo:Url")!.Value!;
        }
        if (!string.IsNullOrEmpty(configuration.GetSection("GInfo:IntervalParsingMinutes").Value))
        {
            _refreshIntervalHours = int.Parse(configuration.GetSection("GInfo:Url")!.Value!);
        }
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        await Task.Delay(TimeSpan.FromSeconds(5));
        while (!stoppingToken.IsCancellationRequested)
        {
            try
            {
                using var client = new HttpClient();
                var response = await client.GetAsync(_url).ConfigureAwait(false);
                var responseContent = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                var htmlDocument = new HtmlDocument();
                htmlDocument.LoadHtml(responseContent);

                 var isCaptchaBlocked = htmlDocument.DocumentNode.OuterHtml.Contains("captcha");
                 if (!isCaptchaBlocked)
                 {
                     var path = Path.Combine(Path.Combine(Directory.GetParent(Assembly.GetExecutingAssembly().Location).FullName, "DataPresets", "streetsdata.txt"));
                     var streetLines = await File.ReadAllLinesAsync(path, stoppingToken).ConfigureAwait(false);
                     foreach (var streetLine in streetLines)
                     {
                         _logger.LogInformation(streetLine);
                         var values = streetLine.Split(";").ToList();
                         var streetName = values[0].Trim().NormalizeActualDataText();
                         var houseNumbers = values[1].Trim().Split(",").ToList();
                         var street = await _streetRepository.GetStreetAsync(streetName, stoppingToken).ConfigureAwait(false);
                         await _streetRepository.UpdateStreetHouseNumbersAsync(street.Id, houseNumbers, stoppingToken).ConfigureAwait(false);
                     }
                 }
                 else
                 {
                    var streetLinks = htmlDocument.DocumentNode.SelectNodes("//a[@class='ulica_link']")
                        .Select(x => new
                        {
                            Value = string.Concat("https://krasnoyarsk.ginfo.ru", x.Attributes["href"].Value)
                        })
                        .ToList();

                    foreach (var streetLink in streetLinks)
                    {
                        using var linkClient = new HttpClient();
                        var streetTitleHouseNumbers = await client.GetAsync(streetLink.Value).ConfigureAwait(false);
                        var houseNumbersContent =
                            await streetTitleHouseNumbers.Content.ReadAsStringAsync().ConfigureAwait(false);
                        var htmlDocumentHouseNumbers = new HtmlDocument();
                        htmlDocumentHouseNumbers.LoadHtml(houseNumbersContent);

                        var htmlStreetName = htmlDocumentHouseNumbers.DocumentNode.SelectSingleNode("//title")
                            .InnerText
                            .NormalizeActualDataText();
                        var streetId = _streetNameService.GetStreetNameFromHtmlDocument(htmlStreetName);
                        var houseNumbersNodes = htmlDocumentHouseNumbers.DocumentNode.SelectNodes("//a[@class='dom_link']");
                        if (houseNumbersNodes is not null)
                        {
                            //Перебираем все номера домов
                            var innerTexts = houseNumbersNodes
                                .Select(x => x.InnerText)
                                .ToList();
                            await _streetRepository
                                .UpdateStreetHouseNumbersAsync(streetId!.Value, innerTexts, stoppingToken)
                                .ConfigureAwait(false);
                        }

                        await Task.Delay(TimeSpan.FromMilliseconds(200));
                    }
                }

                _logger.LogInformation($"Информация со страницы {_url} обновлена");
                await Task.Delay(TimeSpan.FromHours(_refreshIntervalHours), stoppingToken);
            }
            catch (Exception ex)
            {
                _logger.LogCritical($"При парсинге информации со страницы {_url} возникла ошибка: {ex.Message}\n{ex.StackTrace}");
            }
        }



    }
}