using CHSMonitoring.Domain.Abstractions;

namespace CHSMonitoring.Domain.Entities;

/// <summary>
/// Информация о подписке пользователя на уведомления
/// </summary>
public class Subscription : Entity
{
    /// <summary>
    /// Интервал оповещения пользователя о событиях
    /// </summary>
    public int UpdateUserTime { get; set; }
    
    /// <summary>
    /// Ид района на который подписан
    /// </summary>
    public Guid DistrictId { get; set; }
    
    /// <summary>
    /// Навигационное свойства района
    /// </summary>
    public District District { get; set; }
    
    /// <summary>
    /// Ид пользователя
    /// </summary>
    public Guid UserId { get; set; }
    
    /// <summary>
    /// Навигационное свойство пользователя
    /// </summary>
    public User User { get; set; }
}