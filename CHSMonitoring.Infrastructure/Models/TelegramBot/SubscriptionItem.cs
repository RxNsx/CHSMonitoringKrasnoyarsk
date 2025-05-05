namespace CHSMonitoring.Infrastructure.Models.TelegramBot;

/// <summary>
/// Модель для взаимодействия с подпиской
/// </summary>
public class SubscriptionItem
{
    /// <summary>
    /// Ид пользователя
    /// </summary>
    public Guid UserId { get; set; }
    
    /// <summary>
    /// Ид профиля (лонг)
    /// </summary>
    public long ProfileId { get; set; }

    /// <summary>
    /// Ид района
    /// </summary>
    public Guid DistrictId { get; set; }

    /// <summary>
    /// Ид улицы
    /// </summary>
    public Guid StreetId { get; set; }

    /// <summary>
    /// Временной интервал оповещения
    /// </summary>
    public int UpdateUserTime { get; set; }
}