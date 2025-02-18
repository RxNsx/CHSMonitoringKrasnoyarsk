using CHSMonitoring.Domain.Entities;

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
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task CreateTelegramProfileAsync(Guid userId, CancellationToken cancellationToken);

    /// <summary>
    /// Создать профиль для веба
    /// </summary>
    /// <param name="userId"></param>
    /// <param name="loginName"></param>
    /// <param name="password"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<Profile> CreateWebProfileAsync(Guid userId, string loginName, string password, CancellationToken cancellationToken);
}