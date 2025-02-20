using CHSMonitoring.Infrastructure.Abstractions.Telegram;
using CHSMonitoring.Infrastructure.Extensions;
using CHSMonitoring.Infrastructure.Models.Enums;
using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types.ReplyMarkups;

namespace CHSMonitoring.Infrastructure.Telegram.Commands;

/// <summary>
/// Команда отображающая клавиатуру выбора района для отображения
/// </summary>
public sealed class ShowDistrictButtonCommand : BaseCommand
{
    private TelegramBotClient _telegramBotClient;

    /// <summary>
    /// Конструктор
    /// </summary>
    public ShowDistrictButtonCommand(Telegram.TelegramBot telegramBot)
    {
        _telegramBotClient = telegramBot.GetTelegramBotClient().Result;
    }
    
    public override string Name => CommandNames.ShowDistrictButtons;
    public override async Task ExecuteAsync(Update update)
    {
        var inlineKeyboard = new InlineKeyboardMarkup(Enum.GetValues(typeof(DistrictEnum))
            .Cast<DistrictEnum>()
            .Select(x => new[] { InlineKeyboardButton.WithCallbackData($"{x.GetDescriptionValue()}", $"{x.ToString().ToLower()}-district") })
            .Append(new [] { InlineKeyboardButton.WithCallbackData("Все районы", "all-district") })
            .ToArray());

        await _telegramBotClient.SendMessage(update.Message.Chat.Id, "Выберите район чтобы узнать текущие отключения", 
                ParseMode.Markdown, replyMarkup: inlineKeyboard)
            .ConfigureAwait(false);
    }
}