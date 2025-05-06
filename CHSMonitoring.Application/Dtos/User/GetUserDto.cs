using System.Text.Json.Serialization;

namespace CHSMonitoring.Application.Dtos.User;

/// <summary>
/// Данные для получения пользователя
/// </summary>
public class GetUserDto
{
    [JsonPropertyName("userId")]
    public Guid UserId { get; set; }

    /// <summary>
    /// Логин пользователял
    /// </summary>
    [JsonPropertyName("loginName")]
    public string LoginName { get; set; }
    
    /// <summary>
    /// Адрес электронной почты
    /// </summary>
    [JsonPropertyName("userEmail")]
    public string Email { get; set; }
    
    /// <summary>
    /// Ид района подписки
    /// </summary>
    [JsonPropertyName("districtId")]
    public string DistrictId { get; set; }
    
    /// <summary>
    /// Название района
    /// </summary>
    [JsonPropertyName("districtName")]
    public string DistrictName { get; set; }
    
    /// <summary>
    /// Ид улицы
    /// </summary>
    [JsonPropertyName("streetId")]
    public string StreetId { get; set; }
    
    /// <summary>
    /// Название улицы
    /// </summary>
    [JsonPropertyName("streetName")]
    public string StreetName { get; set; }
}