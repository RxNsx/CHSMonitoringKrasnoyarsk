using CHSMonitoring.Application.Errors.ServiceAddressErrors;
using CHSMonitoring.Domain.Entities;
using CHSMonitoring.Infrastructure.Interfaces;
using MediatR;
using Shared;

namespace CHSMonitoring.Application.Queries.ServiceAddresses.GetList;

public class GetServiceAddressListQueryHandler : IRequestHandler<GetServiceAddressListQuery, Result<List<ServiceAddress>>>
{
    private readonly IServiceAddressRepository _serviceAddressRepository;

    public GetServiceAddressListQueryHandler(IServiceAddressRepository serviceAddressRepository)
    {
        _serviceAddressRepository = serviceAddressRepository;
    }

    public async Task<Result<List<ServiceAddress>>> Handle(GetServiceAddressListQuery request, CancellationToken cancellationToken)
    {
        var serviceAddressesList = await _serviceAddressRepository.GetServiceAddressesAsync(request.StreetNames, cancellationToken);
        if (serviceAddressesList is null)
        {
            return Result.Failure<List<ServiceAddress>>(ServiceAddressError.NotFound());
        }

        return Result.Success(serviceAddressesList);
    }
}