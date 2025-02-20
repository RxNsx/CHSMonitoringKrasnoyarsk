using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;

namespace CHSMonitoring.Infrastructure.Abstractions.Telegram;

/// <summary>
/// Базовая команда отправки сообщения
/// </summary>
public abstract class SendMessageCommand
{
    /// <summary>
    /// Название команды
    /// </summary>
    public abstract string Name { get; }

    /// <summary>
    /// Отправка команды
    /// </summary>
    /// <param name="textMessage"></param>
    /// <param name="updateType"></param>
    /// <param name="update"></param>
    /// <returns></returns>
    public abstract Task ExecuteAsync(string textMessage, UpdateType updateType, Update update);
}