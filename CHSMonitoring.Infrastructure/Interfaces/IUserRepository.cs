using CHSMonitoring.Domain.Entities;

namespace CHSMonitoring.Infrastructure.Interfaces;

/// <summary>
/// Интерфейс репозитория пользователей
/// </summary>
public interface IUserRepository
{
    /// <summary>
    /// Получить пользователя по ид профиля телеграмма
    /// </summary>
    /// <param name="profileId"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<User?> GetUserByTelegramProfileIdAsync(long profileId, CancellationToken cancellationToken);
    
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
    /// Получить пользователя по почтовому адресу
    /// </summary>
    /// <param name="emailAddress"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<User?> GetUserByUserEmailAddressAsync(string emailAddress, CancellationToken cancellationToken);

    /// <summary>
    /// Добавить пользователя 
    /// </summary>
    /// <param name="emailAddress"></param>
    /// <param name="cancellationToken"></param>
    /// <param name="userName"></param>
    /// <param name="loginName"></param>
    /// <param name="hashPassword"></param>
    /// <returns></returns>
    Task<User> CreateWebApplicationUserAsync(string userName, string loginName, string hashPassword, string emailAddress, CancellationToken cancellationToken);


    /// <summary>
    /// Создать телеграм профиль пользователя
    /// </summary>
    /// <param name="chatId"></param>
    /// <param name="userName"></param>
    /// <param name="telegramName"></param>
    /// <param name="emailAddress"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<User> CreateTelegramUserAsync(long chatId, string userName, string telegramName, string emailAddress,
        CancellationToken cancellationToken);

    /// <summary>
    /// Проверка существует ли указанный пользователь с таким логином
    /// </summary>
    /// <param name="emailAddress"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<bool> IsUserExists(string emailAddress, CancellationToken cancellationToken);

    /// <summary>
    /// Обновляет у пользователя время последней отправки уведомления
    /// </summary>
    /// <param name="userId"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task UpdateUserNotifyUpdateDateAsync(Guid userId, CancellationToken cancellationToken);
}