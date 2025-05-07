using MediatR;
using Telegram.Bot.Types;

namespace CHSMonitoring.Application.Commands.TelegramBot;

/// <summary>
/// Команда отправки сообщения Telegram
/// </summary>
/// <param name="update"></param>
public record TelegramBotCommand(Update Update) : IRequest
{
    
}