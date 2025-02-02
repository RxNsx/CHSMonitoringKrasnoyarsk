namespace CHSMonitoring.Domain.Entities;

/// <summary>
/// Роль пользователя
/// </summary>
public class Role : Entity
{
    /// <summary>
    /// Название профиля
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Описание роли
    /// </summary>
    public string Description { get; set; }
    
    /// <summary>
    /// Признак только для чтения
    /// </summary>
    public bool IsReadOnly { get; set; }

    /// <summary>
    /// Разрешения для роли
    /// </summary>
    public Permission Permission { get; set; }

    /// <summary>
    /// Айди пользователя
    /// </summary>
    public Guid UserId { get; set; }
    
    /// <summary>
    /// Навигационное свойство пользователя
    /// </summary>
    public User User { get; set; }
}