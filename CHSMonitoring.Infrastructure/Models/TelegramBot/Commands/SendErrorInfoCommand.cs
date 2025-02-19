using CHSMonitoring.Infrastructure.Models.TelegramBot.Abstractions;
using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;

namespace CHSMonitoring.Infrastructure.Models.TelegramBot.Commands;

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