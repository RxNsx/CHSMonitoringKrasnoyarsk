using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;

namespace CHSMonitoring.Infrastructure.Models.TelegramBot.Commands;

/// <summary>
/// Команда установки имени
/// </summary>
public class SetUserNameCommand : BaseCommand
{
    private readonly TelegramBotClient _telegramBotClient;

    /// <summary>
    /// Конструктор
    /// </summary>
    /// <param name="telegramBotClient"></param>
    public SetUserNameCommand(Telegram.TelegramBot telegramBot)
    {
        _telegramBotClient = telegramBot.GetTelegramBotClient().Result;
    }

    public override string Name => CommandNames.SetUserNameCommand;
    public override async Task ExecuteAsync(Update update)
    {
        await _telegramBotClient.SendMessage(update.CallbackQuery.Message.Chat.Id, "Введите имя пользователя", ParseMode.Markdown)
            .ConfigureAwait(false);
    }
}