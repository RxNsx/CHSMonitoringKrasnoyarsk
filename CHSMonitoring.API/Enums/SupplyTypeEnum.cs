﻿using System.ComponentModel;

namespace CHSMonitoring.API.Enums;

/// <summary>
/// Тип снабжения
/// </summary>
public enum ServiceTypeEnum
{
    [Description("Пустой тип снабжения")]
    None,
    [Description("Теплоснабжение")]
    HotWater,
    [Description("Холодное водоснабжение")]
    ColdWater,
    [Description("Электроснабжение")]
    Electricity
}