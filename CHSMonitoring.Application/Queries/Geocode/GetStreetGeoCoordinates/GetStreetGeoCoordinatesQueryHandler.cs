using CHSMonitoring.Application.Dtos.Geocode;
using CHSMonitoring.Infrastructure.Interfaces;
using MediatR;
using Shared;

namespace CHSMonitoring.Application.Queries.Geocode.GetStreetGeoCoordinates;

/// <summary>
/// Обработчик запроса на получение геоданных по улице
/// </summary>
public class GetStreetGeoCoordinatesQueryHandler : IRequestHandler<GetStreetGeoCoordinatesQuery, Result<List<ServiceAddressGeoLocationDto>>>
{
    private readonly IGeocodeService _geocodeService;

    /// <summary>
    /// Конструктор
    /// </summary>
    /// <param name="geocodeService"></param>
    public GetStreetGeoCoordinatesQueryHandler(IGeocodeService geocodeService)
    {
        _geocodeService = geocodeService;
    }

    public async Task<Result<List<ServiceAddressGeoLocationDto>>> Handle(GetStreetGeoCoordinatesQuery request, CancellationToken cancellationToken)
    {
        var serviceAddressesGeoData = await _geocodeService.GetServiceAddressGeoDataByStreetNameAsync(request.StreetId, cancellationToken).ConfigureAwait(false);
        var serviceAddressGeoLocationList =  serviceAddressesGeoData
            .Select(x => new ServiceAddressGeoLocationDto()
            {
                Address = x.StreetName,
                Latitude = x.Latitude,
                Longtitude = x.LongTitude,
                ServiceTypeName = x.ServiceTypeName
            })
            .OrderBy(x => x.Address)
            .ToList();
        return Result.Success(serviceAddressGeoLocationList);
    }
}