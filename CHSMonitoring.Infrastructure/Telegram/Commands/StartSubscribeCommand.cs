using CHSMonitoring.Infrastructure.Abstractions.Telegram;
using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types.ReplyMarkups;

namespace CHSMonitoring.Infrastructure.Telegram.Commands;

/// <summary>
/// Команда запуска процесса активации подписки
/// </summary>
public class StartSubscribeCommand : BaseCommand
{
    private readonly TelegramBotClient _telegramBotClient;

    /// <summary>
    /// Конструктор
    /// </summary>
    public StartSubscribeCommand(TelegramBot telegramBot)
    {
        _telegramBotClient = telegramBot.GetTelegramBotClient().Result;
    }
    
    public override string Name => CommandNames.StartSubscribeProcess;
    public override async Task ExecuteAsync(Update update)
    {
        var inlineKeyboard = new InlineKeyboardMarkup(new[]
        {
            new[]
            {
                InlineKeyboardButton.WithCallbackData("Настроить подписку на оповещение", CommandNames.StartSubscribeProcess), 
            }
        });

        await _telegramBotClient.SendMessage(update.Message.Chat.Id, "Подписка на уведомления не настроена", ParseMode.Markdown, replyMarkup: inlineKeyboard).ConfigureAwait(false);
    }
}