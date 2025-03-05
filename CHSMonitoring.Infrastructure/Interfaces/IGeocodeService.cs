namespace CHSMonitoring.Infrastructure.Interfaces;

/// <summary>
/// Интерфейс сервиса получения геоданных
/// </summary>
public interface IGeocodeService
{
    /// <summary>
    /// Получить геолокацию по адресам отключений
    /// </summary>
    /// <param name="districtId"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<List<(string StreetName, string Latitude, string LongTitude, string ServiceTypeName)>> GetServiceAddressGeoDataAsync(string districtId, CancellationToken cancellationToken);
}