using CHSMonitoring.API.Models.SupplyMessageDescription;

namespace CHSMonitoring.API.Abstractions;

/// <summary>
/// Строитель объекта SupplyDescription
/// </summary>
public abstract class SupplyBuilder
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
    /// Сборка объекта полностью
    /// </summary>
    /// <returns></returns>
    internal abstract SupplyMessageDescription BuildSupplyMessageDescription();
}