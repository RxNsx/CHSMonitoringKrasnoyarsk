namespace CHSMonitoring.Application.Dtos.District;

/// <summary>
/// Модель представления района
/// </summary>
public class DistrictDto
{
    /// <summary>
    /// Ид района
    /// </summary>
    public Guid Id { get; set; }
    
    /// <summary>
    /// Название района
    /// </summary>
    public string Name { get; set; }
}