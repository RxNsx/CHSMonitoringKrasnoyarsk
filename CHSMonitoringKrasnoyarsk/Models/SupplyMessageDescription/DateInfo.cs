namespace CHSMonitoringKrasnoyarsk.Models.SupplyMessageDescription;

/// <summary>
/// Информация по времени
/// </summary>
public class DateInfo
{
    public DateTime DateFrom { get; private set; }
    public DateTime DateTo { get; private set; }
    public string DateFromString { get; private set; }
    public string DateToString { get; private set; }

    /// <summary>
    /// Конструктор
    /// </summary>
    /// <param name="dateFrom"></param>
    /// <param name="dateTo"></param>
    /// <param name="dateFromString"></param>
    /// <param name="dateToString"></param>
    private DateInfo(DateTime dateFrom, DateTime dateTo, string dateFromString, string dateToString)
    {
        DateFrom = dateFrom;
        DateTo = dateTo;
        DateFromString = dateFromString;
        DateToString = dateToString;
    }

    public static DateInfo Create(DateTime dateFrom, DateTime dateTo, string dateFromString, string dateToString)
    {
        return new DateInfo(dateFrom, dateTo, dateFromString, dateToString);
    }
}