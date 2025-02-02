using System.ComponentModel;
using CHSMonitoring.Infrastructure.Attributes;

namespace CHSMonitoring.Infrastructure.Models.Enums;

/// <summary>
/// Название районов
/// </summary>
public enum DistrictEnum
{
    [EnumGuid("E137A377-6281-4074-BA80-E7460C328354")]
    [Description("Октябрьский район")]
    Okt = 1,
    [EnumGuid("590B4A73-E859-4FFD-A544-23C5DD012760")]
    [Description("Железнодорожный район")]
    Jlz = 2,
    [EnumGuid("07432E9E-C030-4676-9CFE-438D8C76FFCF")]
    [Description("Центральный район")]
    Cen = 3,
    [EnumGuid("1439FFC7-FE1E-4EFF-89B9-8ED6EF9DD323")]
    [Description("Советский район")]
    Sov = 4,
    [EnumGuid("EC99DB28-33A9-4526-B790-C4EDCB44955F")]
    [Description("Ленинский район")]
    Len = 5,
    [EnumGuid("215A4634-5671-49A3-8563-7B9A8E9DEA10")]
    [Description("Кировский район")]
    Kir = 6,
    [EnumGuid("224359E3-827D-4C2D-95BE-E496418966E0")]
    [Description("Свердловский район")]
    Sve = 7
}