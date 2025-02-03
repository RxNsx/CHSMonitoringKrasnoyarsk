using CHSMonitoring.Domain.Entities;
using CHSMonitoring.Infrastructure.Interfaces;
using MediatR;

namespace CHSMonitoring.Application.Queries.ServiceAddresses.Get;

public class GetServiceAddressQueryHandler : IRequestHandler<GetServiceAddressQuery, ServiceAddress>
{
    private readonly IServiceAddressRepository _serviceAddressRepository;

    /// <summary>
    /// Конструктор
    /// </summary>
    /// <param name="serviceAddressRepository"></param>
    public GetServiceAddressQueryHandler(IServiceAddressRepository serviceAddressRepository)
    {
        _serviceAddressRepository = serviceAddressRepository;
    }

    /// <summary>
    /// Обработчик запроса
    /// </summary>
    /// <param name="request"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    /// <exception cref="NotImplementedException"></exception>
    public async Task<ServiceAddress> Handle(GetServiceAddressQuery request, CancellationToken cancellationToken)
    {
        return await _serviceAddressRepository.GetServiceAddressAsync(request.HouseNumber, request.StreetName,cancellationToken)
            .ConfigureAwait(false);
    }
}