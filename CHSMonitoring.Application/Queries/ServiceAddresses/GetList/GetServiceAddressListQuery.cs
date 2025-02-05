using CHSMonitoring.Domain.Entities;
using MediatR;

namespace CHSMonitoring.Application.Queries.ServiceAddresses.GetList;

public class GetServiceAddressListQuery : IRequest<List<ServiceAddress>>
{
    public List<string> StreetNames { get; private set; }
    
    public GetServiceAddressListQuery(List<string> streetNames)
    {
        StreetNames = streetNames;
    }
}