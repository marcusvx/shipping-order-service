using ShippingOrderService.Web.Common;
using ShippingOrderService.Web.Domain.Shipments;

namespace ShippingOrderService.Web.Features.Shipments;

public interface IShipmentService
{
    Task<Shipment> GetById(Ulid id);

    Task<DomainResult<Shipment>> Create(CreateShipmentRequest request);
}