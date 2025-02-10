using CHSMonitoring.Domain.Enums;
using CHSMonitoring.Infrastructure.Common;
using CHSMonitoring.Infrastructure.Extensions;
using CHSMonitoring.Infrastructure.Models.ServiceMessageAddress;

namespace CHSMonitoring.Infrastructure.Parsers;

/// <summary>
/// Парсер организации
/// </summary>
public static class OrganizationParser
{
    /// <summary>
    /// Получить организацию из строки
    /// </summary>
    /// <param name="organizationText"></param>
    /// <returns></returns>
    public static Organization ParseOrganization(string organizationText)
    {
        var supplyTextDescription = CommonData.ServiceTypesData
            .FirstOrDefault(x => organizationText.Contains(x.ServiceTypeName, StringComparison.InvariantCultureIgnoreCase));
        if (supplyTextDescription.Id != Guid.Empty)
        {
            throw new ArgumentNullException(nameof(supplyTextDescription), "supplyTypeDescription");
        }

        string serviceTypeName;
        var telephoneText = string.Empty;
        var organizationName = string.Empty;
        var serviceTypeEnum = ServiceTypeEnum.None;

        try
        {
            //Название типа обеспечения
            var indexOfSupplyEnumItem = organizationText.IndexOf(supplyTextDescription.ServiceTypeName, StringComparison.InvariantCultureIgnoreCase);
            serviceTypeName = organizationText.Substring(indexOfSupplyEnumItem, supplyTextDescription.ServiceTypeName.Length);
            var lastTextWithoutSupplyName = organizationText.Remove(indexOfSupplyEnumItem, supplyTextDescription.ServiceTypeName.Length).Trim();

            //Номер телефона
            var telephoneTextIndex = lastTextWithoutSupplyName.IndexOf("т.", StringComparison.InvariantCultureIgnoreCase);
            if (telephoneTextIndex != -1)
            {
                telephoneText = lastTextWithoutSupplyName.Substring(telephoneTextIndex, lastTextWithoutSupplyName.Length - telephoneTextIndex);
                organizationName = lastTextWithoutSupplyName.Remove(telephoneTextIndex, lastTextWithoutSupplyName.Length - telephoneTextIndex).Trim();
            }
            
            //Получение названия типа обслуживания
            serviceTypeName = CommonData.ServiceTypesData.FirstOrDefault(x => serviceTypeName.Contains(x.ServiceTypeName, StringComparison.InvariantCultureIgnoreCase)).ServiceTypeName;
            //Получение названия типа обслуживания как Enum
            serviceTypeEnum = Enum.GetValues(typeof(ServiceTypeEnum))
                .Cast<ServiceTypeEnum>()
                .FirstOrDefault(x => x.GetDescriptionValue().Contains(serviceTypeName, StringComparison.InvariantCultureIgnoreCase));
        }
        catch (Exception ex)
        {
            throw new Exception($"ParseOrganization Exception: {ex.Message}");
        }
        
        return Organization.Create(serviceTypeEnum, serviceTypeName, organizationName, telephoneText);
    }
}