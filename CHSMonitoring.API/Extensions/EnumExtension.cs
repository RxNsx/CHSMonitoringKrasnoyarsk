using System.ComponentModel;

namespace CHSMonitoring.API.Extensions;

/// <summary>
/// Расширение для enum
/// </summary>
public static class EnumExtension
{
    /// <summary>
    /// Получить описание из аттрибута enum
    /// </summary>
    /// <param name="value"></param>
    /// <returns></returns>
    public static string GetDescriptionValue(this Enum value)
    {
        var field = value.GetType().GetField(value.ToString());
        var attributes = field.GetCustomAttributes(typeof(DescriptionAttribute), false);
        return ((DescriptionAttribute)attributes[0]).Description;
    }
}