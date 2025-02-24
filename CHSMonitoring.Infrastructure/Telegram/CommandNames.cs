namespace CHSMonitoring.Infrastructure.Telegram;

/// <summary>
/// Названия команд
/// </summary>
public static class CommandNames
{
    /// <summary>
    /// Команда старта
    /// </summary>
    public const string StartCommand = "/start";
    /// <summary>
    /// Запустить процесс авторизации
    /// </summary>
    public const string StartAuthorizeProcess = "start_authorize_process";

    /// <summary>
    /// Отобразить кнопки
    /// </summary>
    public const string ShowButtonsCommand = "/buttons";
    /// <summary>
    /// Получить клавиатуру с выбором района для отображения уведомлений
    /// </summary>
    public const string ShowDistrictButtonsList = "show_district_buttons-list";
    
    /// <summary>
    /// Получение последней актуальной информации по отключениям
    /// </summary>
    public const string ShowDistrictServiceAddressDataCommand = "all-district";

    /// <summary>
    /// Успешная авторизация
    /// </summary>
    public const string SuccessAuthorization = "success_authorization";
    /// <summary>
    /// Отправка сообщения пользователю
    /// </summary>
    public const string SendUserMessage = "send_user_message";
    /// <summary>
    /// Команда отправки ошибки
    /// </summary>
    public const string SendErrorCommand = "send_error_command";

    
    /// <summary>
    /// Команда редактирования подписки
    /// </summary>
    public const string SubscriptionCommand = "/subscription";
    /// <summary>
    /// Запустить процесс подписки
    /// </summary>
    public const string StartSubscribeProcess = "start_subscribe_process";
    /// <summary>
    /// Отобразить информацию о подписке пользователя на уведомления
    /// </summary>
    public const string ShowSubscriptionDetailsCommand = "show_subscription_details";
    /// <summary>
    /// Изменить параметры подписки
    /// </summary>
    public const string ChangeSubscription = "change_subscription";
    /// <summary>
    /// Получить клавиатуру выбора временных интервалов уведомлений
    /// </summary>
    public const string ShowUserTimeIntervalRefresh = "show_user_time_interval_refresh";
    /// <summary>
    /// Получить клавиатуру с выбором района
    /// </summary>
    public const string ShowDistrictButtonsSubscription = "show_district_buttons-subscription";
}