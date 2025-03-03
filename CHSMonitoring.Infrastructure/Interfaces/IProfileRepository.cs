using CHSMonitoring.Domain.Entities;
using CHSMonitoring.Domain.Enums;

namespace CHSMonitoring.Infrastructure.Interfaces;

/// <summary>
/// Интерфейс репозитория профилей
/// </summary>
public interface IProfileRepository
{
    /// <summary>
    /// Создать профиль телеграма
    /// </summary>
    /// <param name="userId"></param>
    /// <param name="chatId"></param>
    /// <param name="telegramName"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<Profile> CreateTelegramProfileAsync(Guid userId, long chatId, string telegramName, CancellationToken cancellationToken);

    /// <summary>
    /// Создать профиль для веба
    /// </summary>
    /// <param name="userId"></param>
    /// <param name="loginName"></param>
    /// <param name="password"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<Profile> CreateWebProfileAsync(Guid userId, string loginName, string password, CancellationToken cancellationToken);
    
    /// <summary>
    /// Существует ли указанный профиль у пользователя
    /// </summary>
    /// <param name="userId"></param>
    /// <param name="profileTypeEnum"></param>
    /// <returns></returns>
    Task<bool> IsExistProfileAsync(Guid userId, ProfileTypeEnum profileTypeEnum);

    /// <summary>
    /// Существует ли телеграм профиль
    /// </summary>
    /// <param name="chatId"></param>
    /// <returns></returns>
    Task<bool> IsTelegramProfileAsync(long chatId);

    /// <summary>
    /// Получить профиль пользователя 
    /// </summary>
    /// <param name="userId"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<Profile?> GetTelegramProfileAsync(Guid userId, CancellationToken cancellationToken);
    
    /// <summary>
    /// Получить веб профиль по имени пользователя
    /// </summary>
    /// <param name="loginName"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<Profile?> GetWebApplicationProfileByLoginNameAsync(string loginName, CancellationToken cancellationToken);
}