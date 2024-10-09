using System.ComponentModel;

namespace CHSMonitoringKrasnoyarsk.Enums;

public enum District
{
    [Description("Октябрьский")]
    Okt = 1,
    [Description("Железнодорожный")]
    Jlz = 2,
    [Description("Центральный")]
    Cen = 3,
    [Description("Советский")]
    Sov = 4,
    [Description("Ленинский")]
    Len = 5,
    [Description("Кировский")]
    Kir = 6,
    [Description("Свердловский")]
    Sve = 7
}