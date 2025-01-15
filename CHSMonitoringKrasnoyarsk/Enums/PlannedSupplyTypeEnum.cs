using System.ComponentModel;

namespace CHSMonitoringKrasnoyarsk.Enums;

/// <summary>
/// Виды сообщений о планировании
/// </summary>
public enum PlannedSupplyTypeEnum
{
    [Description("Запланированные")]
    Planned,
    // [Description("Городских отключений не зарегистрировано")]
    // NotRegistered
}