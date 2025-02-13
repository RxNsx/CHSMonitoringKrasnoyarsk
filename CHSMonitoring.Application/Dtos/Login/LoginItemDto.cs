namespace CHSMonitoring.Application.Dtos.Login;

public class LoginItemDto
{
    /// <summary>
    /// Логин пользователя для авторизации
    /// </summary>
    public string LoginName { get; set; }
    
    /// <summary>
    /// Пароль пользователя
    /// </summary>
    public string Password { get; set; }
}