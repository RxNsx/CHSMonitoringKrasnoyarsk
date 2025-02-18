using CHSMonitoring.Infrastructure.Interfaces;
using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types.ReplyMarkups;

namespace CHSMonitoring.Infrastructure.Models.TelegramBot.Commands;

/// <summary>
/// Стартовая команда
/// </summary>
public class StartCommand : BaseCommand
{
    private readonly TelegramBotClient _telegramBotClient;

    /// <summary>
    /// Конструктор
    /// </summary>
    /// <param name="telegramBot"></param>
    public StartCommand(Telegram.TelegramBot telegramBot)
    {
        _telegramBotClient = telegramBot.GetTelegramBotClient().Result;
    }

    /// <summary>
    /// Имя команды
    /// </summary>
    public override string Name => CommandNames.StartCommand;

    public override async Task ExecuteAsync(Update update)
    {

        var inlineKeyboard = new InlineKeyboardMarkup(new[]
        {
            new[]
            {
                InlineKeyboardButton.WithCallbackData("Авторизоваться", "start_authorize_process"),
            }
        });

        await _telegramBotClient.SendMessage(update.Message!.Chat, "Добро пожаловать в чат бот 005МониторингКрасноярск.рф", ParseMode.Markdown, replyMarkup: inlineKeyboard);
    }
}