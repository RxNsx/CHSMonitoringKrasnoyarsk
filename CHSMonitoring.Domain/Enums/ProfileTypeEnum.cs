using System.ComponentModel;
using CHSMonitoring.Infrastructure.Attributes;

namespace CHSMonitoring.Domain.Enums;

/// <summary>
/// Тип профиля
/// </summary>
public enum ProfileTypeEnum
{
    [EnumGuid("BEB48463-0AB9-44A6-AF26-511D45EA65C1")]
    [Description("Профиль для веб приложения")]
    WebApplication = 1,
    [EnumGuid("7ABA0455-A29B-41E6-9C38-1173FFC83FE0")]
    [Description("Профиль для телеграма")]
    Telegram = 2
}