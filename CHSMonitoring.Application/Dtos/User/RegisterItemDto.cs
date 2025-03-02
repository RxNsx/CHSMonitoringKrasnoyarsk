using System.Text.Json.Serialization;

namespace CHSMonitoring.Application.Dtos.User;

/// <summary>
/// Данные для регистрации пользователя
/// </summary>
public class RegisterItemDto
{
    /// <summary>
    /// Имя пользователя
    /// </summary>
    [JsonPropertyName("userName")]
    public string UserName { get; set; }
    
    /// <summary>
    /// Логин пользователя
    /// </summary>
    [JsonPropertyName("loginName")]
    public string LoginName { get; set; }

    /// <summary>
    /// Почта пользователя
    /// </summary>
    [JsonPropertyName("email")]
    public string Email { get; set; }

    /// <summary>
    /// Пароль пользователя
    /// </summary>
    [JsonPropertyName("password")]
    public string Password { get; set; }
}