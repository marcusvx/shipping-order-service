namespace ShippingOrderService.Web.Features.Shipments;

public record Dimensions(
    decimal WidthCm,
    decimal HeightCm,
    decimal DepthCm
);