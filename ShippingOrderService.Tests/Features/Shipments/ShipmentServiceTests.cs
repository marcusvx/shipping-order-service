using Moq;
using ShippingOrderService.Tests.Builders;
using ShippingOrderService.Web.Features.Shipments;
using Shouldly;

namespace ShippingOrderService.Tests.Features.Shipments;

public class ShipmentServiceTests
{
    private const int FAKER_SEED = 999313;
    private readonly ShipmentService _shipmentService;
    private readonly ShipmentFaker _shipmentFaker;
    private readonly Mock<IShipmentRepository> _shipmentRepositoryMock;

    public ShipmentServiceTests()
    {
        _shipmentRepositoryMock = new Mock<IShipmentRepository>();
        _shipmentService = new ShipmentService(_shipmentRepositoryMock.Object);
        _shipmentFaker = new ShipmentFaker();
        _shipmentFaker.UseSeed(FAKER_SEED);
    }

    [Fact]
    public async Task Test_GetById_Returns_Shipment()
    {
        // Arrange
        var shipment = _shipmentFaker.Generate();
        _shipmentRepositoryMock.Setup(x => x.GetById(shipment.Id)).ReturnsAsync(shipment);

        // Act
        var result = await _shipmentService.GetById(shipment.Id);

        // Assert
        result.ShouldBe(shipment);
    }
}