using CHSMonitoring.Domain.Entities;

namespace CHSMonitoring.Infrastructure.Interfaces;

/// <summary>
/// Интерфейс репозитория районов
/// </summary>
public interface IDistrictRepository
{
    /// <summary>
    /// Получить список районов
    /// </summary>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<List<District>> GetDistrictsAsync(CancellationToken cancellationToken);
}