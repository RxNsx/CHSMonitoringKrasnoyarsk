using CHSMonitoring.Infrastructure.Abstractions.Telegram;
using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;

namespace CHSMonitoring.Infrastructure.Telegram.Commands;

/// <summary>
/// Команда авторизации
/// </summary>
public sealed class SetEmailAddressCommand : BaseCommand
{
    private readonly TelegramBotClient _telegramBotClient;

    /// <summary>
    /// Конструктор
    /// </summary>
    public SetEmailAddressCommand(Telegram.TelegramBot telegramBot)
    {
        _telegramBotClient = telegramBot.GetTelegramBotClient().Result;
    }

    public override string Name => CommandNames.SetEmailAddressCommand;
    
    public override async Task ExecuteAsync(Update update)
    {
        await _telegramBotClient.SendMessage(update.Message!.Chat.Id, "Введите адрес электронной почты", ParseMode.Markdown);
    }
}