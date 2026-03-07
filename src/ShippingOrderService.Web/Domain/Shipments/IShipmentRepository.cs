using ShippingOrderService.Web.Common;
using ShippingOrderService.Web.Domain.Shipments;

namespace ShippingOrderService.Web.Features.Shipments;

public interface IShipmentRepository
{
    Task<Shipment> GetById(Ulid id);

    Task<Shipment> Create(Shipment shipmentToCreate);
}