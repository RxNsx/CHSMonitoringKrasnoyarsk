using CHSMonitoringKrasnoyarsk.Enums;
using CHSMonitoringKrasnoyarsk.Models.SupplyDescription;

namespace CHSMonitoringKrasnoyarsk.Extensions;

public static class ListExtensions
{
    /// <summary>
    /// Получение организации из списка данных
    /// </summary>
    /// <param name="targetList"></param>
    /// <returns></returns>
    public static Organization CreateOrganizationFromList(this List<string> targetList)
    {
        const string electricity = "Электроснабжение";
        const string hotwater = "Теплоснабжение";
        const string coldwater = "Холодное водоснабжение";
        
        var supplyTypeString = targetList[0];
        var supplyTypeEnum = SupplyTypeEnum.None;

        if (supplyTypeString.Equals(electricity, StringComparison.InvariantCultureIgnoreCase))
        {
            supplyTypeEnum = SupplyTypeEnum.Electricity;
        }
        if (supplyTypeString.Equals(hotwater, StringComparison.InvariantCultureIgnoreCase))
        {
            supplyTypeEnum = SupplyTypeEnum.HotWater;
        }
        if (supplyTypeString.Equals(coldwater, StringComparison.InvariantCultureIgnoreCase))
        {
            supplyTypeEnum = SupplyTypeEnum.ColdWater;
        }

        var organizationName = targetList[1];
        if (string.IsNullOrEmpty(organizationName))
        {
            throw new ArgumentNullException(nameof(organizationName), "Название организации не может быть пустым");
        }

        var organizationTelephone = targetList[2];
        if (string.IsNullOrEmpty(organizationTelephone))
        {
            throw new ArgumentNullException(nameof(organizationTelephone), "Телефон организации не может быть пустым");
        }
        
        return Organization.Create(supplyTypeEnum, organizationName, organizationTelephone);
    }
}