using Core.Cart.Models;

namespace Core.Cart.Interfaces;

public interface IShoppingCartService
{
    public Task<CartOrderResponse> AddCartAsync(ShoppingCartRequest shoppingCartRequest);
}