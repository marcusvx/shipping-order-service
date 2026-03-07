namespace ShippingOrderService.Web.Domain.Shipments;

public record Dimensions(
    decimal WidthCm,
    decimal HeightCm,
    decimal DepthCm
);