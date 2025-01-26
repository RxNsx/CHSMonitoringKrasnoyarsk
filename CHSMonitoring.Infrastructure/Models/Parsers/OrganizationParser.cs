using CHSMonitoring.Infrastructure.Extensions;
using CHSMonitoring.Infrastructure.Models.Enums;
using CHSMonitoring.Infrastructure.Models.ServiceMessageAddress;

namespace CHSMonitoring.Infrastructure.Models.Parsers;

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
        var serviceTypeEnums = Enum.GetValues(typeof(ServiceTypeEnum))
            .Cast<ServiceTypeEnum>()
            .Select(x => x.GetDescriptionValue())
            .ToList();
        
        var supplyTextDescription = serviceTypeEnums.FirstOrDefault(x => organizationText.Contains(x));
        if (supplyTextDescription is null)
        {
            throw new ArgumentNullException(nameof(supplyTextDescription), "supplyTypeDescription");
        }

        var serviceTypeName = string.Empty;
        var telephoneText = string.Empty;
        var organizationName = string.Empty;
        var serviceTypeEnum = ServiceTypeEnum.None;

        try
        {
            //Название типа обеспечения
            var indexOfSupplyEnumItem = organizationText.IndexOf(supplyTextDescription, StringComparison.InvariantCultureIgnoreCase);
            serviceTypeName = organizationText.Substring(indexOfSupplyEnumItem, supplyTextDescription.Length);
            var lastTextWithoutSupplyName = organizationText.Remove(indexOfSupplyEnumItem, supplyTextDescription.Length).Trim();

            //Номер телефона
            var telephoneTextIndex = lastTextWithoutSupplyName.IndexOf("т.", StringComparison.InvariantCultureIgnoreCase);

            if (telephoneTextIndex != -1)
            {
                telephoneText = lastTextWithoutSupplyName.Substring(telephoneTextIndex, lastTextWithoutSupplyName.Length - telephoneTextIndex);
                organizationName = lastTextWithoutSupplyName.Remove(telephoneTextIndex, lastTextWithoutSupplyName.Length - telephoneTextIndex).Trim();
            }
            
            //Получение названия типа обслуживания
            serviceTypeName = serviceTypeEnums.FirstOrDefault(x => serviceTypeName.Contains(x, StringComparison.InvariantCultureIgnoreCase));
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