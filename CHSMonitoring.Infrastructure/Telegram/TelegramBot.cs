using CHSMonitoring.Infrastructure.Settings;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Telegram.Bot;

namespace CHSMonitoring.Infrastructure.Telegram;

/// <summary>
/// Класс предоставления телеграм бота
/// </summary>
public class TelegramBot
{
    private readonly TelegramBotSettings _telegramBotSettings;
    private readonly TelegramBotClient _telegramBotClient;

    /// <summary>
    /// Конструктор
    /// </summary>
    public TelegramBot(IServiceScopeFactory serviceScopeFactory)
    {
        var scope = serviceScopeFactory.CreateScope();
        _telegramBotSettings = scope.ServiceProvider.GetRequiredService<IOptionsSnapshot<TelegramBotSettings>>().Value
            ?? throw new ArgumentNullException("Telegram bot settings must be not null");
    }

    /// <summary>
    /// Получить телеграм бота
    /// </summary>
    /// <returns></returns>
    public async Task<TelegramBotClient> GetTelegramBotClient()
    {
        if (_telegramBotClient is not null)
        {
            return _telegramBotClient;
        }
        
        var token = "8063336744:AAH3QCqJhfshuyvY-bYEHVWh87tB1TSjYFY";
        var telegramBot = new TelegramBotClient(token);

        telegramBot.Timeout = TimeSpan.FromSeconds(5);

        var tunnelUrl = _telegramBotSettings.TunnelUrl;
        var webHook = $"{tunnelUrl}/api/telegrambot/update";
        await telegramBot.SetWebhook(webHook).ConfigureAwait(false);

        return telegramBot;
    }
}