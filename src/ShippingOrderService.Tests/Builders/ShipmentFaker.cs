using Bogus;
using ShippingOrderService.Web.Domain.Shipments;

namespace ShippingOrderService.Tests.Builders;

public class ShipmentFaker : Faker<Shipment>
{
    public ShipmentFaker()
    {
        CustomInstantiator(f => Shipment.Create(
            customerName: f.Person.FullName,
            originZipCode: f.Address.ZipCode("#####-###"),
            destinationZipCode: f.Address.ZipCode("#####-###"),
            totalValue: f.Finance.Amount(100m, 50000m),
            priority: f.PickRandom<ShipmentPriority>(),
            items: new ShipmentItemFaker().Generate(f.Random.Int(1, 5))
        ));
    }
}

public class ShipmentItemFaker : Faker<ShipmentItem>
{
    public ShipmentItemFaker()
    {
        CustomInstantiator(f => ShipmentItem.Create(
            description: f.Commerce.ProductName(),
            weight: f.Random.Decimal(0.5m, 50m),
            quantity: f.Random.Int(1, 10),
            isFragile: f.Random.Bool(),
            dimensions: new Dimensions(
                f.Random.Decimal(10m, 100m),
                f.Random.Decimal(10m, 100m),
                f.Random.Decimal(5m, 80m))
        ));
    }
}