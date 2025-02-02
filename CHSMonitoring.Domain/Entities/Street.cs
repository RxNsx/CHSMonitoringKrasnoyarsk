namespace CHSMonitoring.Domain.Entities;

/// <summary>
/// Улица
/// </summary>
public class Street : Entity
{
    /// <summary>
    /// Название улицы
    /// </summary>
    public string Name { get; set; }
    /// <summary>
    /// Описание улицы
    /// </summary>
    public string Description { get; set; }
    
    public ServiceAddress ServiceAddress { get; set; }
}