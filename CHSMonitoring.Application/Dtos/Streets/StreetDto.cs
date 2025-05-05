using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace CHSMonitoring.Application.Dtos.Streets;

/// <summary>
/// Модель представления для улицы
/// </summary>
public class StreetDto
{
    [JsonPropertyName("streetName")]
    public string StreetName { get; set; }
}