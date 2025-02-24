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
    /// Подписка началась
    /// </summary>
    SubscribeStart,
    /// <summary>
    /// Изменить район в подписке
    /// </summary>
    EditSubscribeChangeDistrict,
    /// <summary>
    /// Изменить интервал
    /// </summary>
    EditSubscribeChangeInterval,
    /// <summary>
    /// Район для отслеживания установлен
    /// </summary>
    SubscribeDistrictSet
}