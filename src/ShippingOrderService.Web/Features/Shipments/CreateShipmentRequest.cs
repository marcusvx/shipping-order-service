using ShippingOrderService.Web.Domain.Shipments;

namespace ShippingOrderService.Web.Features.Shipments;

public class CreateShipmentRequest
{
    public string CustomerName { get; set; }

    public string OriginZipCode { get; set; }

    public string DestinationZipCode { get; set; }

    public decimal TotalValue { get; set; }

    public ShipmentPriority Priority { get; set; }

    public IEnumerable<CreateShipmentItemRequest> Items { get; set; }
}

public class CreateShipmentItemRequest
{
    public string Description { get; set; }

    public decimal Weight { get; set; }

    public int Quantity { get; set; }

    public bool IsFragile { get; set; }

    public decimal DimensionsHeight { get; set; }

    public decimal DimensionsWidth { get; set; }

    public decimal DimensionsDepth { get; set; }
}