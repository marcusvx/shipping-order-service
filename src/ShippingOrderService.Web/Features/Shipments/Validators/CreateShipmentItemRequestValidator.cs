using System.Data;
using FluentValidation;

namespace ShippingOrderService.Web.Features.Shipments;

public class CreateShipmentItemRequestValidator : AbstractValidator<CreateShipmentItemRequest>
{
    public CreateShipmentItemRequestValidator()
    {
        RuleFor(x => x.Description)
            .NotEmpty()
            .MaximumLength(255)
            .WithMessage("Description must be between 1 and 255 characters long.");

        RuleFor(x => x.Quantity)
            .GreaterThan(0)
            .WithMessage("Quantity must be greater than 0.");

        RuleFor(x => x.Weight)
            .GreaterThan(0)
            .WithMessage("Weight must be greater than 0.");

        RuleFor(x => x.DimensionsHeight)
            .GreaterThan(0)
            .WithMessage("Height must be greater than 0.");

        RuleFor(x => x.DimensionsWidth)
            .GreaterThan(0)
            .WithMessage("Width must be greater than 0.");

        RuleFor(x => x.DimensionsDepth)
            .GreaterThan(0)
            .WithMessage("Depth must be greater than 0.");
    }
}