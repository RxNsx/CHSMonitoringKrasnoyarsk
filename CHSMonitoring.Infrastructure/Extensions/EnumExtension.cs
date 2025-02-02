﻿using System.ComponentModel;
using System.Reflection;
using CHSMonitoring.Infrastructure.Attributes;

namespace CHSMonitoring.Infrastructure.Extensions;

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
        var attribute = field.GetCustomAttribute(typeof(DescriptionAttribute), false);
        return ((DescriptionAttribute)attribute).Description;
    }

    /// <summary>
    /// Получить значение Guid из аттрибута enum
    /// </summary>
    /// <param name="value"></param>
    /// <returns></returns>
    public static Guid GetGuidValue(this Enum value)
    {
        var field = value.GetType().GetField(value.ToString());
        var attribute = field.GetCustomAttribute(typeof(EnumGuidAttribute), false);
        return ((EnumGuidAttribute)attribute).GuidValue;

    }
}