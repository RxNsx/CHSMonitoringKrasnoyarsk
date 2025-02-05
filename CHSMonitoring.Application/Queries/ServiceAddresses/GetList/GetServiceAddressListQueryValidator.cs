using FluentValidation;

namespace CHSMonitoring.Application.Queries.ServiceAddresses.GetList;

public class GetServiceAddressListQueryValidator : AbstractValidator<GetServiceAddressListQuery>
{
    public GetServiceAddressListQueryValidator()
    {
        RuleForEach(x => x.StreetNames)
            .NotEmpty().WithMessage("Street name is required");
    }
}