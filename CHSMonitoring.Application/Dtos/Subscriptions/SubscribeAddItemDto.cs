namespace CHSMonitoring.Application.Dtos.Subscriptions;

/// <summary>
/// Модель добавления подписки
/// </summary>
public class SubscribeAddItemDto
{
    /// <summary>
    /// Ид пользователя
    /// </summary>
    public string LoginName { get; set; }
    
    /// <summary>
    /// Ид района для подписки
    /// </summary>
    public Guid DistrictId { get; set; }
    
    /// <summary>
    /// Ид улицы для подписки
    /// </summary>
    public Guid StreetId { get; set; }
}