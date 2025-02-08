using CHSMonitoring.Infrastructure.Interfaces;
using CHSMonitoring.Infrastructure.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Moq;

namespace CHSMonitoringTests.Unit;

public class GetStreetNameTest
{
    [Theory]
    [MemberData(nameof(GetStreetNameData))]
    public void GetStreetName_Should_Return_CorrectStreetName(string initial, string expected)
    {
        var scopeMock = new Mock<IServiceScope>();
        var scopeFactoryMock = new Mock<IServiceScopeFactory>();
        scopeFactoryMock.Setup(sf => sf.CreateScope()).Returns(scopeMock.Object);

        var loggerFactoryMock = new Mock<ILoggerFactory>();
        var streetRepositoryMock = new Mock<IStreetRepository>();
        var serviceProviderMock = new Mock<IServiceProvider>();

        serviceProviderMock.Setup(sp => sp.GetService(typeof(IStreetRepository))).Returns(streetRepositoryMock.Object);
        scopeMock.Setup(s => s.ServiceProvider).Returns(serviceProviderMock.Object);

        var addressParserService = new AddressParserService(scopeFactoryMock.Object, loggerFactoryMock.Object);
        var result = addressParserService.GetStreetName(initial);
        Assert.Equal(expected, result);
    }

    public static IEnumerable<object[]> GetStreetNameData()
    {
        yield return new object[] { "йцуйц ВРК: Норильская 36", "Норильская" };
        yield return new object[] { "asdsadasd Степана Разина 46,144,45,148/1ий", "Степана Разина" };
        yield return new object[] { "Бадалыкская", "Бадалыкская" };
        yield return new object[] { "7-я Полярная", "7-я Полярная" };
        yield return new object[] { "Бадалыкская 1а, 164и/1", "Бадалыкская" };
        yield return new object[] { "йцуйц ВРК: Несуществующая улица", string.Empty };
        yield return new object[] { "ч/сектор +ВРК: Норильская", "Норильская" };
        yield return new object[] { "2-я Ботаническая 1а,15а,14а,16а", "2-я Ботаническая" };
        yield return new object[] { "40 лет Победы 12", "40 лет Победы" };
        yield return new object[] { "Серова", "Серова" };
        yield return new object[] { "2-я Камчатская 15", "2-я Камчатская" };
        yield return new object[] { "Вокзальная", "Вокзальная" };
        yield return new object[] { string.Empty, string.Empty };
    }
}