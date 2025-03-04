using CHSMonitoring.Application.Dtos.District;
using CHSMonitoring.Domain.Entities;
using MediatR;
using Shared;

namespace CHSMonitoring.Application.Queries.Districts.Get;

public record GetDistrictsQuery : IRequest<Result<List<DistrictDto>>>
{
    
}