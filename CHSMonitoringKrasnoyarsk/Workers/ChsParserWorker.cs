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
    private readonly ITdContentParserService _tdContentParserService;

    private readonly string? _url;

    /// <summary>
    /// Конструктор
    /// </summary>
    /// <param name="loggerFactory"></param>
    /// <param name="httpClientService"></param>
    /// <param name="configuration"></param>
    /// <param name="tdContentParserService"></param>
    public ChsParserWorker(ILoggerFactory loggerFactory, IHttpClientService httpClientService, IConfiguration configuration, ITdContentParserService tdContentParserService)
    {
        _logger = loggerFactory.CreateLogger<ChsParserWorker>();
        
        _httpClientService = httpClientService;
        _tdContentParserService = tdContentParserService;
        
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

                var districtsInfo = _tdContentParserService.GetDistrictTableDescriptionsFromHtmlDocument(htmlDocument);
                if (!districtsInfo.Any())
                {
                    throw new ArgumentNullException("Пустой словарь");
                }


                var text1 = districtsInfo.FirstOrDefault().Value[1].InnerText;
                var text2 = districtsInfo.FirstOrDefault().Value[4].InnerText;

                List<string> strings = new();
                // strings.Add(text1);
                // strings.Add(text2);
                // strings.Add("Ладо Кецховели 29, 31, 33 (д/сад), 35, 39; Красной Армии 121; Волочаевская 44; Корнеева 24а, 26; Советская 41в (диспансер), 41е; Ленина 221а;пониженные параметры - переврезка обратного тубопровода на временный трубопровод");
                strings.Add("Дозорная; Национальная; Ореховская; Шушенская; Пировская; Лесосибирский; Бийхемская; Назаровская; Тюхтетский; Артемовская; Каратузский; Курейская; Красногорская; 2-я Красногорская; Бугачевская; Геологическая; 2-я Геологическая; Калинина 159-181, 98-106; Куренная; Острожная;\nплановое - регулировка стрелы провеса фидер 121-18");
                strings.Add("Прогулочная; Горная; Вольный проезд; 1-й Волный проезд; Садовая; Зеленая;\nплановое - установка автомата комплектная трансформаторная подстанция 3274");
                strings.Add("");
                
                foreach (string str in strings)
                {
                    string output = Regex.Replace(str, @"\([^)]*\)\s*", "");
                    output  = Regex.Replace(output, @"\s+", " ");
                    output = Regex.Replace(output, @"(\d+[а-яА-Я]*)\s*", m => m.Groups[1].Value);
                    
                    string[] addresses = Regex.Split(output, ";")
                        .Select(m => Regex.Replace(m, @"\s+", " "))
                        .Select(m => Regex.Replace(m, @"(\d+[а-яА-Я]*)\s*", m => m.Groups[1].Value))
                        .Where(m => !string.IsNullOrEmpty(m))
                        .ToArray();

                    foreach (string address in addresses)
                    {
                        Console.WriteLine(address);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
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
    
    public class Address
    {
        public string StreetName { get; set; }
        public List<string> HouseNumbers { get; set; }
        public string AdditionalInfo { get; set; }
    }
    
}