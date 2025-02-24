using CHSMonitoring.Domain.Entities;

namespace CHSMonitoring.Infrastructure.Interfaces.TelegramBot;

/// <summary>
/// Интерфейс сервиса уведомлений для телеграма
/// </summary>
public interface ITelegramNotifyService
{
    /// <summary>
    /// Отправить уведомление пользователю
    /// </summary>
    /// <param name="message"></param>
    /// <param name="notifyUsers"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task SendNotifyMessageAsync(string message, List<User> notifyUsers, CancellationToken cancellationToken);
}