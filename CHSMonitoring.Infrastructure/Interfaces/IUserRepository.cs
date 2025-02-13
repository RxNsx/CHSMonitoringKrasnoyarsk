using CHSMonitoring.Domain.Entities;

namespace CHSMonitoring.Infrastructure.Interfaces;

/// <summary>
/// Интерфейс репозитория пользователей
/// </summary>
public interface IUserRepository
{
    /// <summary>
    /// Получить пользователя по логину
    /// </summary>
    /// <param name="loginName"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<User?> GetUserByLoginNameAsync(string loginName, CancellationToken cancellationToken);

    /// <summary>
    /// Получить пользователя по ид
    /// </summary>
    /// <param name="userId"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<User?> GetUserByUserIdAsync(Guid userId, CancellationToken cancellationToken);

    /// <summary>
    /// Добавить пользователя
    /// </summary>
    /// <param name="email"></param>
    /// <param name="cancellationToken"></param>
    /// <param name="userName"></param>
    /// <param name="loginName"></param>
    /// <param name="hashPassword"></param>
    /// <returns></returns>
    Task<User> CreateUserAsync(string userName, string loginName, string hashPassword, string email, CancellationToken cancellationToken);

    /// <summary>
    /// Проверка существует ли указанный пользователь с таким логином
    /// </summary>
    /// <param name="loginName"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<bool> IsUserExists(string loginName, CancellationToken cancellationToken);
}