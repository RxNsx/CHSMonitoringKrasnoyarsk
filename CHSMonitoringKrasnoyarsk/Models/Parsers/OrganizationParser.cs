using CHSMonitoringKrasnoyarsk.Enums;
using CHSMonitoringKrasnoyarsk.Extensions;
using CHSMonitoringKrasnoyarsk.Models.SupplyDescription;

namespace CHSMonitoringKrasnoyarsk.Models.Parsers;

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
        var supplyTypeEnums = Enum.GetValues(typeof(SupplyTypeEnum))
            .Cast<SupplyTypeEnum>()
            .Select(x => x.GetDescriptionValue())
            .ToList();
        
        var supplyTextDescription = supplyTypeEnums.FirstOrDefault(x => organizationText.Contains(x));
        if (supplyTextDescription is null)
        {
            throw new ArgumentNullException(nameof(supplyTextDescription), "supplyTypeDescription");
        }

        string supplyTypeName;
        string telephoneText;
        string organizationName;
        SupplyTypeEnum supplyTypeEnum;

        try
        {
            //Название типа обеспечения
            var indexOfSupplyEnumItem = organizationText.IndexOf(supplyTextDescription, StringComparison.InvariantCultureIgnoreCase);
            var supplyNameText = organizationText.Substring(indexOfSupplyEnumItem, supplyTextDescription.Length);
            var lastTextWithoutSupplyName = organizationText.Remove(indexOfSupplyEnumItem, supplyTextDescription.Length).Trim();

            //Номер телефона
            var telephoneTextIndex = lastTextWithoutSupplyName.IndexOf("т.", StringComparison.InvariantCultureIgnoreCase);
            telephoneText = lastTextWithoutSupplyName.Substring(telephoneTextIndex, lastTextWithoutSupplyName.Length - telephoneTextIndex);
            organizationName = lastTextWithoutSupplyName.Remove(telephoneTextIndex, lastTextWithoutSupplyName.Length - telephoneTextIndex).Trim();
            
            //Получение названия типа обслуживания
            supplyTypeName = supplyTypeEnums.FirstOrDefault(x => supplyNameText.Contains(x, StringComparison.InvariantCultureIgnoreCase));
            //Получение названия типа обслуживания как Enum
            supplyTypeEnum = Enum.GetValues(typeof(SupplyTypeEnum))
                .Cast<SupplyTypeEnum>()
                .FirstOrDefault(x => x.GetDescriptionValue().Contains(supplyTypeName, StringComparison.InvariantCultureIgnoreCase));
        }
        catch (Exception ex)
        {
            throw new Exception($"ParseOrganization Exception: {ex.Message}");
        }
        
        return Organization.Create(supplyTypeEnum, supplyTypeName, organizationName, telephoneText);
    }
}