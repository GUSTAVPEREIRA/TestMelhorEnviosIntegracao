using Core.Cart.Models;

namespace Core.Cart.Interfaces;

public interface IShoppingCartRepository
{
    public Task<CartOrderResponse> AddCartAsync(ShoppingCartRequest shoppingCartRequest);
}