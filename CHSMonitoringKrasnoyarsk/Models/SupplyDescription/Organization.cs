using CHSMonitoringKrasnoyarsk.Enums;

namespace CHSMonitoringKrasnoyarsk.Models.SupplyDescription;

/// <summary>
/// Организация обслуживающая отключение
/// </summary>
public class Organization
{
    public SupplyTypeEnum SupplyTypeEnum { get; private set; }
    public string Name { get; private set; }
    public string Telephone { get; private set; }

    private Organization(SupplyTypeEnum supplyTypeEnum, string name, string telephone)
    {
        SupplyTypeEnum = supplyTypeEnum;
        Name = name;
        Telephone = telephone;
    }

    public static Organization Create(SupplyTypeEnum supplyTypeEnum, string name, string telephone)
    {
        return new Organization(supplyTypeEnum, name, telephone);
    }
}