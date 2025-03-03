using CHSMonitoring.Domain.Entities;
using MediatR;
using Shared;

namespace CHSMonitoring.Application.Queries.ServiceAddresses.GetList;

public class GetServiceAddressListQuery : IRequest<Result<List<ServiceAddress>>>
{
    public List<string> StreetNames { get; private set; }
    
    public GetServiceAddressListQuery(List<string> streetNames)
    {
        StreetNames = streetNames;
    }
}