namespace CHSMonitoring.Infrastructure.Telegram;

/// <summary>
/// Состояния команд для телеграм бота
/// </summary>
public enum CommandState
{
    /// <summary>
    /// Неактивное
    /// </summary>
    NotActive,
    /// <summary>
    /// Авторизация начата
    /// </summary>
    AuthrorizeStart,
    /// <summary>
    /// Авторизация имя установлено
    /// </summary>
    AuthorizeUserNameSet,
    /// <summary>
    /// В работе
    /// </summary>
    InWork,
    /// <summary>
    /// Завершенное
    /// </summary>
    Finished
}