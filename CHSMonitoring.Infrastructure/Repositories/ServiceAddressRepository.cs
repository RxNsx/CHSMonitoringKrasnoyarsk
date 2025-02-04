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
    
    public ServiceAddressRepository(MonitoringDbContext context)
    {
        _context = context;
    }
    
    public async Task<List<ServiceAddress>> GetServiceAddressesAsynс(CancellationToken cancellationToken)
    {
        return await _context.ServiceAddresses.ToListAsync(cancellationToken);
    }

    public async Task AddServiceAddressesAsync(List<ServiceAddress> serviceAddresses, CancellationToken cancellationToken)
    {
        await _context.ServiceAddresses.AddRangeAsync(serviceAddresses, cancellationToken).ConfigureAwait(false);
        await _context.SaveChangesAsync().ConfigureAwait(false);
    }

    public async Task<ServiceAddress> GetServiceAddressAsync(string streetName, string houseNumber,
        CancellationToken cancellationToken)
    {
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

        var serviceAddress = await _context.ServiceAddresses
            .Include(x => x.District)
            .Include(x => x.ServiceType)
            .Where(x => x.CreatedDate == lastCreatedDateServiceAddress!.CreatedDate 
                        && lastCreatedDateServiceAddress.StreetName == x.StreetName 
                        && lastCreatedDateServiceAddress.HouseNumber == x.HouseNumber)
            .FirstOrDefaultAsync()
            .ConfigureAwait(false);

        return serviceAddress;
    }

    public async Task<bool> IsExistServiceAddressAsync(ServiceAddress serviceAddress, CancellationToken cancellationToken)
    {
        // //TODO: Result Pattern
        // return (await GetServiceAddressesAsynс(cancellationToken).ConfigureAwait(false))
        //     .Any(x => x.StreetName == serviceAddress.StreetName 
        //            && x.HouseNumber == serviceAddress.HouseNumber 
        //            && x.ServiceType == serviceAddress.ServiceType);
        
        return false;
    }
}