using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;

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

    /// <summary>
    /// Обработка команд в виде сообщения
    /// </summary>
    /// <param name="update"></param>
    /// <returns></returns>
    Task HandleExecuteUpdateMessage(Update update);

    /// <summary>
    /// Обработка команд CallbackQuery
    /// </summary>
    /// <param name="update"></param>
    /// <returns></returns>
    Task HandleExecuteUpdateCallbackQuery(Update update);
}