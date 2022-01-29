using Core.Cart;
using Core.Cart.Interfaces;
using Core.Cart.Models;

namespace Application.Cart;

public class ShoppingCartService : IShoppingCartService
{
    private readonly IShoppingCartRepository _cartRepository;

    public ShoppingCartService(IShoppingCartRepository cartRepository)
    {
        _cartRepository = cartRepository;
    }

    public async Task<CartOrderResponse> AddCartAsync(ShoppingCartRequest shoppingCartRequest)
    {
        return await _cartRepository.AddCartAsync(shoppingCartRequest);
    }
}