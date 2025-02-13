using CHSMonitoring.Domain.Entities;
using CHSMonitoring.Infrastructure.Interfaces;
using MediatR;
using VplayRequestTransmitter.Shared;

namespace CHSMonitoring.Application.Queries.ServiceAddresses.GetLatestList;

public class GetLatestListServiceAddressQueryHandler : IRequestHandler<GetLatestListServiceAddressQuery, Result<List<ServiceAddress>>>
{
    private readonly IServiceAddressRepository _serviceAddressRepository;
    
    /// <summary>
    /// Конструктор
    /// </summary>
    public GetLatestListServiceAddressQueryHandler(IServiceAddressRepository serviceAddressRepository)
    {
        _serviceAddressRepository = serviceAddressRepository;
    }
    
    public async Task<Result<List<ServiceAddress>>> Handle(GetLatestListServiceAddressQuery request, CancellationToken cancellationToken)
    {
        var latestAddresses = await _serviceAddressRepository.GetLatestServiceAddressAsync(cancellationToken)
            .ConfigureAwait(false);
        return Result.Success(latestAddresses);
    }
}