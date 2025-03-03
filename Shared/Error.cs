namespace Shared;

/// <summary>
/// Класс ошибки
/// </summary>
/// <param name="Text"></param>
/// <param name="ErrorTypeEnum"></param>
public class Error
{
    public string Text { get; private set; }
    internal ErrorTypeEnum ErrorTypeEnum { get; private set; }

    /// <summary>
    /// Конструктор
    /// </summary>
    public Error(string text, ErrorTypeEnum errorTypeEnum)
    {
        Text = text;
        ErrorTypeEnum = errorTypeEnum;
    }
    
    public static readonly Error None = new(string.Empty, ErrorTypeEnum.None);

    /// <summary>
    /// Создание ошибки когда не удалось найти объект
    /// </summary>
    /// <param name="description"></param>
    /// <returns></returns>
    public static Error NotFound(string description) => new(description, ErrorTypeEnum.NotFound);

    /// <summary>
    /// Ошибка валидации
    /// </summary>
    /// <param name="description"></param>
    /// <returns></returns>
    public static Error ValidationError(string description) => new Error(description, ErrorTypeEnum.Validation);
    
    /// <summary>
    /// Ошибка когда не передан объект
    /// </summary>
    /// <param name="description"></param>
    /// <returns></returns>
    public static Error NullValue(string description) => new Error(description, ErrorTypeEnum.NullValue);

    /// <summary>
    /// Ошибка транзакции
    /// </summary>
    /// <param name="description"></param>
    /// <returns></returns>
    public static Error TransactionError(string description) => new Error(description, ErrorTypeEnum.TransactionError);
}