using CHSMonitoring.Domain.Abstractions;

namespace CHSMonitoring.Domain.Entities;

/// <summary>
/// Пользователь
/// </summary>
public class User : Entity
{
    /// <summary>
    /// Имя пользователя
    /// </summary>
    public string UserName { get; set; }

    /// <summary>
    /// Адрес почты
    /// </summary>
    public string EmailAddress { get; set; }
    
    /// <summary>
    /// Описание пользователя
    /// </summary>
    public string Description { get; set; }
    
    /// <summary>
    /// Последняя дата уведомления пользователя
    /// </summary>
    public DateTime? LastUpdated { get; set; }

    /// <summary>
    /// Навигационное свойство для профилей
    /// </summary>
    public List<Profile> Profiles { get; set; }
    
    /// <summary>
    /// Навигационное свойство для роли
    /// </summary>
    public List<Role> Roles { get; set; }
    
    /// <summary>
    /// Айди подписки
    /// </summary>
    public Guid SubscriptionId { get; set; }
    
    /// <summary>
    /// Навигационное свойство подписки
    /// </summary>
    public Subscription Subscription { get; set; }
}