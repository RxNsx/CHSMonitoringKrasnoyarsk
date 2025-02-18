namespace CHSMonitoring.Domain.Entities;

/// <summary>
/// Профиль пользователя в системе авторизации
/// </summary>
public class Profile : Entity
{
    /// <summary>
    /// Айди пользователя системы (телеграм чат ид итд)
    /// </summary>
    public long ProviderId { get; set; }

    /// <summary>
    /// Логин пользователя в системе
    /// </summary>
    public string LoginName { get; set; }

    /// <summary>
    /// Пароль пользователя в системе (если нужен)
    /// </summary>
    public string Password { get; set; }
    
    /// <summary>
    /// Название улицы
    /// </summary>
    public string Street { get; set; }

    /// <summary>
    /// Номер дома
    /// </summary>
    public string HouseNumber { get; set; }
    
    /// <summary>
    /// Название профиля
    /// </summary>
    public Guid ProfileTypeId { get; set; }
    
    /// <summary>
    /// Навигационное свойство типа профиля
    /// </summary>
    public ProfileType ProfileType { get; set; }
    
    /// <summary>
    /// Айди пользователя
    /// </summary>
    public Guid UserId { get; set; }

    /// <summary>
    /// Навигационное свойство на пользователя
    /// </summary>
    public User User { get; set; }
}