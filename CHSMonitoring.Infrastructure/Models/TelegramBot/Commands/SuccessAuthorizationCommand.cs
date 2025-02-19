using CHSMonitoring.Infrastructure.Models.TelegramBot.Abstractions;
using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;

namespace CHSMonitoring.Infrastructure.Models.TelegramBot.Commands;

public sealed class SuccessAuthorizationCommand : BaseCommand
{
    private readonly TelegramBotClient _telegramBotClient;

    /// <summary>
    /// Конструктор
    /// </summary>
    public SuccessAuthorizationCommand(Telegram.TelegramBot telegramBot)
    {
        _telegramBotClient = telegramBot.GetTelegramBotClient().Result;
    }

    public override string Name => CommandNames.SuccessAuthorization;
    public override async Task ExecuteAsync(Update update)
    {
        await _telegramBotClient.SendMessage(update.Message.Chat.Id, "Вы успешно авторизовались", ParseMode.Markdown)
            .ConfigureAwait(false); 
    }
}