namespace CHSMonitoring.Application.Dtos.User;

/// <summary>
/// Данные для получения пользователя
/// </summary>
public class GetUserDto
{
    /// <summary>
    /// Имя пользователя
    /// </summary>
    public string UserName { get; set; }

    /// <summary>
    /// Адрес электронной почты
    /// </summary>
    public string Email { get; set; }
}