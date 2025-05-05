using CHSMonitoring.Application.Dtos.Streets;
using MediatR;

namespace CHSMonitoring.Application.Queries.Streets;

public class GetAllStreetsQuery : IRequest<List<StreetDto>>
{
    
}