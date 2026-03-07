using FluentValidation;

namespace ShippingOrderService.Web.Features.Shipments;

// ReSharper disable once UnusedType.Global
public class CreateShipmentRequestValidator : AbstractValidator<CreateShipmentRequest>
{
    public CreateShipmentRequestValidator()
    {
        RuleFor(x => x.CustomerName)
            .NotEmpty();

        RuleFor(x => x.OriginZipCode)
            .NotEmpty()
            .Matches(@"^\d{5}-\d{3}$")
            .WithMessage("Invalid origin zip code.");

        RuleFor(x => x.DestinationZipCode)
            .NotEmpty()
            .Matches(@"^\d{5}-\d{3}$")
            .WithMessage("Invalid destination zip code.");

        RuleFor(x => x.TotalValue)
            .GreaterThan(0)
            .WithMessage("Total value must be greater than 0.");

        RuleFor(x => x.Items)
            .NotEmpty();
    }
}