using System.ComponentModel;

namespace CHSMonitoringKrasnoyarsk.Enums;

public enum District
{
    [Description("Октябрьский район")]
    Okt = 1,
    [Description("Железнодорожный район")]
    Jlz = 2,
    [Description("Центральный район")]
    Cen = 3,
    [Description("Советский район")]
    Sov = 4,
    [Description("Ленинский район")]
    Len = 5,
    [Description("Кировский район")]
    Kir = 6,
    [Description("Свердловский район")]
    Sve = 7
}