using System.ComponentModel;

namespace CHSMonitoring.Infrastructure.Models.Enums;

/// <summary>
/// Виды сообщений о планировании
/// </summary>
public enum PlannedSupplyTypeEnum
{
    [Description("Запланированные отключения на завтра")]
    Planned,
    [Description("Информация о плановых отключениях")]
    Planned2,
    [Description("Плановое")]
    Planned3,
    [Description("Аварийное")]
    Emergency,
    [Description("Подвоз")]
    Subway,
    // [Description("Городских отключений не зарегистрировано")]
    // NotRegistered
}