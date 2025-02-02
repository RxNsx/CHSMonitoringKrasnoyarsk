namespace CHSMonitoring.Domain.Entities;

/// <summary>
/// Адрес обслуживания
/// </summary>
public class ServiceAddress : Entity
{
    /// <summary>
    /// Название района
    /// </summary>
    public string DistrictName { get; set; }
    
    /// <summary>
    /// Название улицы
    /// </summary>
    public string StreetName { get; set; }
    
    /// <summary>
    /// Номер дома
    /// </summary>
    public string HouseNumber { get; set; }

    /// <summary>
    /// Описание проблемы
    /// </summary>
    public string Description { get; set; }

    /// <summary>
    /// Тип обслуживания (SupplyEnumType)
    /// </summary>
    public string ServiceType { get; set; }
    
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
}