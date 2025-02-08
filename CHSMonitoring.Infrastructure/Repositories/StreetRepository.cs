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

    public async Task UpdateStreetHouseNumbersAsync(Guid streetId, List<string> houseNumbers, CancellationToken cancellationToken)
    {
        var street = await GetStreetAsync(streetId, cancellationToken).ConfigureAwait(false);
        if (houseNumbers.Any())
        {
            if (street.HouseNumbers.Length == 0)
            {
                street.HouseNumbers = string.Join(",", houseNumbers);
            }
            else
            {
                var currentHouseNumbers = street.HouseNumbers.Split(",").ToList();
                var notObtainedHouseNumbers = currentHouseNumbers
                    .Where(x => !houseNumbers.Any(t => x.Equals(t, StringComparison.InvariantCultureIgnoreCase)))
                    .ToList();
                if (notObtainedHouseNumbers.Any())
                {
                    street.HouseNumbers = string.Concat(street.HouseNumbers, ",", string.Join(",", houseNumbers));
                }
            }
        }

        _context.Update(street);
        await _context.SaveChangesAsync().ConfigureAwait(false);
    }

    public async Task<Street> GetStreetAsync(Guid streetId, CancellationToken cancellationToken)
    {
        return await _context.Streets
            .FirstOrDefaultAsync(x => x.Id == streetId, cancellationToken)
            .ConfigureAwait(false);
    }
}