namespace CHSMonitoring.Domain.Entities;

/// <summary>
/// Адрес обслуживания
/// </summary>
public class ServiceAddress : Entity
{
    /// <summary>
    /// Номер дома
    /// </summary>
    public string HouseNumber { get; set; }

    /// <summary>
    /// Описание проблемы
    /// </summary>
    public string Description { get; set; }
    
    /// <summary>
    /// Дата начала отключения
    /// </summary>
    public DateTime? From { get; set; }

    /// <summary>
    /// Дата начала отключения в формате строки (или сообщение об отключении)
    /// </summary>
    public string DateTimeFromString { get; set; }
    
    /// <summary>
    /// Дата окончания отключения
    /// </summary>
    public DateTime? To { get; set; }
    
    /// <summary>
    /// Дата конца отключения в формате строки (или сообщение об отключении)
    /// </summary>
    public string DateTimeToString { get; set; }
    
    /// <summary>
    /// Признак только для чтения
    /// </summary>
    public bool IsReadOnly { get; set; }
    
    /// <summary>
    /// Дата чтения события
    /// </summary>
    public DateTime CreatedDate { get; set; }
    
    public Guid DistrictId { get; set; }
    
    public District District { get; set; }
    
    public Guid StreetId { get; set; }
    
    public Street Street { get; set; }
    
    public Guid ServiceTypeId { get; set; }
    public ServiceType ServiceType { get; set; }
}