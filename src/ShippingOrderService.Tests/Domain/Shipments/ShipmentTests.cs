using Bogus;
using ShippingOrderService.Web.Domain.Shipments;
using Shouldly;

namespace ShippingOrderService.Tests.Domain.Shipments;

public class ShipmentTests
{
    [Fact]
    public void Test_Create_Shipment_Success()
    {
        // Arrange
        var faker = new Faker("pt_BR");
        var customerName = faker.Person.FullName;
        var originZipCode = faker.Address.ZipCode();
        var destinationZipCode = faker.Address.ZipCode();
        var totalValue = faker.Finance.Amount(100m, 50000m);
        var priority = faker.PickRandom<ShipmentPriority>();

        var item1 = ShipmentItem.Create(faker.Commerce.ProductDescription(), faker.Random.Decimal(1, 100),
            faker.Random.Int(1, 5), true,
            new Dimensions(faker.Random.Decimal(1, 100), faker.Random.Decimal(1, 100), faker.Random.Decimal(1, 50)));

        // Act
        var shipment = Shipment.Create(
            customerName,
            originZipCode,
            destinationZipCode,
            totalValue,
            priority,
            [item1]
        );

        // Assert
        shipment.CustomerName.ShouldBe(customerName);
        shipment.OriginZipCode.ShouldBe(originZipCode);
        shipment.DestinationZipCode.ShouldBe(destinationZipCode);
        shipment.TotalValue.ShouldBe(totalValue);
        shipment.Items.Count.ShouldBe(1);
        shipment.Items.First().ShouldBe(item1);
    }
}