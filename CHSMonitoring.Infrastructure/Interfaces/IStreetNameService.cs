namespace CHSMonitoring.Infrastructure.Interfaces;

/// <summary>
/// Интерфейс получение имени улицы
/// </summary>
public interface IStreetNameService
{
    Guid? GetStreetNameFromHtmlDocument(string streetName);
}