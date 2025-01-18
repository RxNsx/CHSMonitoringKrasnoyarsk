using CHSMonitoring.API.Enums;

namespace CHSMonitoring.API.Models.SupplyMessageDescription;

/// <summary>
/// Организация обслуживающая отключение
/// </summary>
public class Organization
{
    public SupplyTypeEnum SupplyTypeEnum { get; private set; }
    public string SupplyTypeName { get; private set; }
    public string Name { get; private set; }
    public string Telephone { get; private set; }

    private Organization(SupplyTypeEnum supplyTypeEnum, string supplyTypeName, string name, string telephone)
    {
        SupplyTypeEnum = supplyTypeEnum;
        SupplyTypeName = supplyTypeName;
        Name = name;
        Telephone = telephone;
    }

    public static Organization Create(SupplyTypeEnum supplyTypeEnum, string supplyTypeName, string name, string telephone)
    {
        return new Organization(supplyTypeEnum, name, supplyTypeName, telephone);
    }
}