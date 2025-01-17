using System.ComponentModel;

namespace CHSMonitoringKrasnoyarsk.Enums;

/// <summary>
/// Виды сообщений о планировании
/// </summary>
public enum PlannedSupplyTypeEnum
{
    [Description("Запланированные")]
    Planned,
    [Description("Плановое")]
    Planned2,
    [Description("Информация о плановых отключениях")]
    Planned3,
    [Description("Аварийное")]
    Emergency,
    [Description("Подвоз")]
    Subway,
    // [Description("Городских отключений не зарегистрировано")]
    // NotRegistered
}