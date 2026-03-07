using ShippingOrderService.Web.Domain.Shipments.Exceptions;

namespace ShippingOrderService.Web.Domain.Shipments;

public class ShipmentItem
{
    private ShipmentItem()
    {
        // Empty for EF construction
    }

    public static ShipmentItem Create(
        string description,
        decimal weight,
        int quantity,
        bool isFragile,
        Dimensions? dimensions = null)
    {
        if (quantity <= 0)
            throw new DomainException("Quantity must be greater than zero");

        if (weight < 0)
            throw new DomainException("Weight must be greater than zero");

        return new ShipmentItem
        {
            Description = description,
            Weight = weight,
            Quantity = quantity,
            IsFragile = isFragile,
            Dimensions = dimensions
        };
    }

    public long Id { get; private set; }

    public string Description { get; private set; }

    public decimal Weight { get; private set; }

    public int Quantity { get; private set; }

    public bool IsFragile { get; private set; }

    public Dimensions? Dimensions { get; private set; }
}