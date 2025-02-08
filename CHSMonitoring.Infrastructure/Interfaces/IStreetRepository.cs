using CHSMonitoring.Domain.Entities;

namespace CHSMonitoring.Infrastructure.Interfaces;

/// <summary>
/// Интерфейс репозитория улиц
/// </summary>
public interface IStreetRepository
{
    /// <summary>
    /// Обновление информации по конкретной улице
    /// </summary>
    /// <param name="streetId">Ид улицы</param>
    /// <param name="houseNumbers">Список домов улицы</param>
    /// <param name="cancellationTokenn"></param>
    /// <returns></returns>
    Task UpdateStreetHouseNumbersAsync(Guid streetId, List<string> houseNumbers, CancellationToken cancellationTokenn);

    /// <summary>
    /// Получить улицу по Id
    /// </summary>
    /// <param name="streetId">Ид улицы</param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<Street> GetStreetAsync(Guid streetId, CancellationToken cancellationToken);
    
    /// <summary>
    /// Получить улицу по названию
    /// </summary>
    /// <param name="streetName"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<Street> GetStreetAsync(string streetName, CancellationToken cancellationToken);
}