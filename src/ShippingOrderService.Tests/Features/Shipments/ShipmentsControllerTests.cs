using FluentValidation;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using Moq;
using ShippingOrderService.Tests.Builders;
using ShippingOrderService.Web.Common;
using ShippingOrderService.Web.Domain.Shipments;
using ShippingOrderService.Web.Features.Shipments;
using Shouldly;

namespace ShippingOrderService.Tests.Features.Shipments;

public class ShipmentsControllerTests
{
    private const int SEED = 999292;

    private readonly Mock<IShipmentService> _shipmentServiceMock = new();
    private readonly Mock<IValidator<CreateShipmentRequest>> _validatorMock = new();
    private readonly ShipmentFaker _shipmentFaker = new();
    private readonly CreateShipmentRequestFaker _requestFaker = new();
    private readonly ShipmentsController _controller;

    public ShipmentsControllerTests()
    {
        _shipmentFaker.UseSeed(SEED);
        _controller = new ShipmentsController(_shipmentServiceMock.Object, _validatorMock.Object);
    }

    [Fact]
    public async Task Test_Create_ShouldReturnOkResultWithData_WhenRequestIsValid()
    {
        // Arrange
        var request = _requestFaker.Generate();
        var validationResult = new ValidationResult();
        _validatorMock.Setup(x => x.ValidateAsync(request, It.IsAny<CancellationToken>()))
            .ReturnsAsync(validationResult);

        var expectedShipment = _shipmentFaker.Generate();
        _shipmentServiceMock.Setup(x => x.Create(request))
            .ReturnsAsync(DomainResult<Shipment>.Success(expectedShipment));

        // Act
        var result = await _controller.Create(request);

        // Assert
        var okResult = result.ShouldBeOfType<OkObjectResult>();
        var response = okResult.Value.ShouldBeOfType<DomainResult<Shipment>>();
        response.Value.ShouldBe(expectedShipment);
    }

    [Fact]
    public async Task Test_Create_ShouldReturnBadRequestResult_WhenRequestIsNotValid()
    {
        // Arrange
        var request = _requestFaker.Generate();
        var errors = new List<ValidationFailure> { new("CustomerName", "CustomerName is required") };
        var validationResult = new ValidationResult(errors);
        _validatorMock.Setup(x => x.ValidateAsync(request, It.IsAny<CancellationToken>()))
            .ReturnsAsync(validationResult);

        var expectedShipment = _shipmentFaker.Generate();
        _shipmentServiceMock.Setup(x => x.Create(request))
            .ReturnsAsync(DomainResult<Shipment>.Success(expectedShipment));

        // Act
        var result = await _controller.Create(request);

        // Assert
        var badRequestObjectResult = result.ShouldBeOfType<BadRequestObjectResult>();
        var response = badRequestObjectResult.Value.ShouldBeOfType<ValidationProblemDetails>();
        response.Errors.ShouldContainKey("CustomerName");
    }
}