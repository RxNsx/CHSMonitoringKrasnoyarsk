﻿using System.Diagnostics;
using CHSMonitoring.Infrastructure.Context;
using CHSMonitoring.Infrastructure.Interfaces;
using CHSMonitoring.Infrastructure.Interfaces.Workers;
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

    
    private MonitoringDbContext _context;
    private IServiceAddressRepository _serviceAddressRepository;
    
    /// <summary>
    /// Конструктор
    /// </summary>
    /// <param name="loggerFactory"></param>
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
        _context = scope.ServiceProvider.GetRequiredService<MonitoringDbContext>();
        _serviceAddressRepository = scope.ServiceProvider.GetRequiredService<IServiceAddressRepository>();
        
        while (!stoppingToken.IsCancellationRequested)
        {
            await Task.Delay(TimeSpan.FromSeconds(5), stoppingToken);

            var stopwatch = Stopwatch.StartNew();
            
            try
            {
                var htmlDocument = await _httpClientService.GetHtmlDocumentByUrlAsync(_url, stoppingToken)
                    .ConfigureAwait(false);

                var supplyMessageDescriptions = _htmlParserService.GetServiceMessages(htmlDocument);
                if (!supplyMessageDescriptions.Any())
                {
                    throw new ArgumentNullException("Пустой словарь");
                }
                
                //TODO: Добавить в каждую запись значение района
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