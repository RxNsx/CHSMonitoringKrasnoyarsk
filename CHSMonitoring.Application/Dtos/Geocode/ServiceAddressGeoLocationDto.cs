namespace CHSMonitoring.Application.Dtos.Geocode;

/// <summary>
/// Геолокация адреса обслуживания
/// </summary>
public class ServiceAddressGeoLocationDto
{
    /// <summary>
    /// Название улицы
    /// </summary>
    public string Address { get; set; }
    /// <summary>
    /// Широта
    /// </summary>
    public string Latitude { get; set; }
    /// <summary>
    /// Долгота
    /// </summary>
    public string Longtitude { get; set; }
    
    /// <summary>
    /// Тип отключения
    /// </summary>
    public string ServiceTypeName { get; set; }
}