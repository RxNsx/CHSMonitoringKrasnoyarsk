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
    /// Запрос переотсылки почтового адреса
    /// </summary>
    public const string ResentEmailAddress = "resent_email_address";
    /// <summary>
    /// Пользователь с таким почтовым адресом уже существует
    /// </summary>
    public const string UserEmailAlreadyExists = "user_email_already_exists";
    /// <summary>
    /// Успешная авторизация
    /// </summary>
    public const string SuccessAuthorization = "success_authorization";
    /// <summary>
    /// Запустить процесс авторизации
    /// </summary>
    public const string StartAuthorizeProcess = "start_authorize_process";
    /// <summary>
    /// Команда установки почты
    /// </summary>
    public const string SetEmailAddressCommand = "set_email_address";
    /// <summary>
    /// Команда отправки ошибки
    /// </summary>
    public const string SendErrorCommand = "send_error_command";
    /// <summary>
    /// Команда установки имени
    /// </summary>
    public const string SetUserNameCommand = "set_username";
    /// <summary>
    /// Получение информации по району
    /// </summary>
    public const string GetDistrictInfo = "get_district_info";
    /// <summary>
    /// Получение информации по улице
    /// </summary>
    public const string GetStreetInfo = "get_street_info";
    /// <summary>
    /// Получение последней актуальной информации по отключениям
    /// </summary>
    public const string ShowDistrictServiceAddressDataCommand = "all-district";
    /// <summary>
    /// Поиощь
    /// </summary>
    public const string HelpCommand = "/help";
    /// <summary>
    /// Получить клавиатуру с выбором района
    /// </summary>
    public const string ShowDistrictButtons = "show_district_buttons";
}