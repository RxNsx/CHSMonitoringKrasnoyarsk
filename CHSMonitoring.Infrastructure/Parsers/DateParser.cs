using System.Globalization;
using CHSMonitoring.Infrastructure.Models.ServiceMessageAddress;

namespace CHSMonitoring.Infrastructure.Models.Parsers;

public static class DateParser
{
    public static DateInfo ParseDatesFromTo(List<string> datesList)
    {
        var dateFrom = DateTime.MinValue;
        var dateTo = DateTime.MinValue;
        var dateFromString = string.Empty;   
        var dateToString = string.Empty;

        switch (datesList.Count)
        {
            case 1:
            {
                return DateInfo.Create(null, null, datesList.First(), datesList.First());
            }
            case 2:
            {
                var format = "dd MMMM HH-mm";
                var cultureInfo = new CultureInfo("ru-RU");

                if (!DateTime.TryParseExact(datesList[0], format, cultureInfo, DateTimeStyles.None, out dateFrom))
                {
                    dateFromString = datesList[0];
                }
                else
                {
                    dateFromString = dateFrom.ToString(cultureInfo);
                }
            
                if (!DateTime.TryParseExact(datesList[1], format, cultureInfo, DateTimeStyles.None, out dateTo))
                {
                    dateToString = datesList[1];
                }
                else
                {
                    dateToString = dateTo.ToString(cultureInfo);
                }
            
                DateTime? dateFromParsed = dateFrom;
                DateTime? dateToParsed = dateTo;
                if (dateFrom == DateTime.MinValue)
                {
                    dateFromParsed = null;
                }
                if (dateTo == DateTime.MinValue)
                {
                    dateToParsed = null;
                }
        
                return DateInfo.Create(dateFromParsed, dateToParsed, dateFromString, dateToString);
            }
            default:
                return DateInfo.Create(null, null, string.Empty, string.Empty);
        }
    }
}