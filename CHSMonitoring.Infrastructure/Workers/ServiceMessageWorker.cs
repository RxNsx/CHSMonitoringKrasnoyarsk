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

    private readonly string? _url;
    private readonly int _refreshIntervalMinutes;
    private readonly IServiceAddressRepository _serviceAddressRepository;

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
        var scope = serviceScopeFactory.CreateScope();
        _logger = loggerFactory.CreateLogger<ServiceMessageWorker>();
        _httpClientService = httpClientService;
        _htmlParserService = htmlParserService;
        _serviceAddressRepository = scope.ServiceProvider.GetRequiredService<IServiceAddressRepository>();
        
        if(!string.IsNullOrEmpty(configuration.GetSection("CHSMonitoringKrasnoyarsk:Url").Value))
        {
            _url = configuration.GetSection("CHSMonitoringKrasnoyarsk:Url").Value;
        }
        if (!string.IsNullOrEmpty(configuration.GetSection("CHSMonitoringKrasnoyarsk:IntervalParsingMinutes").Value))
        {
            _refreshIntervalMinutes = int.Parse(configuration.GetSection("CHSMonitoringKrasnoyarsk:IntervalParsingMinutes")!.Value!);
        }
    }
    
    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        while (!stoppingToken.IsCancellationRequested)
        {
            await Task.Delay(TimeSpan.FromSeconds(5), stoppingToken);
            var stopwatch = Stopwatch.StartNew();
            
            try
            {
                _logger.LogInformation($"Парсинг страницы {_url}");
                
                var htmlDocument = await _httpClientService.GetChsHtmlDocumentByUrlAsync(_url, stoppingToken)
                    .ConfigureAwait(false);
                var serviceAddresses = await _htmlParserService.GetServiceMessages(htmlDocument).ConfigureAwait(false);
                await _serviceAddressRepository.AddServiceAddressesAsync(serviceAddresses, stoppingToken);
                _logger.LogInformation($"Парсинг страницы {_url} завершен за {stopwatch.ElapsedMilliseconds} мс.");
                stopwatch.Stop();
            }
            catch (Exception ex)
            {
                _logger.LogCritical($"Ошибка в работе сервиса парсинга адресов с 005красноярск.рф: {ex.Message}");
            }
            
            await Task.Delay(TimeSpan.FromMinutes(_refreshIntervalMinutes), stoppingToken);
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