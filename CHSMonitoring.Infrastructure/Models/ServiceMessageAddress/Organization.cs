using CHSMonitoring.Domain.Enums;

namespace CHSMonitoring.Infrastructure.Models.ServiceMessageAddress;

/// <summary>
/// Организация обслуживающая отключение
/// </summary>
public class Organization
{
    /// <summary>
    /// Тип обслуживания
    /// </summary>
    public ServiceTypeEnum ServiceTypeEnum { get; private set; }
    /// <summary>
    /// Название типа обслуживания
    /// </summary>
    public string SupplyTypeName { get; private set; }
    /// <summary>
    /// Название организации
    /// </summary>
    public string Name { get; private set; }
    /// <summary>
    /// Телефон организации
    /// </summary>
    public string Telephone { get; private set; }

    /// <summary>
    /// Конструктор
    /// </summary>
    /// <param name="serviceTypeEnum"></param>
    /// <param name="supplyTypeName"></param>
    /// <param name="name"></param>
    /// <param name="telephone"></param>
    private Organization(ServiceTypeEnum serviceTypeEnum, string supplyTypeName, string name, string telephone)
    {
        ServiceTypeEnum = serviceTypeEnum;
        SupplyTypeName = supplyTypeName;
        Name = name;
        Telephone = telephone;
    }

    /// <summary>
    /// Фабричный метод для создания организации
    /// </summary>
    /// <param name="serviceTypeEnum"></param>
    /// <param name="supplyTypeName"></param>
    /// <param name="name"></param>
    /// <param name="telephone"></param>
    /// <returns></returns>
    public static Organization Create(ServiceTypeEnum serviceTypeEnum, string supplyTypeName, string name, string telephone)
    {
        return new Organization(serviceTypeEnum, supplyTypeName, name, telephone);
    }
}