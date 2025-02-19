using Telegram.Bot.Types;

namespace CHSMonitoring.Infrastructure.Models.TelegramBot.Abstractions;

/// <summary>
/// Базовая команда вывода ошибки
/// </summary>
public abstract class ErrorBaseCommand
{
    /// <summary>
    /// Название команды
    /// </summary>
    public abstract string Name { get; }
    
    /// <summary>
    /// Выполнение команды
    /// </summary>
    /// <param name="errorMessage"></param>
    /// <param name="update"></param>
    /// <returns></returns>
    public abstract Task ExecuteAsync(string errorMessage, Update update);
}