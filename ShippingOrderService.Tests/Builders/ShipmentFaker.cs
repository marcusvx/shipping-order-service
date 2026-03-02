using Bogus;
using ShippingOrderService.Web.Features.Shipments;

namespace ShippingOrderService.Tests.Builders;

public class ShipmentFaker : Faker<Shipment>
{
    public ShipmentFaker()
    {
        RuleFor(x => x.Id, f => f.Random.Guid());
        RuleFor(x => x.CustomerName, f => f.Person.FullName);
        RuleFor(x => x.DestinationZipCode, f => f.Address.ZipCode("#####-###"));
        RuleFor(x => x.OriginZipCode, f => f.Address.ZipCode("#####-###"));
        RuleFor(s => s.TotalValue, f => f.Finance.Amount(100m, 50000m));
        RuleFor(s => s.Priority, f => f.PickRandom<ShipmentPriority>());
        RuleFor(s => s.Items, f => new ShipmentItemFaker().Generate(f.Random.Int(1, 5)));
    }
}

public class ShipmentItemFaker : Faker<ShipmentItem>
{
    public ShipmentItemFaker()
    {
        RuleFor(i => i.Id, f => f.Random.Guid());
        RuleFor(i => i.Description, f => f.Commerce.ProductName());
        RuleFor(i => i.Weight, f => f.Random.Decimal(0.5m, 50m));
        RuleFor(i => i.Quantity, f => f.Random.Int(1, 10));
        RuleFor(i => i.IsFragile, f => f.Random.Bool());
    }
}