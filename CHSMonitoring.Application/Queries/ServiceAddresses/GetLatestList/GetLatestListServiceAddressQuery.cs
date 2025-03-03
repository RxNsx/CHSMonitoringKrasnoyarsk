using CHSMonitoring.Domain.Entities;
using MediatR;
using Shared;

namespace CHSMonitoring.Application.Queries.ServiceAddresses.GetLatestList;

public record GetLatestListServiceAddressQuery : IRequest<Result<List<ServiceAddress>>>
{
    
}