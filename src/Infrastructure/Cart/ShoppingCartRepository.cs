using Core.Cart;
using Core.Cart.Interfaces;
using Core.Cart.Models;
using Core.Configurations.Extenstions;
using Core.Request;
using Core.Request.Models;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;

namespace Infrastructure.Cart;

public class ShoppingCartRepository : IShoppingCartRepository
{
    private readonly IHttpRequest _httpRequest;
    private readonly IConfiguration _configuration;

    public ShoppingCartRepository(IHttpRequest httpRequest, IConfiguration configuration)
    {
        _httpRequest = httpRequest;
        _configuration = configuration;
    }

    public async Task<CartOrderResponse> AddCartAsync(ShoppingCartRequest shoppingCartRequest)
    {
        var settings = _configuration.GetSettings();

        var postHttpRequest = new PostHttpRequest
        {
            Url = settings.MelhorEnvios.Url + "/api/v2/me/cart",
            Body = JsonConvert.SerializeObject(shoppingCartRequest),
            Headers = new Dictionary<string, string> {{"Authorization", settings.MelhorEnvios.Token}}
        };

        var result = await _httpRequest.PostRequest(postHttpRequest);
        return JsonConvert.DeserializeObject<CartOrderResponse>(result);
    }
}