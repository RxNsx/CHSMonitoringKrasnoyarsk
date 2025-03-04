using CHSMonitoring.Application.Dtos.District;
using CHSMonitoring.Infrastructure.Interfaces;
using MediatR;
using Shared;

namespace CHSMonitoring.Application.Queries.Districts.Get;

public class GetDistrictsQueryHandler : IRequestHandler<GetDistrictsQuery, Result<List<DistrictDto>>>
{
    private readonly IDistrictRepository _districtRepository;

    /// <summary>
    /// Конструктор
    /// </summary>
    /// <param name="districtRepository"></param>
    public GetDistrictsQueryHandler(IDistrictRepository districtRepository)
    {
        _districtRepository = districtRepository;
    }

    public async Task<Result<List<DistrictDto>>> Handle(GetDistrictsQuery request, CancellationToken cancellationToken)
    {
        var districts = await _districtRepository.GetDistrictsAsync(cancellationToken)
            .ConfigureAwait(false);

        var districtDto = districts
            .Select(x => new DistrictDto()
            {
                Id = x.Id,
                Name = x.Name
            })
            .ToList();
        
        return Result.Success(districtDto);
    }
}