using CHSMonitoring.Domain.Entities;
using CHSMonitoring.Infrastructure.Interfaces;
using MediatR;

namespace CHSMonitoring.Application.Queries.ServiceAddresses.GetList;

public class GetServiceAddressListQueryHandler : IRequestHandler<GetServiceAddressListQuery, List<ServiceAddress>>
{
    private readonly IServiceAddressRepository _serviceAddressRepository;

    public GetServiceAddressListQueryHandler(IServiceAddressRepository serviceAddressRepository)
    {
        _serviceAddressRepository = serviceAddressRepository;
    }

    public async Task<List<ServiceAddress>> Handle(GetServiceAddressListQuery request, CancellationToken cancellationToken)
    {
        return await _serviceAddressRepository.GetServiceAddressesAsync(request.StreetNames, cancellationToken);
    }
}