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
    /// <param name="addressesText"></param>
    internal abstract void AddAddressesList(string addressesText);
    
    /// <summary>
    /// Добавление временных интвервалов работ
    /// </summary>
    /// <param name="dateInfoText"></param>
    internal abstract void AddDateInfo(string dateInfoText);
    
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