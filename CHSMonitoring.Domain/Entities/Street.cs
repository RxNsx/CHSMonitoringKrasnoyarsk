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
    /// <summary>
    /// Номера домов
    /// </summary>
    public string HouseNumbers { get; set; }
    /// <summary>
    /// Признак только для чтения 
    /// </summary>
    public bool IsReadonly { get; set; }
    
    public List<ServiceAddress> ServiceAddresses { get; set; }
}