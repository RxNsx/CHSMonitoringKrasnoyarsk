using CHSMonitoring.Infrastructure.Models.TelegramBot.Abstractions;
using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;

namespace CHSMonitoring.Infrastructure.Models.TelegramBot.Commands;

public sealed class UserEmailAlreadyExistsCommand : BaseCommand
{
    private TelegramBotClient _telegramBotClient;

    /// <summary>
    /// Конструктор
    /// </summary>
    public UserEmailAlreadyExistsCommand(Telegram.TelegramBot telegramBot)
    {
        _telegramBotClient = telegramBot.GetTelegramBotClient().Result;
    }

    public override string Name => CommandNames.UserEmailAlreadyExists;
    public override async Task ExecuteAsync(Update update)
    {
        await _telegramBotClient.SendMessage(update.Message.Chat.Id, "Пользователь с таким адресом электронной почты уже зарегистрирован. Введите другой адрес", ParseMode.Markdown);
    }
}