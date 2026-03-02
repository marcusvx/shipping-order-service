using Microsoft.AspNetCore.Mvc;

namespace ShippingOrderService.Web.Features.Shipments;

[ApiController]
[Route("api/[controller]")]
public class ShipmentsController(IShipmentService shipmentService) : ControllerBase
{
    private readonly IShipmentService shipmentService = shipmentService;

    [HttpGet("{id:guid}")]
    public async Task<IActionResult> GetById(Guid id)
    {
        var result = await shipmentService.GetById(id);
        return result == null ? NotFound() : Ok(result);
    }
}