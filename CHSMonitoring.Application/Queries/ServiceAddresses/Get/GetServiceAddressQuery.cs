using CHSMonitoring.Domain.Entities;
using MediatR;
using VplayRequestTransmitter.Shared;

namespace CHSMonitoring.Application.Queries.ServiceAddresses.Get;

public class GetServiceAddressQuery : IRequest<Result<ServiceAddress>>
{
    /// <summary>
    /// Название улицы
    /// </summary>
    public string StreetName { get; private set; }
    
    /// <summary>
    /// Номер дома
    /// </summary>
    public string HouseNumber { get; private set; }

    /// <summary>
    /// Конструктор
    /// </summary>
    /// <param name="streetName"></param>
    /// <param name="houseNumber"></param>
    public GetServiceAddressQuery(string streetName, string houseNumber)
    {
        StreetName = streetName;
        HouseNumber = houseNumber;
    }
}