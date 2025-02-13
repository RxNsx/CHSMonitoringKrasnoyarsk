namespace CHSMonitoring.Infrastructure.Interfaces;

/// <summary>
/// Интерфейс сервиса хэширования паролей
/// </summary>
public interface IHashPasswordService
{
    /// <summary>
    /// Хэширование пароля
    /// </summary>
    /// <param name="password"></param>
    /// <returns></returns>
    public string HashPassword(string password);
    
    /// <summary>
    /// Проверка пароля пользователя
    /// </summary>
    /// <param name="password"></param>
    /// <param name="passwordHash"></param>
    /// <returns></returns>
    public bool VerifyPassword(string password, string passwordHash);
    
    
}