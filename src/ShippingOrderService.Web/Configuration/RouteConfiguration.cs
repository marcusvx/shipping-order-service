using ShippingOrderService.Web.Common.Routing;

namespace ShippingOrderService.Web.Configuration;

public static class RouteConfiguration
{
    public static IServiceCollection AddRouteConstraints(this IServiceCollection services)
    {
        return services.Configure<RouteOptions>(options =>
            options.ConstraintMap.Add("ulid", typeof(UlidRouteConstraint)));
    }
}