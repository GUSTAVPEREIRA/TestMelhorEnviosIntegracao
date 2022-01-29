using Application.Cart;
using Application.Delivery;
using Core.Cart.Interfaces;
using Core.Delivery.Interfaces;
using Core.Request;
using Infrastructure.Cart;
using Infrastructure.Delivery;

namespace MelhorEnvios.Configurations;

public static class DependencyInjectionConfiguration
{
    public static void AddDependencyInjection(this IServiceCollection service)
    {
        service.AddScoped<IShippingRepository, ShippingRepository>();
        service.AddScoped<IShippingService, ShippingService>();
        service.AddScoped<IShoppingCartRepository, ShoppingCartRepository>();
        service.AddScoped<IShoppingCartService, ShoppingCartService>();
        service.AddScoped<IHttpRequest, Infrastructure.Request.HttpRequest>();
    }
}