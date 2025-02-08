using CHSMonitoring.Infrastructure.Extensions;

namespace CHSMonitoringTests.Unit;

public class ExtensionsTest
{
    [Theory]
    [MemberData(nameof(ReplaceBracketsData))]
    public void ReplaceBrackets_Should_Return_NumbersListWithoutBracketValues(List<string> input, List<string> expected)
    {
        var result = StringListExtensions.RemoveInBracketValues(input);
        Assert.True(result.SequenceEqual(expected, StringComparer.InvariantCultureIgnoreCase));
    }
    
    public static IEnumerable<object[]> ReplaceBracketsData()
    {
        yield return new object[] { new List<string>() { "22а(школа)"}, new List<string>() { "22а" }};
        yield return new object[] { new List<string>() {}, new List<string> {}};
    }


    [Theory]
    [MemberData(nameof(ReplaceStSymbolsData))]
    public void ReplaceStSymbolsInNumbers_Should_Return_NumbersListWithoutStSymbols(List<string> input, List<string> expected)
    {
        var result = StringListExtensions.ReplaceStSymbolsInNumbers(input);
        Assert.True(result.SequenceEqual(expected, StringComparer.InvariantCultureIgnoreCase));
    }
    
    
    public static IEnumerable<object[]> ReplaceStSymbolsData()
    {
        yield return new object[] { new List<string>() { "32ст", "33с.", "33 ст1", "34 ст" }, new List<string>() { "32с", "33с", "33 с1", "34 с"}};
        yield return new object[] { new List<string>() {}, new List<string> {}};
    }
}