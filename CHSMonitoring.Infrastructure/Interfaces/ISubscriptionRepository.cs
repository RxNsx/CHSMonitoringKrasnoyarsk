using CHSMonitoring.Domain.Entities;
using CHSMonitoring.Domain.Enums;

namespace CHSMonitoring.Infrastructure.Interfaces;

/// <summary>
/// Интерфейс репозитория подписок
/// </summary>
public interface ISubscriptionRepository
{
    /// <summary>
    /// Добавить данные подписки
    /// </summary>
    /// <param name="subscription"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<Subscription?> AddSubscriptionAsync(Subscription subscription, CancellationToken cancellationToken);

    /// <summary>
    /// Обновить информацию подписки
    /// </summary>
    /// <param name="updateSubecription"></param>
    /// <param name="userId"></param>
    /// <param name="profileTypeEnum"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<Subscription?> UpdateSubscriptionAsync(Subscription updateSubecription, long userId, ProfileTypeEnum profileTypeEnum,
        CancellationToken cancellationToken);
    
    /// <summary>
    /// Сущесвует ли подписка у пользователя
    /// </summary>
    /// <param name="userId"></param>
    /// <param name="profileTypeEnum"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<bool> IsSubscribeExistsAsync(long userId, ProfileTypeEnum profileTypeEnum, CancellationToken cancellationToken);

    /// <summary>
    /// Получить подписку пользователя
    /// </summary>
    /// <param name="userId"></param>
    /// <param name="profileTypeEnum"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<Subscription?> GetSubscriptionAsync(long userId, ProfileTypeEnum profileTypeEnum, CancellationToken cancellationToken);
}