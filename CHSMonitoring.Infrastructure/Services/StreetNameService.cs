using System.Text;
using CHSMonitoring.Infrastructure.Extensions;
using CHSMonitoring.Infrastructure.Interfaces;
using CHSMonitoring.Infrastructure.Models.Enums;

namespace CHSMonitoring.Infrastructure.Services;

/// <summary>
/// Сервис получения имени улицы
/// </summary>
public class StreetNameService : IStreetNameService
{
    public string GetStreetNameFromHtmlDocument(string htmlStreetName)
    {
        var enumStreetNames = Enum.GetValues(typeof(StreetNameEnum))
            .Cast<StreetNameEnum>()
            .Select(x => new
            {
                Id = x.GetGuidValue(),
                Description = x.GetDescriptionValue()
            })
            .ToList();
        
        ///Получаем улицу из общего словаря
        var enumStreetCount = enumStreetNames
            .Where(x => htmlStreetName.Contains(x.Description, StringComparison.InvariantCultureIgnoreCase))
            .ToList();

        if (enumStreetCount.Count == 1)
        {
            var equals = enumStreetCount
                .Where(x => x.Description.Equals(htmlStreetName, StringComparison.InvariantCultureIgnoreCase))
                .ToList();

            return equals.FirstOrDefault().Description;
        }
        else if (enumStreetCount.Count > 1)
        {
            var sb = new StringBuilder();
            foreach (var symbol in htmlStreetName)
            {
                sb.Append(symbol);

                var matchStreet = enumStreetCount.FirstOrDefault(x => x.Description.Equals(sb.ToString(), StringComparison.InvariantCultureIgnoreCase));
                if (matchStreet is not null)
                {
                    if (!matchStreet.Description.Equals(htmlStreetName, StringComparison.InvariantCultureIgnoreCase))
                    {
                        enumStreetCount.Remove(matchStreet);
                        continue;
                    }
                    
                    return matchStreet.Description;
                }
            }
        }

        return string.Empty;
    }
}