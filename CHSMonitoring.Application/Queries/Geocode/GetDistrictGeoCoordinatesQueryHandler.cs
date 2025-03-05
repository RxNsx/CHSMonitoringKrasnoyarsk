using CHSMonitoring.Application.Dtos.Geocode;
using CHSMonitoring.Infrastructure.Interfaces;
using MediatR;
using Shared;

namespace CHSMonitoring.Application.Queries.Geocode;

public class GetDistrictGeoCoordinatesQueryHandler : IRequestHandler<GetDistrictGeoCoordinatesQuery, Result<List<ServiceAddressGeoLocationDto>>>
{
    private readonly IGeocodeService _geocodeService;

    /// <summary>
    /// Конструктор
    /// </summary>
    /// <param name="geocodeService"></param>
    public GetDistrictGeoCoordinatesQueryHandler(IGeocodeService geocodeService)
    {
        _geocodeService = geocodeService;
    }

    public async Task<Result<List<ServiceAddressGeoLocationDto>>> Handle(GetDistrictGeoCoordinatesQuery request, CancellationToken cancellationToken)
    {
        var serviceAddressesGeoData =  await _geocodeService.GetServiceAddressGeoDataAsync(request.DistrictId, cancellationToken)
            .ConfigureAwait(false);

        var serviceAddressGeoLocationList =  serviceAddressesGeoData
            .Select(x => new ServiceAddressGeoLocationDto()
            {
                Address = x.StreetName,
                Latitude = x.Latitude,
                Longtitude = x.LongTitude,
                ServiceTypeName = x.ServiceTypeName
            })
            .ToList();
        return Result.Success(serviceAddressGeoLocationList);
    }
}