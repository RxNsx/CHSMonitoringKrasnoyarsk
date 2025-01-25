using CHSMonitoring.Infrastructure.Models.Enums;

namespace CHSMonitoring.Infrastructure.Models.ServiceMessageAddress;

/// <summary>
/// Организация обслуживающая отключение
/// </summary>
public class Organization
{
    public ServiceTypeEnum SupplyTypeEnum { get; private set; }
    public string SupplyTypeName { get; private set; }
    public string Name { get; private set; }
    public string Telephone { get; private set; }

    private Organization(ServiceTypeEnum serviceTypeEnum, string supplyTypeName, string name, string telephone)
    {
        SupplyTypeEnum = serviceTypeEnum;
        SupplyTypeName = supplyTypeName;
        Name = name;
        Telephone = telephone;
    }

    public static Organization Create(ServiceTypeEnum serviceTypeEnum, string supplyTypeName, string name, string telephone)
    {
        return new Organization(serviceTypeEnum, name, supplyTypeName, telephone);
    }
}