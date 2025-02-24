namespace CHSMonitoring.Infrastructure.Telegram;

/// <summary>
/// Интервалы уведомлений пользователя о текущих отключениях
/// </summary>
public enum RefreshInterval
{
    /// <summary>
    /// Выключено
    /// </summary>
    Off = 0,
    /// <summary>
    /// 15 минут
    /// </summary>
    QuarterHour = 2,
    /// <summary>
    /// 30 минут
    /// </summary>
    HalfHour = 30,
    /// <summary>
    /// Час
    /// </summary>
    Hour = 60
}