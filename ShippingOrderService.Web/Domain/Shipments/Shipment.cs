namespace ShippingOrderService.Web.Features.Shipments;

public class Shipment
{
    public Guid Id { get; set; }
    public string CustomerName { get; set; }
    public string OriginZipCode { get; set; }
    public string DestinationZipCode { get; set; }
    public IEnumerable<ShipmentItem>? Items { get; set; }
    public decimal TotalValue { get; set; }
    public ShipmentPriority? Priority { get; set; } = ShipmentPriority.Normal;
}