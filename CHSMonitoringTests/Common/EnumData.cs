using CHSMonitoring.Infrastructure.Extensions;
using CHSMonitoring.Infrastructure.Models.Enums;

namespace CHSMonitoringTests.Common;

public static class EnumData
{
    public static List<(Guid Id, string StreetName)> StreetData 
        => Enum.GetValues(typeof(StreetNameEnum))
            .Cast<StreetNameEnum>()
            .Select(x => (Id: x.GetGuidValue(), StreetName: x.GetDescriptionValue()))
            .ToList();
}