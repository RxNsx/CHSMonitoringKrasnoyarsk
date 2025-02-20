using CHSMonitoring.Domain.Abstractions;

namespace CHSMonitoring.Domain.Entities;

/// <summary>
/// Район города
/// </summary>
public class District : Entity
{
    /// <summary>
    /// Название района
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Признак только для чтения
    /// </summary>
    public bool IsReadOnly { get; set; }
    
    public List<ServiceAddress> ServiceAddresses { get; set; }
}