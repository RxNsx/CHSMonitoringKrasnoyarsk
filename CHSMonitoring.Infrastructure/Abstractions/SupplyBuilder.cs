using CHSMonitoring.Infrastructure.Models.ServiceMessageAddress;

namespace CHSMonitoring.Infrastructure.Abstractions;

/// <summary>
/// Строитель паттерн для ServiceMessage
/// </summary>
public abstract class ServiceBuilder
{
    /// <summary>
    /// Получение организации
    /// </summary>
    /// <param name="organizationText"></param>
    internal abstract void BuildOrganization(string organizationText);

    /// <summary>
    /// Добавление списка адресов
    /// </summary>
    /// <param name="addressList"></param>
    internal abstract void AddAddressesList(List<Address> addressList);

    /// <summary>
    /// Добавляет описание к сообщениям отключения
    /// </summary>
    /// <param name="description"></param>
    internal abstract void AddDescription(string description);

    /// <summary>
    /// Добавление временных интвервалов работ
    /// </summary>
    /// <param name="dateInfoText"></param>
    /// <param name="createdDate"></param>
    internal abstract void AddDateInfo(string dateInfoText, DateTime createdDate);
    
    /// <summary>
    /// Добавление значения имени района
    /// </summary>
    /// <param name="districtName"></param>
    internal abstract void AddDistrictName(string districtName);
    
    /// <summary>
    /// Сборка объекта полностью
    /// </summary>
    /// <returns></returns>
    internal abstract ServiceMessage BuildServiceAddressMessage();
}