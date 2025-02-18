using Telegram.Bot.Types;

namespace CHSMonitoring.Infrastructure.Interfaces.TelegramBot;

/// <summary>
/// Интерфейс сервиса обработки команд для телеграм бота
/// </summary>
public interface ICommandExecutorService
{
    /// <summary>
    /// Выполнить команду
    /// </summary>
    /// <param name="update"></param>
    /// <returns></returns>
    Task Execute(Update update);
}