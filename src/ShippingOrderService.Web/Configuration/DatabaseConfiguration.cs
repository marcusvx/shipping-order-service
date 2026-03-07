// Configuration/DatabaseConfiguration.cs

using Microsoft.EntityFrameworkCore;
using ShippingOrderService.Web.Domain.Shipments;
using ShippingOrderService.Web.Infrastructure.Persistence;
using ShippingOrderService.Web.Infrastructure.Persistence.Seeders;

namespace ShippingOrderService.Web.Configuration;

public static class DatabaseConfiguration
{
    public static IServiceCollection AddDatabase(
        this IServiceCollection services,
        IConfiguration configuration)
    {
        services.AddDbContext<ShipmentDbContext>(options =>
            options.UseNpgsql(
                    configuration.GetConnectionString("Default"),
                    npgsqlOptions =>
                    {
                        npgsqlOptions.MapEnum<ShipmentStatus>();
                        npgsqlOptions.MapEnum<ShipmentPriority>();

                        npgsqlOptions.EnableRetryOnFailure(
                            maxRetryCount: 3,
                            maxRetryDelay: TimeSpan.FromSeconds(30),
                            errorCodesToAdd: null);
                        npgsqlOptions.CommandTimeout(60);
                    })
                .UseSnakeCaseNamingConvention());

        return services;
    }

    extension(WebApplication app)
    {
        public async Task MigrateDatabaseAsync()
        {
            using var scope = app.Services.CreateScope();
            var context = scope.ServiceProvider.GetRequiredService<ShipmentDbContext>();
            await context.Database.MigrateAsync();
        }

        public async Task SeedDatabaseAsync()
        {
            using var scope = app.Services.CreateScope();
            var seeder = scope.ServiceProvider.GetRequiredService<ShipmentSeeder>();
            await seeder.SeedAsync();
        }
    }
}