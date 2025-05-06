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
    /// <param name="userId"></param>
    /// <param name="profileId"></param>
    /// <param name="districtId"></param>
    /// <param name="updateUserTime"></param>
    /// <param name="profileTypeEnum"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<Subscription?> AddSubscriptionAsync(Guid userId, long profileId, Guid districtId, int updateUserTime, ProfileTypeEnum profileTypeEnum, CancellationToken cancellationToken);

    /// <summary>
    /// Обновить информацию подписки
    /// </summary>
    /// <param name="userId"></param>
    /// <param name="profileId"></param>
    /// <param name="updateSubscrption"></param>
    /// <param name="profileTypeEnum"></param>
    /// <param name="cancellationToken"></param>
    Task UpdateSubscriptionAsync(Guid userId, long profileId, Subscription updateSubscrption, ProfileTypeEnum profileTypeEnum, CancellationToken cancellationToken);
    
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
    /// <param name="profileId"></param>
    /// <param name="profileTypeEnum"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<Subscription?> GetSubscriptionAsync(long profileId, ProfileTypeEnum profileTypeEnum, CancellationToken cancellationToken);

    /// <summary>
    /// Получить пользователей для уведомлений
    /// </summary>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<List<User>> GetNotifyUsersAsync(CancellationToken cancellationToken);
}