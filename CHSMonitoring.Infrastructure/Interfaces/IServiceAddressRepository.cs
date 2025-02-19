using System.Collections.Immutable;
using CHSMonitoring.Domain.Entities;

namespace CHSMonitoring.Infrastructure.Interfaces;

/// <summary>
/// Интерфейс для упраления обслуживающими адресами
/// </summary>
public interface IServiceAddressRepository
{
    /// <summary>
    /// Получить последние события обслуживания
    /// </summary>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<List<ServiceAddress>> GetLatestServiceAddressAsync(CancellationToken cancellationToken);

    /// <summary>
    /// Получить последние события отключения по району
    /// </summary>
    /// <param name="districtId"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<List<ServiceAddress>> GetLatestServiceAddressByDistrictAsync(Guid districtId, CancellationToken cancellationToken);
    
    /// <summary>
    /// Получить список событий обслуживания адреса
    /// </summary>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<List<ServiceAddress>> GetServiceAddressesAsynс(CancellationToken cancellationToken);

    /// <summary>
    /// Получить список отключений по названию улиц
    /// </summary>
    /// <param name="streetName"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<List<ServiceAddress>> GetServiceAddressesAsync(List<string> streetName, CancellationToken cancellationToken);

    /// <summary>
    /// Добавить список событий обслуживания адреса
    /// </summary>
    /// <param name="serviceAddresses"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task AddServiceAddressesAsync(List<ServiceAddress> serviceAddresses, CancellationToken cancellationToken);

    /// <summary>
    /// Получить конкретное событие обслуживания адреса
    /// </summary>
    /// <param name="streetName"></param>
    /// <param name="houseNumber"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<ServiceAddress?> GetServiceAddressAsync(string streetName, string houseNumber, CancellationToken cancellationToken);

    /// <summary>
    /// Проверка существования события обслуживания в базе
    /// </summary>
    /// <param name="streetName"></param>
    /// <param name="houseNumber"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<bool> IsExistServiceAddressAsync(string streetName, string houseNumber, CancellationToken cancellationToken);
}