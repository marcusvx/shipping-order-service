using ShippingOrderService.Web.Common;
using ShippingOrderService.Web.Domain.Shipments;

namespace ShippingOrderService.Web.Features.Shipments;

public class ShipmentService(IShipmentRepository _shipmentRepository) : IShipmentService
{
    public async Task<Shipment> GetById(Ulid id)
    {
        return await _shipmentRepository.GetById(id);
    }

    public async Task<DomainResult<Shipment>> Create(CreateShipmentRequest request)
    {
        var shipment = Shipment.Create(
            request.CustomerName,
            request.OriginZipCode,
            request.DestinationZipCode,
            request.TotalValue,
            ShipmentPriority.Normal,
            request.Items.Select(item =>
                ShipmentItem.Create(item.Description, item.Weight, item.Quantity, item.IsFragile,
                    new Dimensions(item.DimensionsWidth, item.DimensionsHeight, item.DimensionsDepth)))
        );

        var createdShipment = await _shipmentRepository.Create(shipment);
        var result = DomainResult<Shipment>.Success(createdShipment);

        return result;
    }
}