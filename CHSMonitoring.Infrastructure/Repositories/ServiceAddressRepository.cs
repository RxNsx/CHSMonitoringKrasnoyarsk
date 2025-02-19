using System.Collections.Immutable;
using CHSMonitoring.Domain.Entities;
using CHSMonitoring.Infrastructure.Context;
using CHSMonitoring.Infrastructure.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CHSMonitoring.Infrastructure.Repositories;

/// <summary>
/// Интерфейс для упраления обслуживающими адресами
/// </summary>
public class ServiceAddressRepository : IServiceAddressRepository
{
    private readonly MonitoringDbContext _context;
    
    /// <summary>
    /// Конструктор
    /// </summary>
    /// <param name="context"></param>
    public ServiceAddressRepository(MonitoringDbContext context)
    {
        _context = context;
    }

    public async Task<List<ServiceAddress>> GetLatestServiceAddressAsync(CancellationToken cancellationToken)
    {
        var latestTime = await _context.ServiceAddresses
            .MaxAsync(x => x.CreatedDate)
            .ConfigureAwait(false);
        
        return await _context.ServiceAddresses
            .Where(x => x.CreatedDate == latestTime)
            .ToListAsync(cancellationToken)
            .ConfigureAwait(false);
    }

    public async Task<List<ServiceAddress>> GetLatestServiceAddressByDistrictAsync(Guid districtId, CancellationToken cancellationToken)
    {
        var latestTime = await _context.ServiceAddresses
            .MaxAsync(x => x.CreatedDate)
            .ConfigureAwait(false);
        
        return await _context.ServiceAddresses
            .Where(x => x.CreatedDate == latestTime && x.DistrictId == districtId)
            .ToListAsync(cancellationToken)
            .ConfigureAwait(false);
    }

    public async Task<List<ServiceAddress>> GetServiceAddressesAsynс(CancellationToken cancellationToken)
    {
        return await _context.ServiceAddresses.ToListAsync(cancellationToken)
            .ConfigureAwait(false);
    }

    public async Task<List<ServiceAddress>> GetServiceAddressesAsync(List<string> streetName, CancellationToken cancellationToken)
    {
        return await _context.ServiceAddresses
            .Where(x => streetName.Contains(x.StreetName))
            .ToListAsync(cancellationToken);
    }

    public async Task AddServiceAddressesAsync(List<ServiceAddress> serviceAddresses, CancellationToken cancellationToken)
    {
        await _context.ServiceAddresses.AddRangeAsync(serviceAddresses, cancellationToken).ConfigureAwait(false);
        await _context.SaveChangesAsync().ConfigureAwait(false);
    }

    public async Task<ServiceAddress?> GetServiceAddressAsync(string streetName, string houseNumber, CancellationToken cancellationToken)
    {
        if (!await IsExistServiceAddressAsync(streetName, houseNumber, cancellationToken).ConfigureAwait(false))
        {
            return null;
        }
        
        var lastCreatedDateServiceAddress = await _context.ServiceAddresses
            .Where(x => x.StreetName == streetName && x.HouseNumber == houseNumber)
            .GroupBy(x => new { x.StreetName, x.HouseNumber })
            .Select(x => new
            {
                x.Key.StreetName,
                x.Key.HouseNumber,
                CreatedDate = x.Max(t => t.CreatedDate)
            })
            .FirstOrDefaultAsync()
            .ConfigureAwait(false);
        
        return await _context.ServiceAddresses
            .Include(x => x.District)
            .Include(x => x.ServiceType)
            .Where(x => x.CreatedDate == lastCreatedDateServiceAddress!.CreatedDate 
                        && lastCreatedDateServiceAddress.StreetName == x.StreetName 
                        && lastCreatedDateServiceAddress.HouseNumber == x.HouseNumber)
            .FirstOrDefaultAsync()
            .ConfigureAwait(false);
    }

    public async Task<bool> IsExistServiceAddressAsync(string streetName, string houseNumber, CancellationToken cancellationToken)
    {
        return await _context.ServiceAddresses
            .AnyAsync(x => x.StreetName == streetName && x.HouseNumber == houseNumber, cancellationToken)
            .ConfigureAwait(false);
    }
}