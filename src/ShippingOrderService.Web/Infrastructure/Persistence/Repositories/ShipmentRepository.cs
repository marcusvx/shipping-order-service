using ShippingOrderService.Web.Features.Shipments;

namespace ShippingOrderService.Web.Infrastructure.Persistence.Repositories;

public class ShipmentRepository(ShipmentDbContext _context) : IShipmentRepository
{
    public async Task<Shipment> GetById(Guid uuid)
    {
        return await _context.Shipments.FindAsync(uuid);
    }
}