namespace ShippingOrderService.Web.Features.Shipments;

public interface IShipmentRepository
{
    Task<Shipment> GetById(Guid uuid);
}