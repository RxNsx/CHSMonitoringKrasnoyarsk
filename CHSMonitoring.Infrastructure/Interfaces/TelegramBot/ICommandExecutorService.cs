using Telegram.Bot.Types;

namespace CHSMonitoring.Infrastructure.Interfaces.TelegramBot;

/// <summary>
/// Интерфейс сервиса обработки команд для телеграм бота
/// </summary>
public interface ICommandExecutorService
{
    Task Execute(Update update);
}