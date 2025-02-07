using CHSMonitoring.Domain.Entities;
using CHSMonitoring.Infrastructure.Context;
using CHSMonitoring.Infrastructure.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CHSMonitoring.Infrastructure.Repositories;

/// <summary>
/// Репозиторий улиц
/// </summary>
public class StreetRepository : IStreetRepository
{
    private readonly MonitoringDbContext _context;

    /// <summary>
    /// Конструктор
    /// </summary>
    /// <param name="context"></param>
    public StreetRepository(MonitoringDbContext context)
    {
        _context = context;
    }

    public async Task UpdateStreetHouseNumbersAsync(CancellationToken cancellationTokenn)
    {
        throw new NotImplementedException();
    }

    public async Task<Street> GetStreetAsync(Guid streetId, CancellationToken cancellationToken)
    {
        return await _context.Streets
            .FirstOrDefaultAsync(x => x.Id == streetId, cancellationToken)
            .ConfigureAwait(false);
    }
}