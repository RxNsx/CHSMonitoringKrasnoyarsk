using System.Text.RegularExpressions;
using CHSMonitoring.Infrastructure.Models.Enums;

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

    /// <summary>
    /// Преобразование адресов при парсинге с сайта с информацией улиц города
    /// </summary>
    /// <param name="text"></param>
    /// <returns></returns>
    public static string NormalizeActualDataText(this string text)
    {
        return text
            //Специфика сайта и строки
            .Replace("на карте красноярска", string.Empty, StringComparison.InvariantCultureIgnoreCase)
            .Replace("в красноярске", string.Empty, StringComparison.InvariantCultureIgnoreCase)
            .Replace("- Красноярск", string.Empty, StringComparison.InvariantCultureIgnoreCase)
            .Replace("логовой", string.Empty, StringComparison.InvariantCultureIgnoreCase)
            .Replace("березовка", string.Empty, StringComparison.InvariantCultureIgnoreCase)
            .Replace("садовое товарищество химик", string.Empty, StringComparison.InvariantCultureIgnoreCase)
            .Replace("микрорайон северный", string.Empty, StringComparison.InvariantCultureIgnoreCase)
            .Replace("ст химик", string.Empty, StringComparison.InvariantCultureIgnoreCase)
            .Replace("микрорайон удачный", string.Empty, StringComparison.InvariantCultureIgnoreCase)
            .Replace("бугачево", string.Empty, StringComparison.InvariantCultureIgnoreCase)
            .Replace("деревня Минино", string.Empty, StringComparison.InvariantCultureIgnoreCase)
            .Replace("элита", string.Empty, StringComparison.InvariantCultureIgnoreCase)
            //cкобки
            .RemoveInBracketValues()
            //район
            .Replace(DistrictEnum.Okt.GetDescriptionValue(), string.Empty, StringComparison.InvariantCultureIgnoreCase)
            .Replace(DistrictEnum.Jlz.GetDescriptionValue(), string.Empty, StringComparison.InvariantCultureIgnoreCase)
            .Replace(DistrictEnum.Cen.GetDescriptionValue(), string.Empty, StringComparison.InvariantCultureIgnoreCase)
            .Replace(DistrictEnum.Sov.GetDescriptionValue(), string.Empty, StringComparison.InvariantCultureIgnoreCase)
            .Replace(DistrictEnum.Kir.GetDescriptionValue(), string.Empty, StringComparison.InvariantCultureIgnoreCase)
            .Replace(DistrictEnum.Len.GetDescriptionValue(), string.Empty, StringComparison.InvariantCultureIgnoreCase)
            .Replace(DistrictEnum.Sve.GetDescriptionValue(), string.Empty, StringComparison.InvariantCultureIgnoreCase)
            //приставка перед названием улицы
            .Replace("улица", string.Empty, StringComparison.InvariantCultureIgnoreCase)
            .Replace("площадь", string.Empty, StringComparison.InvariantCultureIgnoreCase)
            .Replace("переулок", string.Empty, StringComparison.InvariantCultureIgnoreCase)
            .Replace("сквер", string.Empty, StringComparison.InvariantCultureIgnoreCase)
            .Replace("бульвар", string.Empty, StringComparison.InvariantCultureIgnoreCase)
            .Replace("проезд", string.Empty, StringComparison.InvariantCultureIgnoreCase)
            .Replace("проспект", string.Empty, StringComparison.InvariantCultureIgnoreCase)
            .Replace("микрорайон", string.Empty, StringComparison.InvariantCultureIgnoreCase)
            .Replace("шоссе", string.Empty, StringComparison.InvariantCultureIgnoreCase)
            .Replace("набережная", string.Empty, StringComparison.InvariantCultureIgnoreCase)
            //Улицы двойного названия
            .Replace("Зои Космодемьянской", "Космодемьянской", StringComparison.InvariantCultureIgnoreCase)
            .Replace("Юрия Гагарина", "Гагарина", StringComparison.InvariantCultureIgnoreCase)
            .Replace("Академика Павлова", "Павлова", StringComparison.InvariantCultureIgnoreCase)
            .Replace("Академика Вавилова", "Вавилова", StringComparison.InvariantCultureIgnoreCase)
            .Replace("Анатолия Гладкова", "Гладкова", StringComparison.InvariantCultureIgnoreCase)
            .Replace("Академика Киренского", "Киренского", StringComparison.InvariantCultureIgnoreCase)
            .Replace("Александра Матросова", "Матросова", StringComparison.InvariantCultureIgnoreCase)
            .Replace("Проспект имени Газеты Красноярский Рабочий", "Красноярский рабочий", StringComparison.InvariantCultureIgnoreCase)
            .Replace("имени Газеты Красноярский Рабочий", "Красноярский рабочий", StringComparison.InvariantCultureIgnoreCase)
            .Replace("имени Газеты Пионерская Правда", "Пионерская Правда", StringComparison.InvariantCultureIgnoreCase)
            .Replace("имени Я.М. Свердлова", "Я.М. Свердлова", StringComparison.InvariantCultureIgnoreCase)
            .Replace("Е. Стасовой", "Елены Стасовой", StringComparison.InvariantCultureIgnoreCase)
            //Е - Ё
            .Replace("Алеши Тимошенкова", "Алёши Тимошенкова", StringComparison.InvariantCultureIgnoreCase)
            .Replace("Артемовская", "Артёмовская", StringComparison.InvariantCultureIgnoreCase)
            .Replace("Березовая", "Берёзовая", StringComparison.InvariantCultureIgnoreCase)
            .Replace("Веселая", "Весёлая", StringComparison.InvariantCultureIgnoreCase)
            .Replace("Взлетная", "Взлётная", StringComparison.InvariantCultureIgnoreCase)
            .Replace("Водометный", "Водомётный", StringComparison.InvariantCultureIgnoreCase)
            .Replace("Зеленый", "Зелёный", StringComparison.InvariantCultureIgnoreCase)
            .Replace("Озерная", "Озёрная", StringComparison.InvariantCultureIgnoreCase)
            .Replace("Таежная", "Таёжная", StringComparison.InvariantCultureIgnoreCase)
            .Replace("Черемуховая", "Черёмуховая", StringComparison.InvariantCultureIgnoreCase)
            .Replace("Шелковая", "Шёлковая", StringComparison.InvariantCultureIgnoreCase)
            .Replace("СК Березка-2", "СК Берёзка-2", StringComparison.InvariantCultureIgnoreCase)
            .Replace("СТ Березка", "СТ Берёзка", StringComparison.InvariantCultureIgnoreCase)
            .Replace("СТ Дом матери и ребенка", "СТ Дом матери и ребёнка", StringComparison.InvariantCultureIgnoreCase)
            //Удаляет слово Остров
            .ReplaceIslandWord()
            //Сокращает лишние пробелы
            .NormalizeSpaces()
            .Trim();
    }

    /// <summary>
    /// Заменяет слово остров в многословных улицах на пустую строку
    /// </summary>
    /// <param name="outputText"></param>
    /// <returns></returns>
    private static string ReplaceIslandWord(this string outputText)
    {
        if (outputText.Contains("остров", StringComparison.InvariantCultureIgnoreCase))
        {
            var words = outputText.Split(" ").ToList();
            var islandWord = words.FirstOrDefault(x => x.Equals("остров", StringComparison.InvariantCultureIgnoreCase));
            if (islandWord is not null)
            {
                words.Remove(islandWord!);
                return string.Join(' ', words);
            }
        }

        return outputText;
    }

    /// <summary>
    /// Выставляет количество пробелом равное 1, если пробелов много
    /// </summary>
    /// <param name="outputText"></param>
    /// <returns></returns>
    private static string NormalizeSpaces(this string outputText)
    {
        return Regex.Replace(outputText, @"\s+", " ", RegexOptions.Compiled);
    }


    /// <summary>
    /// Проверяет валидность почтового адреса
    /// </summary>
    /// <param name="emailString"></param>
    /// <returns></returns>
    public static bool IsEmailValid(this string emailString)
    {
        var emailRegex = new Regex(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$", RegexOptions.Compiled);
        return emailRegex.IsMatch(emailString);
    }
    
    /// <summary>
    /// Удаление значений в скобках
    /// </summary>
    /// <param name="text"></param>
    /// <returns></returns>
    public static string RemoveInBracketValues(this string text)
    {
        while (text.Contains("(") && text.Contains(")"))
        {
            var indexOfOpenBracket = text.IndexOf("(");
            var indexOfCloseBracket = text.IndexOf(")");
            if (indexOfOpenBracket == -1 || indexOfCloseBracket == -1)
            {
                return text;
            }
        
            text = text.Remove(indexOfOpenBracket, indexOfCloseBracket - indexOfOpenBracket + 1);
        }

        return text;
    }
}