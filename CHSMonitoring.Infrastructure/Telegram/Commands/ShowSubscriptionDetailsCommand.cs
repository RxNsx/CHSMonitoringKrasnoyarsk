using System.Text;
using CHSMonitoring.Domain.Enums;
using CHSMonitoring.Infrastructure.Abstractions.Telegram;
using CHSMonitoring.Infrastructure.Common;
using CHSMonitoring.Infrastructure.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types.ReplyMarkups;

namespace CHSMonitoring.Infrastructure.Telegram.Commands;

/// <summary>
/// Отправка сообщения с информацией по подписке
/// </summary>
public class ShowSubscriptionDetailsCommand : BaseCommand
{
    private readonly TelegramBotClient _telegramBotClient;
    private readonly ISubscriptionRepository _subscriptionRepository;

    /// <summary>
    /// Конструктор
    /// </summary>
    public ShowSubscriptionDetailsCommand(TelegramBot telegramBot, IServiceScopeFactory serviceScopeFactory)
    {
        _telegramBotClient = telegramBot.GetTelegramBotClient().Result;
        var scope = serviceScopeFactory.CreateScope();
        _subscriptionRepository = scope.ServiceProvider.GetRequiredService<ISubscriptionRepository>();
    }
    
    public override string Name => CommandNames.ShowSubscriptionDetailsCommand;
    public override async Task ExecuteAsync(Update update)
    {
        var chatId = long.MinValue;
        var userId = long.MinValue;
        switch (update.Type)
        {
            case UpdateType.Message:
                chatId = update.Message.Chat.Id;
                userId = update.Message.From.Id;
                break;
            case UpdateType.CallbackQuery:
                chatId = update.CallbackQuery.Message.Chat.Id;
                userId = update.CallbackQuery.From.Id;
                break;
        }
        
        var subscription = await _subscriptionRepository.GetSubscriptionAsync(userId, ProfileTypeEnum.Telegram, default)
            .ConfigureAwait(false);

        var sb = new StringBuilder();
        var districtName = CommonData.DistrictsData
            .FirstOrDefault(x => x.Id == subscription.DistrictId)
            .DistrictName;
        
        sb.Append("Ваша подписка:").AppendLine();
        sb.Append("Район: ").Append(districtName).AppendLine();
        sb.Append("Период уведомления: ").Append(subscription!.UpdateUserTime == 0 ? "Никогда" :$"Каждые {subscription!.UpdateUserTime}").Append(" минут").AppendLine();

        var inlineKeyboard = new InlineKeyboardMarkup(new[]
        {
            new[]
            {
                InlineKeyboardButton.WithCallbackData("Изменить", CommandNames.ChangeSubscription),
            }
        });
        
        
        await _telegramBotClient.SendMessage(chatId, sb.ToString(), ParseMode.Markdown, replyMarkup: inlineKeyboard).ConfigureAwait(false);
    }
}