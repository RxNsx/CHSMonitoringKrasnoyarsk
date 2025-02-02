using System.Text.RegularExpressions;

namespace CHSMonitoring.Infrastructure.Extensions;

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
        var carriageSymbolsCount = Regex.Matches(text, "\r").Count;

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

    /// <summary>
    /// Форматирование строки без наличия символом каретки \r
    /// </summary>
    /// <param name="text"></param>
    /// <returns></returns>
    public static string NormalizeTextWithNewLine(this string text)
    {
        text = text.Trim();
            
        var newLineSymbolsCount = Regex.Matches(text, "\n").Count;
        var carriageSymbolsCount = Regex.Matches(text, "\r").Count;

        if (newLineSymbolsCount > 0 && carriageSymbolsCount == 0)
        {
            return Regex.Replace(text, "\n", "\r\n");
        }
        
        return text;
    }

    public static string NormalizedSplitNumber(this string text)
    {
        text = text.Trim();
        var indexOfSpace = text.IndexOf(" ");
        if (indexOfSpace == -1)
        {
            return text;
        }
        
        return text.Substring(0, indexOfSpace);
    }
}