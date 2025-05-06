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
    Task<List<(string StreetName, string Latitude, string LongTitude, string ServiceTypeName)>> GetServiceAddressGeoDataByDistrictAsync(string districtId, CancellationToken cancellationToken);
    
    
    /// <summary>
    /// Получение геолокаций по названию улицы
    /// </summary>
    /// <param name="streetId"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<List<(string StreetName, string Latitude, string LongTitude, string ServiceTypeName)>> GetServiceAddressGeoDataByStreetNameAsync(string streetId, CancellationToken cancellationToken);
}