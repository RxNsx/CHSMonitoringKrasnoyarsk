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
    public static string NormalizeSpacesInText(this string text)
    {
        return Regex.Replace(text, @"\s+", " ");
    }
}