using ShippingOrderService.Web.Features.Shipments;
using ShippingOrderService.Web.Infrastructure.Persistence.Repositories;
using ShippingOrderService.Web.Infrastructure.Persistence.Seeders;

namespace ShippingOrderService.Web.Configuration;

public static class ShipmentConfiguration
{
    public static IServiceCollection AddShipment(this IServiceCollection serviceCollection)
    {
        serviceCollection.AddScoped<ShipmentSeeder>();
        serviceCollection.AddScoped<IShipmentService, ShipmentService>();
        serviceCollection.AddScoped<IShipmentRepository, ShipmentRepository>();
        return serviceCollection;
    }
}