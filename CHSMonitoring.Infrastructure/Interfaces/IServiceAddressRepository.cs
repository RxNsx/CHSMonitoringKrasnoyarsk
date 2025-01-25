using CHSMonitoring.Domain.Entities;

namespace CHSMonitoring.Infrastructure.Interfaces;

/// <summary>
/// Интерфейс для упраления обслуживающими адресами
/// </summary>
public interface IServiceAddressRepository
{
    /// <summary>
    /// Получить список событий обслуживания адреса
    /// </summary>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<List<ServiceAddress>> GetServiceAddressesAsynс(CancellationToken cancellationToken);
    
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
    /// <param name="serviceAddress"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<ServiceAddress> GetServiceAddressAsync(ServiceAddress serviceAddress, CancellationToken cancellationToken);
    
    /// <summary>
    /// Проверка существования события обслуживания в базе
    /// </summary>
    /// <param name="serviceAddress"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<bool> IsExistServiceAddressAsync(ServiceAddress serviceAddress, CancellationToken cancellationToken);
}