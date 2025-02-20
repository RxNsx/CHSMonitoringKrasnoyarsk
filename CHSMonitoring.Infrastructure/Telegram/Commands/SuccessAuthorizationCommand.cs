using CHSMonitoring.Infrastructure.Abstractions.Telegram;
using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;

namespace CHSMonitoring.Infrastructure.Telegram.Commands;

/// <summary>
/// Команда успешной авторизации
/// </summary>
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