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
        
        /*
         * TODO: Реализовать логику парсинга и определения нового события
         * 
         */
        
        /*
         * TODO: Реализовать следующую логику для добавления
         * 1. Создать сущность для хранения истории с ID ServiceAddress и датой
         * 2. По последнему событию приходящему проверять актуальность данных
         * 3. Создать материализованное представление для агрегации на каждый день \ или таблицу с агрегацией данных
         * 4. КОРРЕКТНЫМ считается событие которое приходит последним, соответственно самым корректным с точки зрения точности данных
         */

        await _context.ServiceAddresses.AddRangeAsync(serviceAddresses, cancellationToken).ConfigureAwait(false);
        await _context.SaveChangesAsync().ConfigureAwait(false);
    }

    public async Task<ServiceAddress> GetServiceAddressAsync(ServiceAddress serviceAddress,
        CancellationToken cancellationToken)
    {
        var result =  await _context.ServiceAddresses
            .FirstOrDefaultAsync(x => x.StreetName == serviceAddress.StreetName
                                      && x.HouseNumber == serviceAddress.HouseNumber
                                      && x.ServiceType == serviceAddress.ServiceType
                                      && x.From == serviceAddress.From
                                      && x.To == serviceAddress.To)
            .ConfigureAwait(false);

        //TODO: Result Pattern
        return result;
    }

    public async Task<bool> IsExistServiceAddressAsync(ServiceAddress serviceAddress, CancellationToken cancellationToken)
    {
        //TODO: Result Pattern
        return (await GetServiceAddressesAsynс(cancellationToken).ConfigureAwait(false))
            .Any(x => x.StreetName == serviceAddress.StreetName 
                   && x.HouseNumber == serviceAddress.HouseNumber 
                   && x.ServiceType == serviceAddress.ServiceType);
    }
}