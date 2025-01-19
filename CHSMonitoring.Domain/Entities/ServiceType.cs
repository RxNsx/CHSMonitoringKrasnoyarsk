namespace CHSMonitoring.Domain.Entities;

/// <summary>
/// Тип обслуживания
/// </summary>
public class ServiceType : Entity
{
    /// <summary>
    /// Название типа обслуживания
    /// </summary>
    public string Name { get; set; }
    
    /// <summary>
    /// Описание типа обслуживания
    /// </summary>
    public string Description { get; set; }
}