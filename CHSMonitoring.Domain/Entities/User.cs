namespace CHSMonitoring.Domain.Entities;

/// <summary>
/// Пользователь
/// </summary>
public class User : Entity
{
    /// <summary>
    /// Имя
    /// </summary>
    public string Name { get; set; }
    
    /// <summary>
    /// Пароль
    /// </summary>
    public string Password { get; set; }
    
    /// <summary>
    /// Описание пользователя
    /// </summary>
    public string  Description { get; set; }
    
    /// <summary>
    /// Навигационное свойство для профиля
    /// </summary>
    public Profile Profile { get; set; }
    
    /// <summary>
    /// Айди роли
    /// </summary>
    public Guid RoleId { get; set; }
    
    /// <summary>
    /// Навигационное свойство для роли
    /// </summary>
    public Role Role { get; set; }
}