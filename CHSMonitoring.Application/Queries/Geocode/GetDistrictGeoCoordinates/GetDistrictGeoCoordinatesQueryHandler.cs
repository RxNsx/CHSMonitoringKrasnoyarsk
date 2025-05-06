using CHSMonitoring.Application.Dtos.Geocode;
using CHSMonitoring.Infrastructure.Interfaces;
using MediatR;
using Microsoft.Extensions.Logging;
using Shared;

namespace CHSMonitoring.Application.Queries.Geocode.GetDistrictGeoCoordinates;

public class GetDistrictGeoCoordinatesQueryHandler : IRequestHandler<GetDistrictGeoCoordinatesQuery, Result<List<ServiceAddressGeoLocationDto>>>
{
    private readonly IGeocodeService _geocodeService;
    private readonly ILogger<GetDistrictGeoCoordinatesQuery> _logger;

    /// <summary>
    /// Конструктор
    /// </summary>
    /// <param name="geocodeService"></param>
    /// <param name="logger"></param>
    public GetDistrictGeoCoordinatesQueryHandler(IGeocodeService geocodeService, ILogger<GetDistrictGeoCoordinatesQuery> logger)
    {
        _geocodeService = geocodeService;
        _logger = logger;
    }

    public async Task<Result<List<ServiceAddressGeoLocationDto>>> Handle(GetDistrictGeoCoordinatesQuery request, CancellationToken cancellationToken)
    {
        var serviceAddressesGeoData =  await _geocodeService.GetServiceAddressGeoDataByDistrictAsync(request.DistrictId, cancellationToken)
            .ConfigureAwait(false);
        _logger.LogInformation($"Count serviceAddresses: {serviceAddressesGeoData.Count}");
        if (!serviceAddressesGeoData.Any())
        {
            return Result.Success(new List<ServiceAddressGeoLocationDto>() {});
        }
        
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