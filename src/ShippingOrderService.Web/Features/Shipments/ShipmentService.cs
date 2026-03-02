namespace ShippingOrderService.Web.Features.Shipments;

public class ShipmentService(IShipmentRepository _shipmentRepository) : IShipmentService
{
    public Task<Shipment> GetById(Guid uuid)
    {
        return _shipmentRepository.GetById(uuid);
    }
}