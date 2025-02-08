namespace CHSMonitoring.Infrastructure.Extensions;

public static class StringListExtensions
{
    /// <summary>
    /// Заменить символы в строке номеров
    /// Излишняя информация
    /// </summary>
    /// <param name="numbers"></param>
    /// <returns></returns>
    public static List<string> RemoveInBracketValues(this List<string> numbers)
    {
        for (var i = 0; i < numbers.Count; i++)
        {
            if (numbers[i].Contains("(") && numbers[i].Contains(")"))
            {
                var indexOfOpenBracket = numbers[i].IndexOf("(");
                var indexOfCloseBracket = numbers[i].IndexOf(")");
                if (indexOfOpenBracket == -1 || indexOfCloseBracket == -1)
                {
                    continue;
                }
                numbers[i] = numbers[i].Remove(indexOfOpenBracket, indexOfCloseBracket - indexOfOpenBracket + 1);
            }
        }

        return numbers;
    }
    
    /// <summary>
    /// Заменяет символы в строке c (ст, ст.) на (с)
    /// Для того чтобы корректно сохранять адрес для парсинга на яндекс картах
    /// </summary>
    /// <param name="numbers"></param>
    /// <returns></returns>
    public static List<string> ReplaceStSymbolsInNumbers(this List<string> numbers)
    {
        for (var i = 0; i < numbers.Count; i++)
        {
            if (numbers[i].Contains("ст", StringComparison.InvariantCultureIgnoreCase))
            {
                numbers[i] = numbers[i].Replace("ст", "с", StringComparison.InvariantCultureIgnoreCase);
            }
            if (numbers[i].Contains("ст.", StringComparison.InvariantCultureIgnoreCase))
            {
                numbers[i] = numbers[i].Replace("ст.", "с", StringComparison.InvariantCultureIgnoreCase);
            }
            if(numbers[i].Contains("с.", StringComparison.InvariantCultureIgnoreCase))
            {
                numbers[i] = numbers[i].Replace("с.", "с", StringComparison.InvariantCultureIgnoreCase);
            }
        }

        return numbers;
    }
    
    /// <summary>
    /// Заменяет вхождения где буква Е должна быть буквой Ё
    /// </summary>
    /// <param name="addresses"></param>
    /// <returns></returns>
    public static List<string> ReplaceAddresesLetters(this List<string> addresses)
    {
        var replaceAddresses = new List<(string original, string replaceAddress)>()
        {
            new("Алеши Тимошенкова", "Алёши Тимошенкова"),
            new("Артемовская", "Артёмовская"),
            new("Березовая", "Берёзовая"),
            new("Веселая", "Весёлая"),
            new("Взлетная", "Взлётная"),
            new("Водометный", "Водомётный"),
            new("Зеленый", "Зелёный"),
            new("Озерная", "Озёрная"),
            new("Таежная", "Таёжная"),
            new("Черемуховая", "Черёмуховая"),
            new("Шелковая", "Шёлковая"),
            new("СК Березка-2", "СК Берёзка-2"),
            new("СТ Березка", "СТ Берёзка"),
            new("СТ Дом матери и ребенка", "СТ Дом матери и ребёнка"),
        };
        
        for (var i = 0; i < addresses.Count; i ++)
        {
            foreach (var replacement in replaceAddresses)
            {
                if (addresses[i].Contains(replacement.original))
                {
                    addresses[i] = addresses[i].Replace(replacement.original, replacement.replaceAddress);
                }
            }
        }

        return addresses;
    }
}