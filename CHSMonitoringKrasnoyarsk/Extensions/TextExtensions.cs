using System.Text.RegularExpressions;

namespace CHSMonitoringKrasnoyarsk.Extensions;

/// <summary>
/// Расширение дял строки
/// </summary>
public static class TextExtensions
{
    /// <summary>
    /// Убирает лишние пробелы в строке
    /// </summary>
    /// <param name="text"></param>
    /// <returns></returns>
    public static string NormalizeText(this string text)
    {
        text = text.Trim();
            
        var newLineSymbolsCount = Regex.Matches(text, "\n").Count;
        while (newLineSymbolsCount > 1)
        {
            if (string.IsNullOrEmpty(text) &&
                text == "&nbsp;")
            {
                continue;
            }
                        
            text =  text.Replace("\n", "");
            newLineSymbolsCount--;
        }
                    
        var carriageSymbolsCount = Regex.Matches(text, "\r").Count;
        while (carriageSymbolsCount > 0)
        {
            if (string.IsNullOrEmpty(text) &&
                text == "&nbsp;")
            {
                continue;
            }
                        
            text =  text.Replace("\r", "");
            carriageSymbolsCount--;
        }
        
        return Regex.Replace(text, @"\s+", " ");
    }
}