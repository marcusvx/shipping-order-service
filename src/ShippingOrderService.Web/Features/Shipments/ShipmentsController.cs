using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using ShippingOrderService.Web.Common.Extensions;

namespace ShippingOrderService.Web.Features.Shipments;

[ApiController]
[Route("api/[controller]")]
public class ShipmentsController(IShipmentService _shipmentService, IValidator<CreateShipmentRequest> _validator)
    : ControllerBase
{
    [HttpGet("{id:ulid}")]
    public async Task<IActionResult> GetById(Ulid id)
    {
        var result = await _shipmentService.GetById(id);
        return result == null ? NotFound() : Ok(result);
    }

    [HttpPost]
    public async Task<IActionResult> Create(CreateShipmentRequest request)
    {
        var validation = await _validator.ValidateAsync(request);
        if (!validation.IsValid)
            return BadRequest(validation.ToValidationProblemDetails());

        var created = _shipmentService.Create(request);

        return Ok(created.Result);
    }
}