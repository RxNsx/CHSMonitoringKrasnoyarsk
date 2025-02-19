using CHSMonitoring.Infrastructure.Abstractions.Telegram;
using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;

namespace CHSMonitoring.Infrastructure.Telegram.Commands;

public sealed class ResentEmailAddressCommand : BaseCommand
{
    private readonly TelegramBotClient _telegramBotClient;

    /// <summary>
    /// Конструктор
    /// </summary>
    /// <param name="telegramBot"></param>
    public ResentEmailAddressCommand(Telegram.TelegramBot telegramBot)
    {
        _telegramBotClient = telegramBot.GetTelegramBotClient().Result;
    }

    public override string Name => CommandNames.ResentEmailAddress;
    public override async Task ExecuteAsync(Update update)
    {
        await _telegramBotClient
            .SendMessage(update.Message.Chat.Id, "Ошибка в почтовом адресе, попробуйте снова", ParseMode.Markdown)
            .ConfigureAwait(false);
    }
}