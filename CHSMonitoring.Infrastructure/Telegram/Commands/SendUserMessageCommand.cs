using CHSMonitoring.Infrastructure.Abstractions.Telegram;
using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;

namespace CHSMonitoring.Infrastructure.Telegram.Commands;

public class SendUserMessageCommand : SendMessageCommand
{
    private readonly TelegramBotClient _telegramBotClient;

    /// <summary>
    /// Конструктор
    /// </summary>
    public SendUserMessageCommand(TelegramBot telegramBot)
    {
        _telegramBotClient = telegramBot.GetTelegramBotClient().Result;
    }
    
    public override string Name => CommandNames.SendUserMessage;
    public override async Task ExecuteAsync(string textMessage, UpdateType updateType, Update update)
    {
        var chatId = long.MinValue;
        switch (updateType)
        {
            case UpdateType.Message:
                chatId = update.Message.Chat.Id;
                break;
            
            case UpdateType.CallbackQuery:
                chatId = update.CallbackQuery.Message.Chat.Id;
                break;
        }
        
        await _telegramBotClient.SendMessage(chatId, textMessage, ParseMode.Markdown);
    }
}