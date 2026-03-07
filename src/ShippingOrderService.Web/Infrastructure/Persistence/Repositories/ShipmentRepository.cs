using ShippingOrderService.Web.Domain.Shipments;
using ShippingOrderService.Web.Features.Shipments;

namespace ShippingOrderService.Web.Infrastructure.Persistence.Repositories;

public class ShipmentRepository(ShipmentDbContext _context) : IShipmentRepository
{
    public async Task<Shipment> GetById(Ulid id)
    {
        return await _context.Shipments
            .FindAsync(id);
    }

    public async Task<Shipment> Create(Shipment shipmentToCreate)
    {
        var createdShipment = await _context.Shipments.AddAsync(shipmentToCreate);
        await _context.SaveChangesAsync();

        return createdShipment.Entity;
    }
}