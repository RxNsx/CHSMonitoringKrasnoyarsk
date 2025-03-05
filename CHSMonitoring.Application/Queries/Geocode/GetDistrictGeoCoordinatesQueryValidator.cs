using FluentValidation;

namespace CHSMonitoring.Application.Queries.Geocode;

public class GetDistrictGeoCoordinatesQueryValidator : AbstractValidator<GetDistrictGeoCoordinatesQuery>
{
    public GetDistrictGeoCoordinatesQueryValidator()
    {
        RuleFor(x => x.DistrictId)
            .NotEmpty().WithMessage("District id is required")
            .NotNull().WithMessage("District id is required");
    }
}