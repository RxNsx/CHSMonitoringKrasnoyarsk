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
    /// Успешная авторизация
    /// </summary>
    public const string SuccessAuthorization = "success_authorization";
    /// <summary>
    /// Запустить процесс авторизации
    /// </summary>
    public const string StartAuthorizeProcess = "start_authorize_process";
    /// <summary>
    /// Получение последней актуальной информации по отключениям
    /// </summary>
    public const string ShowDistrictServiceAddressDataCommand = "all-district";
    /// <summary>
    /// Получить клавиатуру с выбором района
    /// </summary>
    public const string ShowDistrictButtons = "show_district_buttons";
    /// <summary>
    /// Отправка сообщения пользователю
    /// </summary>
    public const string SendUserMessage = "send_user_message";
    /// <summary>
    /// Команда отправки ошибки
    /// </summary>
    public const string SendErrorCommand = "send_error_command";
}