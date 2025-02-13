namespace CHSMonitoring.Application.Dtos.User;

/// <summary>
/// Данные для регистрации пользователя
/// </summary>
public class RegisterItemDto
{
    /// <summary>
    /// Имя пользователя
    /// </summary>
    public string UserName { get; set; }
    
    /// <summary>
    /// Логин пользователя
    /// </summary>
    public string LoginName { get; set; }

    /// <summary>
    /// Почта пользователя
    /// </summary>
    public string Email { get; set; }

    /// <summary>
    /// Пароль пользователя
    /// </summary>
    public string Password { get; set; }
}