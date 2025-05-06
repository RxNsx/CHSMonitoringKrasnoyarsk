using CHSMonitoring.Application.Dtos.Geocode;
using MediatR;
using Shared;

namespace CHSMonitoring.Application.Queries.Geocode.GetDistrictGeoCoordinates;

public record GetDistrictGeoCoordinatesQuery(string DistrictId) : IRequest<Result<List<ServiceAddressGeoLocationDto>>>
{
    
}