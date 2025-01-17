namespace CHSMonitoringKrasnoyarsk.Models.Parsers;

public static class DateParser
{
    public static (DateTime,DateTime) ParseDatesFromTo(List<string> datesList)
    {
        return (DateTime.Now, DateTime.Now);
    }
}