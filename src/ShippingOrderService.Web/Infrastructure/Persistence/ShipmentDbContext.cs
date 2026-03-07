using Microsoft.EntityFrameworkCore;
using ShippingOrderService.Web.Domain.Shipments;
using ShippingOrderService.Web.Infrastructure.Persistence.Configurations.Converters;

namespace ShippingOrderService.Web.Infrastructure.Persistence;

public class ShipmentDbContext(DbContextOptions<ShipmentDbContext> options) : DbContext(options)
{
    public DbSet<Shipment> Shipments => Set<Shipment>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.HasPostgresEnum<ShipmentStatus>();
        modelBuilder.HasPostgresEnum<ShipmentPriority>();

        modelBuilder.ApplyConfigurationsFromAssembly(
            typeof(ShipmentDbContext).Assembly);
    }

    protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
    {
        configurationBuilder
            .Properties<Ulid>()
            .HaveConversion<UlidToStringConverter>();
    }
}