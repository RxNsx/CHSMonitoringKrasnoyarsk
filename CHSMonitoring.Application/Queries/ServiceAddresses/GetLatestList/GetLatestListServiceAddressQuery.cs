using CHSMonitoring.Domain.Entities;
using MediatR;
using VplayRequestTransmitter.Shared;

namespace CHSMonitoring.Application.Queries.ServiceAddresses.GetLatestList;

public record GetLatestListServiceAddressQuery : IRequest<Result<List<ServiceAddress>>>
{
    
}