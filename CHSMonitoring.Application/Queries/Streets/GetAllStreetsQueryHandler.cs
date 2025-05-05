using CHSMonitoring.Application.Dtos.Streets;
using CHSMonitoring.Infrastructure.Interfaces;
using MediatR;

namespace CHSMonitoring.Application.Queries.Streets;

public class GetAllStreetsQueryHandler : IRequestHandler<GetAllStreetsQuery, List<StreetDto>>
{
    private readonly IStreetRepository _streetRepository;

    public GetAllStreetsQueryHandler(IStreetRepository streetRepository)
    {
        _streetRepository = streetRepository;
    }

    public async Task<List<StreetDto>> Handle(GetAllStreetsQuery request, CancellationToken cancellationToken)
    {
        var allStreets =  await _streetRepository.GetAllStreetsAsync(cancellationToken)
            .ConfigureAwait(false);
        if (!allStreets.Any())
        {
            return [];
        }

        return allStreets
            .Select(x => new StreetDto()
            {
                StreetName = x.Name
            })
            .OrderBy(x => x.StreetName)
            .ToList();
    }
}