using Microsoft.AspNetCore.Mvc;

namespace ShippingOrderService.Web.Features.Shipments;

public interface IShipmentService
{
    Task<Shipment> GetById(Guid uuid);
}