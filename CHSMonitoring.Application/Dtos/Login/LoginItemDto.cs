using System.Text.Json.Serialization;

namespace CHSMonitoring.Application.Dtos.Login;

public class LoginItemDto
{
    /// <summary>
    /// Логин пользователя для авторизации
    /// </summary>
    [JsonPropertyName("loginName")]
    public string LoginName { get; set; }
    
    /// <summary>
    /// Пароль пользователя
    /// </summary>
    [JsonPropertyName("password")]
    public string Password { get; set; }
}