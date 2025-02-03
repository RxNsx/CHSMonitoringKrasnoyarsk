using CHSMonitoring.Domain.Entities;
using MediatR;

namespace CHSMonitoring.Application.Queries.ServiceAddresses.Get;

public class GetServiceAddressQuery : IRequest<ServiceAddress>
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
    /// <param name="StreetName"></param>
    /// <param name="HouseNumber"></param>
    public GetServiceAddressQuery(string streetName, string houseNumber)
    {
        StreetName = streetName;
        HouseNumber = houseNumber;
    }
}