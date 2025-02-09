using System.Diagnostics;
using CHSMonitoring.Domain.Entities;
using CHSMonitoring.Infrastructure.Context;
using CHSMonitoring.Infrastructure.Extensions;
using CHSMonitoring.Infrastructure.Interfaces;
using CHSMonitoring.Infrastructure.Interfaces.Workers;
using CHSMonitoring.Infrastructure.Models.Enums;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace CHSMonitoring.Infrastructure.Workers;

/// <summary>
/// Воркер парсинга веб страницы 005 красноярск рф
/// </summary>
public class ServiceMessageWorker : BackgroundService
{
    private readonly ILogger<ServiceMessageWorker> _logger;
    private readonly IHttpClientService _httpClientService;
    private readonly IHtmlParserService _htmlParserService;
    private readonly IServiceScopeFactory _serviceScopeFactory;

    private readonly string? _url;
    private IServiceAddressRepository _serviceAddressRepository;

    /// <summary>
    /// Конструктор
    /// </summary>
    /// <param name="loggerFactory"></param>
    /// <param name="serviceScopeFactory"></param>
    /// <param name="httpClientService"></param>
    /// <param name="configuration"></param>
    /// <param name="htmlParserService"></param>
    public ServiceMessageWorker(ILoggerFactory loggerFactory, IServiceScopeFactory serviceScopeFactory, IHttpClientService httpClientService, IConfiguration configuration, IHtmlParserService htmlParserService)
    {
        _logger = loggerFactory.CreateLogger<ServiceMessageWorker>();
        _serviceScopeFactory = serviceScopeFactory;
        _httpClientService = httpClientService;
        _htmlParserService = htmlParserService;
        
        if(string.IsNullOrEmpty(configuration.GetSection("CHSMonitoring.API:Url").Value))
        {
            _url = "http://93.92.65.26/aspx/GorodM.htm";
        }
        _url = configuration.GetSection("CHSMonitoring.API:Url").Value;
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        var scope = _serviceScopeFactory.CreateScope();
        _serviceAddressRepository = scope.ServiceProvider.GetRequiredService<IServiceAddressRepository>();
        
        while (!stoppingToken.IsCancellationRequested)
        {
            await Task.Delay(TimeSpan.FromSeconds(5), stoppingToken);

            var stopwatch = Stopwatch.StartNew();
            
            try
            {
                var htmlDocument = await _httpClientService.GetChsHtmlDocumentByUrlAsync(_url, stoppingToken)
                    .ConfigureAwait(false);

                var serviceAddresses = await _htmlParserService.GetServiceMessages(htmlDocument).ConfigureAwait(false);
                await _serviceAddressRepository.AddServiceAddressesAsync(serviceAddresses, stoppingToken);

                CheckMissedAddreses(serviceAddresses);
                Console.WriteLine("Total seconds elapsed: " + stopwatch.Elapsed.Seconds);
                stopwatch.Stop();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            await Task.Delay(TimeSpan.FromSeconds(15), stoppingToken);
        }
    }

    private void CheckMissedAddreses(List<ServiceAddress> serviceAddresses)
    {
        var streetEnums = Enum.GetValues(typeof(StreetNameEnum))
            .Cast<StreetNameEnum>()
            .Select(x => new
            {
                Id = x.GetGuidValue(),
                Name = x.GetDescriptionValue(),
            })
            .ToList();
        var exceptList = serviceAddresses
            .Where(x => !streetEnums.Any(t => t.Name.Equals(x.StreetName, StringComparison.InvariantCultureIgnoreCase)))
            .ToList();
        if (exceptList.Any())
        {
            _logger.LogCritical($"Отсутсвующие адреса: {string.Join(", ", exceptList.Select(x => x.StreetName))}");
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