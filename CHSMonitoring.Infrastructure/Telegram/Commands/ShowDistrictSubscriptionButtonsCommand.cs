using CHSMonitoring.Infrastructure.Abstractions.Telegram;
using CHSMonitoring.Infrastructure.Extensions;
using CHSMonitoring.Infrastructure.Models.Enums;
using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types.ReplyMarkups;

namespace CHSMonitoring.Infrastructure.Telegram.Commands;

public class ShowDistrictSubscriptionButtonsCommand : BaseCommand
{
    private TelegramBotClient _telegramBotClient;

    /// <summary>
    /// Конструктор
    /// </summary>
    public ShowDistrictSubscriptionButtonsCommand(TelegramBot telegramBot)
    {
        _telegramBotClient = telegramBot.GetTelegramBotClient().Result;
    }
    
    public override string Name => CommandNames.ShowDistrictButtonsSubscription;
    
    public override async Task ExecuteAsync(Update update)
    {
        var inlineKeyboard = new InlineKeyboardMarkup(Enum.GetValues(typeof(DistrictEnum))
            .Cast<DistrictEnum>()
            .Select(x => new[] { InlineKeyboardButton.WithCallbackData($"{x.GetDescriptionValue()}", $"{(int)x}-district-subscribe") })
            .ToArray());

        await _telegramBotClient.SendMessage(update.CallbackQuery.Message.Chat.Id, "Выберите район для подписки на уведомления", 
                ParseMode.Markdown, replyMarkup: inlineKeyboard)
            .ConfigureAwait(false);
    }
}