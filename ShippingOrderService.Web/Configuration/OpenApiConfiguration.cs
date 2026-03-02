namespace ShippingOrderService.Web.Configuration;

public static class OpenApiConfiguration
{
    public static IServiceCollection AddOpenApiDocs(this IServiceCollection services)
    {
        services.AddOpenApi();
        return services;
    }

    public static WebApplication UseOpenApiDocs(this WebApplication app)
    {
        if (app.Environment.IsDevelopment())
            app.MapOpenApi();
        return app;
    }
}