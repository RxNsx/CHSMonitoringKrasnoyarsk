using CHSMonitoring.Infrastructure.Abstractions.Telegram;
using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types.ReplyMarkups;

namespace CHSMonitoring.Infrastructure.Telegram.Commands;

/// <summary>
/// Отобразить пользователю выбор временных интервалов для уведомлений по подписке
/// </summary>
public class ShowUserTimeIntervalRefreshCommand : BaseCommand
{
    private TelegramBotClient _telegramBotClient;

    /// <summary>
    /// Конструктор
    /// </summary>
    /// <param name="telegramBot"></param>
    public ShowUserTimeIntervalRefreshCommand(TelegramBot telegramBot)
    {
        _telegramBotClient = telegramBot.GetTelegramBotClient().Result;
    }
    
    public override string Name => CommandNames.ShowUserTimeIntervalRefresh;
    public override async Task ExecuteAsync(Update update)
    {
        var inlineKeyboard = new InlineKeyboardMarkup(new[]
        {
            new[]
            {
                InlineKeyboardButton.WithCallbackData("Никогда", $"{(int)RefreshInterval.Off}-refresh-interval"),
            },
            new[]
            {
                InlineKeyboardButton.WithCallbackData("Раз в 15 минут", $"{(int)RefreshInterval.QuarterHour}-refresh-interval")
            },
            new[]
            {
                InlineKeyboardButton.WithCallbackData("Раз в 30 минут", $"{(int)RefreshInterval.HalfHour}-refresh-interval")
            },
            new[]
            {
                InlineKeyboardButton.WithCallbackData("Раз в 1 час", $"{(int)RefreshInterval.Hour}-refresh-interval")
            }
        });

        await _telegramBotClient.SendMessage(update.CallbackQuery.Message.Chat.Id, "Выберите интервал уведомлений по текущим отключениям", ParseMode.Markdown, replyMarkup: inlineKeyboard);
    }
}