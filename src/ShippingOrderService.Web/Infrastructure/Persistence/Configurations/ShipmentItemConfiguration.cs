using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShippingOrderService.Web.Features.Shipments;

namespace ShippingOrderService.Web.Infrastructure.Persistence.Configurations;

public class ShipmentItemConfiguration : IEntityTypeConfiguration<ShipmentItem>
{
    public void Configure(EntityTypeBuilder<ShipmentItem> builder)
    {
        builder.ToTable("shipment_items");
        
        builder.HasKey(c => c.Id);
        builder.Property(c => c.Description)
            .IsRequired();
        builder.Property(c => c.Weight);
        builder.Property(c => c.Quantity);
        builder.Property(c => c.IsFragile);

        builder.OwnsOne(i => i.Dimensions, d =>
        {
            d.Property(x => x.WidthCm).HasColumnName("dimension_width_cm").HasPrecision(8, 2);
            d.Property(x => x.HeightCm).HasColumnName("dimension_height_cm").HasPrecision(8, 2);
            d.Property(x => x.DepthCm).HasColumnName("dimension_depth_cm").HasPrecision(8, 2);
        });
    }
}