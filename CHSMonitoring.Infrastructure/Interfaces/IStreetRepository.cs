using CHSMonitoring.Domain.Entities;

namespace CHSMonitoring.Infrastructure.Interfaces;

/// <summary>
/// Интерфейс репозитория улиц
/// </summary>
public interface IStreetRepository
{
    /// <summary>
    /// Обновление 
    /// </summary>
    /// <param name="cancellationTokenn"></param>
    /// <returns></returns>
    Task UpdateStreetHouseNumbersAsync(CancellationToken cancellationTokenn);

    /// <summary>
    /// Получить улицу по Id
    /// </summary>
    /// <param name="streetId"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<Street> GetStreetAsync(Guid streetId, CancellationToken cancellationToken);
}