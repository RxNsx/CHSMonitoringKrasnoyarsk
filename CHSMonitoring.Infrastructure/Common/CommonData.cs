using CHSMonitoring.Domain.Enums;
using CHSMonitoring.Infrastructure.Extensions;
using CHSMonitoring.Infrastructure.Models.Enums;

namespace CHSMonitoring.Infrastructure.Common;

/// <summary>
/// Класс для хранения общих данных по словарю
/// </summary>
public static class CommonData
{
    /// <summary>
    /// Информация об улицах в формате Id - StreetName
    /// </summary>
    public static List<(Guid Id, string StreetName)> StreetsData 
        => Enum.GetValues(typeof(StreetNameEnum))
            .Cast<StreetNameEnum>()
            .Select(x => (Id: x.GetGuidValue(), StreetName: x.GetDescriptionValue()))
            .ToList();
    
    /// <summary>
    /// Словарь сообщений отключений
    /// </summary>
    public static List<string> PlannedOffData
        => Enum.GetValues(typeof(PlannedSupplyTypeEnum))
            .Cast<PlannedSupplyTypeEnum>()
            .Select(x => x.GetDescriptionValue())
            .ToList();
    
    /// <summary>
    /// Словарь названий районов
    /// </summary>
    public static List<(Guid Id, string DistrictName)> DistrictsData
        => Enum.GetValues(typeof(DistrictEnum))
            .Cast<DistrictEnum>()
            .Select(x => (Id: x.GetGuidValue(), DistrictName: x.GetDescriptionValue()))
            .ToList();
    
    /// <summary>
    /// Словарь типов обслуживания 
    /// </summary>
    public static List<(Guid Id, string ServiceTypeName)> ServiceTypesData
        => Enum.GetValues(typeof(ServiceTypeEnum))
            .Cast<ServiceTypeEnum>()
            .Select(x => (Id: x.GetGuidValue(), ServiceTypeName: x.GetDescriptionValue()))
            .ToList();
}