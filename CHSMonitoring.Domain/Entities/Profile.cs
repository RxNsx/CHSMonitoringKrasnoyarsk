namespace CHSMonitoring.Domain.Entities;

/// <summary>
/// Профиль пользователя в системе авторизации
/// </summary>
public class Profile : Entity
{
    /// <summary>
    /// Название профиля
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Название улицы
    /// </summary>
    public string Street { get; set; }

    /// <summary>
    /// Номер дома
    /// </summary>
    public string HouseNumber { get; set; }

    /// <summary>
    /// Айди пользователя
    /// </summary>
    public Guid UserId { get; set; }

    /// <summary>
    /// Навигационное свойство на пользователя
    /// </summary>
    public User User { get; set; }
}