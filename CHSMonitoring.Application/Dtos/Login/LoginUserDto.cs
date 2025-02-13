namespace CHSMonitoring.Application.Dtos.Login;

/// <summary>
/// Данные для авторизации
/// </summary>
public class LoginUserDto
{
    /// <summary>
    /// Имя пользователя
    /// </summary>
    public string LoginName { get; set; }

    /// <summary>
    /// Информация о полученном токене авторизации
    /// </summary>
    public string TokenData { get; set; }
}
