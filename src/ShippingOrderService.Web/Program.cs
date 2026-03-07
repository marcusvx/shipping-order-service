using ShippingOrderService.Web.Configuration;

var builder = WebApplication.CreateBuilder(args);

builder.Services
    .AddDatabase(builder.Configuration)
    .AddShipment()
    .AddOpenApiDocs()
    .AddValidation()
    .AddJsonOptions()
    .AddRouteConstraints();

var app = builder.Build();
app.UseOpenApiDocs();
app.UseHttpsRedirection();
app.MapControllers();

if (app.Environment.IsDevelopment())
{
    await app.MigrateDatabaseAsync();
    await app.SeedDatabaseAsync();
}

app.Run();