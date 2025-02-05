using FluentValidation;

namespace CHSMonitoring.Application.Queries.ServiceAddresses.Get;

public class GetServiceAddressQueryValidator : AbstractValidator<GetServiceAddressQuery>
{
    public GetServiceAddressQueryValidator()
    {
        RuleFor(x => x.StreetName)
            .NotEmpty().WithMessage("Street name is required")
            .NotNull().WithMessage("Street name is required");

        RuleFor(x => x.HouseNumber)
            .NotEmpty().WithMessage("House number is required")
            .NotEmpty().WithMessage("House number is required");
    }
}