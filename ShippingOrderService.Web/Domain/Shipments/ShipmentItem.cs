namespace ShippingOrderService.Web.Features.Shipments;

public class ShipmentItem
{
    public Shipment? Shipment { get; set; }

    public Guid Id { get; set; }

    public string Description { get; set; }

    public decimal Weight { get; set; }

    public int Quantity { get; set; }

    public bool IsFragile { get; set; }

    public Dimensions? Dimensions { get; set; }
}