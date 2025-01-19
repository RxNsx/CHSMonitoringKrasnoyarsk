namespace CHSMonitoring.Domain.Entities;

/// <summary>
/// Запланированные типы обслуживания
/// </summary>
public class PlannedServiceType : Entity
{
    /// <summary>
    /// Название запланированного типа обслуживания
    /// </summary>
    public string Name { get; set; }
    
    /// <summary>
    /// Описание запланнированного типа обслуживания
    /// </summary>
    public string Description { get; set; }
}