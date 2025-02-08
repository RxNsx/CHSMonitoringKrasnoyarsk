using System.Diagnostics.CodeAnalysis;
using System.Reflection.Metadata;
using System.Text;
using CHSMonitoring.Infrastructure.Common;
using CHSMonitoring.Infrastructure.Context;
using CHSMonitoring.Infrastructure.Extensions;
using CHSMonitoring.Infrastructure.Interfaces;
using CHSMonitoring.Infrastructure.Models.Enums;
using HtmlAgilityPack;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace CHSMonitoring.Infrastructure.Workers;

public class ActualDataWorker : BackgroundService
{
    private readonly IServiceScope _serviceScope;
    private readonly IStreetRepository _streetRepository;
    private readonly IStreetNameService _streetNameService;
    private readonly ILogger<ActualDataWorker> _logger;
    
    public ActualDataWorker(IServiceScopeFactory serviceScopeFactory, ILoggerFactory loggerFactory)
    {
        _serviceScope = serviceScopeFactory.CreateScope();
        _streetRepository = _serviceScope.ServiceProvider.GetRequiredService<IStreetRepository>();
        _streetNameService = _serviceScope.ServiceProvider.GetRequiredService<IStreetNameService>();
        _logger = loggerFactory.CreateLogger<ActualDataWorker>();
    }
    
    [SuppressMessage("ReSharper.DPA", "DPA0006: Large number of DB commands", MessageId = "count: 791")]
    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        await Task.Delay(TimeSpan.FromSeconds(5));
        
        var url = "https://krasnoyarsk.ginfo.ru/ulicy/";
        using var client = new HttpClient();
        var response = await client.GetAsync(url).ConfigureAwait(false);
        var responseContent = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

        var htmlDocument = new HtmlDocument();
        htmlDocument.LoadHtml(responseContent);
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
            
            Console.WriteLine("Reading data...");
            await Task.Delay(TimeSpan.FromMilliseconds(250));
        }

        await Task.Delay(TimeSpan.FromSeconds(15));
    }
}