using System.Globalization;
using CHSMonitoring.API.Models.SupplyMessageDescription;

namespace CHSMonitoring.API.Models.Parsers;

public static class DateParser
{
    public static DateInfo ParseDatesFromTo(List<string> datesList)
    {
        var dateFrom = DateTime.MinValue;
        var dateTo = DateTime.MinValue;
        var dateFromString = string.Empty;   
        var dateToString = string.Empty;
        
        if (datesList.Any() && datesList.Count == 2)
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
        }

        // //TODO: В дате есть вариант "Отмена"
        // //TODO: В дате есть вариант "До устранения"
        
        return DateInfo.Create(dateFrom, dateTo, dateFromString, dateToString);
    }
}