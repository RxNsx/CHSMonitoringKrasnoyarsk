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
    /// Получение списка адресов
    /// </summary>
    /// <param name="addressesText"></param>
    internal abstract void BuildAddressesList(string addressesText);
    
    /// <summary>
    /// Получение временных интвервалов работ
    /// </summary>
    /// <param name="dateInfoText"></param>
    internal abstract void BuildDateInfo(string dateInfoText);
    
    /// <summary>
    /// Установить значение имени района
    /// </summary>
    /// <param name="districtName"></param>
    internal abstract void BuildDistrictName(string districtName);
    
    /// <summary>
    /// Сборка объекта полностью
    /// </summary>
    /// <returns></returns>
    internal abstract ServiceMessage BuildSupplyMessageDescription();
}