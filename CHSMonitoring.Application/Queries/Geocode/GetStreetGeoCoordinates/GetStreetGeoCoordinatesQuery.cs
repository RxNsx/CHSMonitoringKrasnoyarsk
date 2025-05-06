using CHSMonitoring.Application.Dtos.Geocode;
using MediatR;
using Shared;

namespace CHSMonitoring.Application.Queries.Geocode.GetStreetGeoCoordinates;

public record GetStreetGeoCoordinatesQuery(string StreetId) : IRequest<Result<List<ServiceAddressGeoLocationDto>>>
{
    
}