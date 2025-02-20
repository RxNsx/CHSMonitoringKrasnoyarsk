using CHSMonitoring.Infrastructure.Abstractions.Telegram;
using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;

namespace CHSMonitoring.Infrastructure.Telegram.Commands;

/// <summary>
/// Команда вывода ошибки
/// </summary>
public sealed class SendErrorInfoCommand : ErrorBaseCommand
{
    private readonly TelegramBotClient _telegramBotClient;

    /// <summary>
    /// Конструктор
    /// </summary>
    public SendErrorInfoCommand(Telegram.TelegramBot telegramBot)
    {
        _telegramBotClient = telegramBot.GetTelegramBotClient().Result;
    }

    public override string Name => CommandNames.SendErrorCommand;
    
    public override async Task ExecuteAsync(string errorMessage, Update update)
    {
        await _telegramBotClient.SendMessage(update.Message.Chat.Id, "Серверная ошибка, попробуйте еще раз", ParseMode.Markdown);
    }
    
}