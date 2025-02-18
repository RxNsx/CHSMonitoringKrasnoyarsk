namespace CHSMonitoring.Domain.Entities;

/// <summary>
/// Тип профиля пользователя
/// </summary>
public class ProfileType
{
    /// <summary>
    /// Ид
    /// </summary>
    public Guid Id { get; set; }
    
    /// <summary>
    /// Название типа профиля
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Признак только для чтения
    /// </summary>
    public bool IsReadOnly { get; set; }
}