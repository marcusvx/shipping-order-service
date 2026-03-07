using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShippingOrderService.Web.Domain.Shipments;
using ShippingOrderService.Web.Features.Shipments;

namespace ShippingOrderService.Web.Infrastructure.Persistence.Configurations;

public class ShipmentConfiguration : IEntityTypeConfiguration<Shipment>
{
    public void Configure(EntityTypeBuilder<Shipment> builder)
    {
        builder.ToTable("shipments");

        builder.HasKey(p => p.Id);

        builder.Property(p => p.CustomerName)
            .IsRequired()
            .HasMaxLength(200)
            .HasColumnName("customer_name");

        builder.Property(p => p.OriginZipCode)
            .IsRequired()
            .HasMaxLength(10);

        builder.Property(p => p.DestinationZipCode)
            .IsRequired()
            .HasMaxLength(10);

        builder.Property(p => p.TotalValue).IsRequired();

        builder.Property(p => p.Priority);

        builder.HasMany(s => s.Items)
            .WithOne()
            .OnDelete(DeleteBehavior.Cascade);

        builder.Navigation(s => s.Items)
            .UsePropertyAccessMode(PropertyAccessMode.Field)
            .HasField("_items");
    }
}