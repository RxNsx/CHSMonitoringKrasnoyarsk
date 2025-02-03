namespace CHSMonitoring.Infrastructure.Models.ServiceMessageAddress;

/// <summary>
/// Информация по времени
/// </summary>
public class DateInfo
{
    /// <summary>
    /// Дата начала обслуживания аварии
    /// </summary>
    public DateTime? DateFrom { get; private set; }
    /// <summary>
    /// Дата начала окончания аварии
    /// </summary>
    public DateTime? DateTo { get; private set; }
    /// <summary>
    /// Дата начала обслуживания в виде строки
    /// </summary>
    public string DateFromString { get; private set; }
    /// <summary>
    /// Дата окончания обслуживания в виде строки
    /// </summary>
    public string DateToString { get; private set; }

    /// <summary>
    /// Конструктор
    /// </summary>
    /// <param name="dateFrom"></param>
    /// <param name="dateTo"></param>
    /// <param name="dateFromString"></param>
    /// <param name="dateToString"></param>
    private DateInfo(DateTime? dateFrom, DateTime? dateTo, string dateFromString, string dateToString)
    {
        DateFrom = dateFrom;
        DateTo = dateTo;
        DateFromString = dateFromString;
        DateToString = dateToString;
    }

    /// <summary>
    /// Фабричный метод создания информации по датам
    /// </summary>
    /// <param name="dateFrom"></param>
    /// <param name="dateTo"></param>
    /// <param name="dateFromString"></param>
    /// <param name="dateToString"></param>
    /// <returns></returns>
    public static DateInfo Create(DateTime? dateFrom, DateTime? dateTo, string dateFromString, string dateToString)
    {
        return new DateInfo(dateFrom, dateTo, dateFromString, dateToString);
    }
}