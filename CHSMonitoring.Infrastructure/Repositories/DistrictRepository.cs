using CHSMonitoring.Domain.Entities;
using CHSMonitoring.Infrastructure.Context;
using CHSMonitoring.Infrastructure.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CHSMonitoring.Infrastructure.Repositories;

/// <summary>
/// Репозиторий районов
/// </summary>
public class DistrictRepository : IDistrictRepository
{
    private readonly MonitoringDbContext _context;

    public DistrictRepository(MonitoringDbContext context)
    {
        _context = context;
    }

    public async Task<List<District>> GetDistrictsAsync(CancellationToken cancellationToken)
    {
        return await _context.Districts
            .AsNoTracking()
            .ToListAsync(cancellationToken)
            .ConfigureAwait(false);
    }
}