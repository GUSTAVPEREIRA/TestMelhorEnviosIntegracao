using Core.Delivery.Interfaces;
using Core.Delivery.Models;
using Microsoft.AspNetCore.Mvc;

namespace MelhorEnvios.Delivery;

[Route("api/[controller]")]
[ApiController]
public class ShippingController : ControllerBase
{
    private readonly IShippingService _shippingService;

    public ShippingController(IShippingService shippingService)
    {
        _shippingService = shippingService;
    }

    [HttpPost]
    [Route("calculate")]
    [ProducesResponseType(typeof(CalculateShippingResponse), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<IActionResult> ShippingCalculate(ShippingRequest shipping)
    {
        var result = await _shippingService.ShippingCalculateAsync(shipping);

        if (result == null)
        {
            return NotFound();
        }

        return Ok(result);
    }
}