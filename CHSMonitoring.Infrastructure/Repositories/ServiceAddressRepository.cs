using System.Collections.Immutable;
using CHSMonitoring.Domain.Entities;
using CHSMonitoring.Infrastructure.Context;
using CHSMonitoring.Infrastructure.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace CHSMonitoring.Infrastructure.Repositories;

/// <summary>
/// Интерфейс для упраления обслуживающими адресами
/// </summary>
public class ServiceAddressRepository : IServiceAddressRepository
{
    private readonly MonitoringDbContext _context;
    private readonly ILogger<ServiceAddress> _logger;

    /// <summary>
    /// Конструктор
    /// </summary>
    /// <param name="context"></param>
    /// <param name="logger"></param>
    public ServiceAddressRepository(MonitoringDbContext context, ILogger<ServiceAddress> logger)
    {
        _context = context;
        _logger = logger;
    }

    public async Task<List<ServiceAddress>> GetLatestServiceAddressAsync(CancellationToken cancellationToken)
    {
        var count = await _context.ServiceAddresses.CountAsync().ConfigureAwait(false);
        _logger.LogInformation($"Total service addresses count: {count}");
        
        if (await _context.ServiceAddresses.AnyAsync(cancellationToken).ConfigureAwait(false))
        {
            var latestTime = await _context.ServiceAddresses
                .MaxAsync(x => x.CreatedDate)
                .ConfigureAwait(false);
            _logger.LogInformation($"Max Time: {latestTime}");
        
            return await _context.ServiceAddresses
                .AsNoTracking()
                .Include(x => x.Street)
                .Where(x => x.CreatedDate == latestTime)
                .ToListAsync(cancellationToken)
                .ConfigureAwait(false);
        }

        _logger.LogInformation($"Empty");
        return new List<ServiceAddress>();
    }

    public async Task<List<ServiceAddress>> GetLatestServiceAddressByDistrictAsync(Guid districtId, CancellationToken cancellationToken)
    {
        var latestTime = await _context.ServiceAddresses
            .MaxAsync(x => x.CreatedDate)
            .ConfigureAwait(false);
        
        return await _context.ServiceAddresses
            .AsNoTracking()
            .Include(x => x.Street)
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
            .Include(x => x.Street)
            .Where(x => streetName.Contains(x.Street.Name))
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
            .Include(x => x.Street)
            .Where(x => x.Street.Name == streetName && x.HouseNumber == houseNumber)
            .GroupBy(x => new { x.Street.Name, x.HouseNumber })
            .Select(x => new
            {
                x.Key.Name,
                x.Key.HouseNumber,
                CreatedDate = x.Max(t => t.CreatedDate)
            })
            .FirstOrDefaultAsync()
            .ConfigureAwait(false);
        
        return await _context.ServiceAddresses
            .Include(x => x.Street)
            .Include(x => x.District)
            .Include(x => x.ServiceType)
            .Where(x => x.CreatedDate == lastCreatedDateServiceAddress!.CreatedDate 
                        && lastCreatedDateServiceAddress.Name == x.Street.Name 
                        && lastCreatedDateServiceAddress.HouseNumber == x.HouseNumber)
            .FirstOrDefaultAsync()
            .ConfigureAwait(false);
    }

    public async Task<bool> IsExistServiceAddressAsync(string streetName, string houseNumber, CancellationToken cancellationToken)
    {
        return await _context.ServiceAddresses
            .Include(x => x.Street)
            .AnyAsync(x => x.Street.Name == streetName && x.HouseNumber == houseNumber, cancellationToken)
            .ConfigureAwait(false);
    }
}