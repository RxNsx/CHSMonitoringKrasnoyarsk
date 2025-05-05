using System.Text.Json.Serialization;

namespace CHSMonitoring.Application.Dtos.Streets;

/// <summary>
/// Модель представления для улицы
/// </summary>
public class StreetDto
{
    /// <summary>
    /// Ид улицы
    /// </summary>
    [JsonPropertyName("streetId")]
    public Guid StreetId { get; set; }
    
    /// <summary>
    /// Название улицы
    /// </summary>
    [JsonPropertyName("streetName")]
    public string StreetName { get; set; }
}