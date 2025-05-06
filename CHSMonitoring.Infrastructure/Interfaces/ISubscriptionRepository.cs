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
    Task<Subscription?> AddTelegramSubscriptionAsync(Guid userId, long profileId, Guid districtId, int updateUserTime, ProfileTypeEnum profileTypeEnum, CancellationToken cancellationToken);

    /// <summary>
    /// Добавить подписку для веб приложения
    /// </summary>
    /// <param name="userId"></param>
    /// <param name="districtId"></param>
    /// <param name="streetId"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<Subscription> AddWebApplicationSubscriptionAsync(Guid userId, Guid? districtId, Guid? streetId, CancellationToken cancellationToken);

    /// <summary>
    /// Обновить информацию подписки
    /// </summary>
    /// <param name="userId"></param>
    /// <param name="profileId"></param>
    /// <param name="updateSubscription"></param>
    /// <param name="profileTypeEnum"></param>
    /// <param name="cancellationToken"></param>
    Task UpdateTelegramSubscriptionAsync(Guid userId, long profileId, Subscription updateSubscription, ProfileTypeEnum profileTypeEnum, CancellationToken cancellationToken);

    /// <summary>
    /// Обновить информацию подписки для веб приложения
    /// </summary>
    /// <param name="userId"></param>
    /// <param name="districtId"></param>
    /// <param name="streetId"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task UpdateWebApplicationSubscriptionAsync(Guid userId, Guid? districtId, Guid? streetId, CancellationToken cancellationToken);
    
    /// <summary>
    /// Сущесвует ли подписка у пользователя
    /// </summary>
    /// <param name="userId"></param>
    /// <param name="profileTypeEnum"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<bool> IsSubscribeExistsAsync(long userId, ProfileTypeEnum profileTypeEnum, CancellationToken cancellationToken);

    /// <summary>
    /// Получение подписки со стороны веб-приложения
    /// </summary>
    /// <param name="userId"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<Subscription?> GetWebApplicationSubscriptionAsync(Guid userId, CancellationToken cancellationToken);
    
    /// <summary>
    /// Получение подписки телеграма
    /// </summary>
    /// <param name="telegramProfileId"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<Subscription?> GetTelegramSubscriptionAsync(long telegramProfileId, CancellationToken cancellationToken);

    /// <summary>
    /// Получить пользователей для уведомлений
    /// </summary>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<List<User>> GetNotifyUsersAsync(CancellationToken cancellationToken);
}