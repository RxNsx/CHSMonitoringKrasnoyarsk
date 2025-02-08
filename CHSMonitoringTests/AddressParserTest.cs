using System.Runtime.Serialization;
using System.Text;
using CHSMonitoringTests.Common;

namespace CHSMonitoringTests;

public class AddressParserTest
{
    [Theory]
    [MemberData(nameof(GetResultStreetNameData))]
    public void GetResultName_Should_Return_CorrectStreetName(string initial, string expected)
    {
        var result = GetResultStreetName(initial);
        Assert.Equal(expected, result);
    }

    public static IEnumerable<object[]> GetResultStreetNameData()
    {
        yield return new object[] {"йцуйц ВРК: Норильская 36", "Норильская"};
        yield return new object[] {"asdsadasd Степана Разина 46,144,45,148/1ий", "Степана Разина"};
        yield return new object[] {"Бадалыкская", "Бадалыкская"};
        yield return new object[] {"йцуйц ВРК: Несуществующая улица", string.Empty};
        yield return new object[] {"ч/сектор +ВРК: Норильская", "Норильская"};
        yield return new object[] {string.Empty, string.Empty};
    }
    
    private string GetResultStreetName(string addressItem)
    {
        ///Получаем улицу из общего словаря
        var matchStreetCount = EnumData.StreetData
            .Where(x => addressItem.Contains(x.StreetName, StringComparison.InvariantCultureIgnoreCase))
            .ToList();

        if (matchStreetCount.Any())
        {
            var index = matchStreetCount
                .Select(x => addressItem.IndexOf(x.StreetName, StringComparison.InvariantCultureIgnoreCase))
                .Min();
            var strictedAddressItem = addressItem.Substring(index, addressItem.Length - index);
            
            if (matchStreetCount.Count == 1)
            {
                var value = matchStreetCount.FirstOrDefault(x => strictedAddressItem.Contains(x.StreetName, StringComparison.InvariantCultureIgnoreCase));
                return value.StreetName;
            }
            else if (matchStreetCount.Count > 1)
            {
                var sb = new StringBuilder();
                foreach (var symbol in strictedAddressItem)
                {
                    sb.Append(symbol);

                    var matchStreet = matchStreetCount.FirstOrDefault(x => x.StreetName.Equals(sb.ToString(), StringComparison.InvariantCultureIgnoreCase));
                    if (matchStreet.Id != Guid.Empty)
                    {
                        if (!matchStreet.StreetName.Equals(strictedAddressItem, StringComparison.InvariantCultureIgnoreCase))
                        {
                            matchStreetCount.Remove(matchStreet);
                            continue;
                        }

                        return matchStreet.StreetName;
                    }
                }
            }
        }

        return string.Empty;
    }
}