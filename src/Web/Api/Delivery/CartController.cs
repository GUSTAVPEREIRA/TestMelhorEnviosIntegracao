using Core.Cart;
using Core.Cart.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace MelhorEnvios.Delivery;

[Route("api/[controller]")]
[ApiController]
public class CartController : ControllerBase
{
    private readonly IShoppingCartService _cartService;

    public CartController(IShoppingCartService cartService)
    {
        _cartService = cartService;
    }

    [HttpPost]
    [Route("add")]
    public async Task<IActionResult> AddCartAsync(ShoppingCartRequest shoppingCartRequest)
    {
        var cartOrderResponse = await _cartService.AddCartAsync(shoppingCartRequest);

        return Ok(cartOrderResponse);
    }
}