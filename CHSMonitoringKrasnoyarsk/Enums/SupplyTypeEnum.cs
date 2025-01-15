using System.ComponentModel;

namespace CHSMonitoringKrasnoyarsk.Enums;

/// <summary>
/// Тип снабжения
/// </summary>
public enum SupplyTypeEnum
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