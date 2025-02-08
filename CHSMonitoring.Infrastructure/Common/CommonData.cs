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
        
}