using CHSMonitoring.Application.Errors.ServiceAddressErrors;
using CHSMonitoring.Domain.Entities;
using CHSMonitoring.Infrastructure.Interfaces;
using MediatR;
using VplayRequestTransmitter.Shared;

namespace CHSMonitoring.Application.Queries.ServiceAddresses.Get;

public class GetServiceAddressQueryHandler : IRequestHandler<GetServiceAddressQuery, Result<ServiceAddress>>
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
    public async Task<Result<ServiceAddress>> Handle(GetServiceAddressQuery request, CancellationToken cancellationToken)
    {
        var serviceAddress =  await _serviceAddressRepository.GetServiceAddressAsync(request.StreetName, request.HouseNumber, cancellationToken)
            .ConfigureAwait(false);
        if (serviceAddress is null)
        {
            return Result.Failure<ServiceAddress>(ServiceAddressError.NotFound());
        }

        return Result.Success(serviceAddress);
    }
}