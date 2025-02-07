namespace CHSMonitoring.Infrastructure.Interfaces;

/// <summary>
/// Интерфейс получение имени улицы
/// </summary>
public interface IStreetNameService
{
    string GetStreetNameFromHtmlDocument(string streetName);
}