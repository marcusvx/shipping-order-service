using ShippingOrderService.Web.Domain.Shipments.Exceptions;

namespace ShippingOrderService.Web.Domain.Shipments;

public class Shipment
{
    private readonly List<ShipmentItem> _items = [];

    private Shipment()
    {
        // Empty for EF construction
    }

    public static Shipment Create(
        string customerName,
        string originZipCode,
        string destinationZipCode,
        decimal totalValue,
        ShipmentPriority priority,
        IEnumerable<ShipmentItem> items)
    {
        if (!items.Any())
            throw new DomainException("Shipment must have at least one item.");

        var shipment = new Shipment
        {
            Id = Ulid.NewUlid(),
            CustomerName = customerName,
            OriginZipCode = originZipCode,
            DestinationZipCode = destinationZipCode,
            TotalValue = totalValue,
            Priority = priority,
            Status = ShipmentStatus.Pending,
            CreatedAt = DateTime.UtcNow
        };

        shipment._items.AddRange(items);
        return shipment;
    }

    public Ulid Id { get; private set; }

    public ShipmentStatus Status { get; private set; }

    public DateTime CreatedAt { get; private set; }

    public string CustomerName { get; private set; }
    public string OriginZipCode { get; private set; }
    public string DestinationZipCode { get; private set; }

    public IReadOnlyCollection<ShipmentItem> Items => _items.AsReadOnly();

    public decimal TotalValue { get; private set; }

    public ShipmentPriority? Priority { get; private set; } = ShipmentPriority.Normal;
}