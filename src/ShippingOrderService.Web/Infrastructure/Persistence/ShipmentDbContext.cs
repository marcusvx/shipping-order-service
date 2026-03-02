using Microsoft.EntityFrameworkCore;
using ShippingOrderService.Web.Features.Shipments;

namespace ShippingOrderService.Web.Infrastructure.Persistence;

public class ShipmentDbContext(DbContextOptions<ShipmentDbContext> options) : DbContext(options)
{
    public DbSet<Shipment> Shipments => Set<Shipment>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(
            typeof(ShipmentDbContext).Assembly);
    }
}