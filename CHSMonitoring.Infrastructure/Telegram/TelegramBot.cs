using Microsoft.Extensions.Configuration;
using Telegram.Bot;
using Telegram.Bot.Polling;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types.ReplyMarkups;

namespace CHSMonitoring.Infrastructure.Telegram;

/// <summary>
/// Класс предоставления телеграм бота
/// </summary>
public class TelegramBot
{
    private readonly IConfiguration _configuration;
    private TelegramBotClient _telegramBotClient;

    /// <summary>
    /// Конструктор
    /// </summary>
    /// <param name="configuration"></param>
    public TelegramBot(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public async Task<TelegramBotClient> GetTelegramBotClient()
    {
        if (_telegramBotClient is not null)
        {
            return _telegramBotClient;
        }
        
        
        var token = "8063336744:AAH3QCqJhfshuyvY-bYEHVWh87tB1TSjYFY";
        var telegramBot = new TelegramBotClient(token);

        telegramBot.OnUpdate += OnUpdate;
        telegramBot.OnMessage += OnMessage;
        telegramBot.Timeout = TimeSpan.FromSeconds(5);
        
        var xTunnelUrl = _configuration.GetSection("TelegramBot:XTunnelUrl").Value;
        var webHook = $"{xTunnelUrl}/api/telegrambot/update";
        await telegramBot.SetWebhook(webHook).ConfigureAwait(false);

        return telegramBot;
    }
    
    async Task OnUpdate(Update update)
    {
        if (update is { CallbackQuery: { } query }) // non-null CallbackQuery
        {
            await _telegramBotClient.AnswerCallbackQuery(query.Id, $"You picked {query.Data}");
            await _telegramBotClient.SendMessage(query.Message!.Chat, $"User {query.From} clicked on {query.Data}");
        }
    }
    
    async Task OnMessage(Message msg, UpdateType type)
    {
        if (msg.Text == "/start")
        {
            await _telegramBotClient.SendMessage(msg.Chat, "Welcome! Pick one direction",
                replyMarkup: new InlineKeyboardButton[] { "Left", "Right" });
        }
    }
}