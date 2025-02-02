namespace CHSMonitoring.Domain.Entities;

/// <summary>
/// Адрес обслуживания
/// </summary>
public class ServiceAddress : Entity
{
    /// <summary>
    /// Номер дома
    /// </summary>
    public required string HouseNumber { get; set; }

    /// <summary>
    /// Описание проблемы
    /// </summary>
    public required string Description { get; set; }
    
    /// <summary>
    /// Дата начала отключения
    /// </summary>
    public required DateTime? From { get; set; }

    /// <summary>
    /// Дата начала отключения в формате строки (или сообщение об отключении)
    /// </summary>
    public required string DateTimeFromString { get; set; }
    
    /// <summary>
    /// Дата окончания отключения
    /// </summary>
    public required DateTime? To { get; set; }
    
    /// <summary>
    /// Дата конца отключения в формате строки (или сообщение об отключении)
    /// </summary>
    public required string DateTimeToString { get; set; }
    
    /// <summary>
    /// Признак только для чтения
    /// </summary>
    public bool IsReadOnly { get; set; }
    
    /// <summary>
    /// Дата чтения события
    /// </summary>
    public required DateTime CreatedDate { get; set; }
    
    /// <summary>
    /// Ид района
    /// </summary>
    public required Guid DistrictId { get; set; }
    
    /// <summary>
    /// Навигационное свойство района
    /// </summary>
    public District District { get; set; }
    
    /// <summary>
    /// Ид улицы
    /// </summary>
    public required Guid StreetId { get; set; }
    
    /// <summary>
    /// Навигационное свойство улицы
    /// </summary>
    public Street Street { get; set; }
    
    /// <summary>
    /// Ид типа обслуживания
    /// </summary>
    public required Guid ServiceTypeId { get; set; }
    
    /// <summary>
    /// Навигационное свойство типа обслуживания
    /// </summary>
    public ServiceType ServiceType { get; set; }
}