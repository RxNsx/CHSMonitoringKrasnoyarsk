namespace CHSMonitoring.Infrastructure.Settings;

/// <summary>
/// Настройки для телеграм бота
/// </summary>
public class TelegramBotSettings
{
    /// <summary>
    /// Адрес проброса тунельного адреса для взаимодействия с ботом
    /// </summary>
    public string TunnelUrl { get; set; }
    /// <summary>
    /// Количество выводимых сообщений на экран в одном сообщений
    /// </summary>
    /// <returns></returns>
    public int MessageSplitterPortionSize { get; set; }
}