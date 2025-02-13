namespace CHSMonitoring.Application.Dtos.User;

/// <summary>
/// Зарегистрированный пользователь
/// </summary>
public class RegisterUserDto
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
}