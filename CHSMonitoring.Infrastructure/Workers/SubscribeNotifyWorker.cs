using CHSMonitoring.Infrastructure.Interfaces;
using CHSMonitoring.Infrastructure.Interfaces.TelegramBot;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Telegram.Bot;

namespace CHSMonitoring.Infrastructure.Workers;

/// <summary>
/// Воркер уведомления пользователей
/// </summary>
public class SubscribeNotifyWorker : BackgroundService
{
    private readonly ILogger<SubscribeNotifyWorker> _logger;
    private ISubscriptionRepository _subscriptionRepository;
    private ITelegramNotifyService _telegramNotifyService;
    private readonly IServiceScopeFactory _serviceScopeFactory;

    /// <summary>
    /// Конструктор
    /// </summary>
    /// <param name="logger"></param>
    /// <param name="serviceScopeFactory"></param>
    public SubscribeNotifyWorker(ILogger<SubscribeNotifyWorker> logger, IServiceScopeFactory serviceScopeFactory)
    {
        _logger = logger;
        _serviceScopeFactory = serviceScopeFactory;
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        var scope = _serviceScopeFactory.CreateScope();
        _subscriptionRepository = scope.ServiceProvider.GetRequiredService<ISubscriptionRepository>();
        _telegramNotifyService = scope.ServiceProvider.GetRequiredService<ITelegramNotifyService>();
        
        while (!stoppingToken.IsCancellationRequested)
        {
            try
            {
                var notifyUsers = await _subscriptionRepository.GetNotifyUsersAsync(stoppingToken);
                if (notifyUsers.Any())
                {
                    await _telegramNotifyService.SendNotifyMessageAsync("test", notifyUsers, stoppingToken).ConfigureAwait(false);
                }
            }
            catch (Exception ex)
            {
                _logger.LogCritical($"Ошибка в работе сервиса телеграм уведомлений: {ex.Message}");
            }
            
            await Task.Delay(TimeSpan.FromSeconds(1));
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