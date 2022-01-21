using Application.Delivery;
using Core.Delivery.Interfaces;
using Core.Request;
using Infrastructure.Delivery;
using HttpRequest = Infrastructure.Request.HttpRequest;

namespace MelhorEnvios.Configurations;

public static class DependencyInjectionConfiguration
{
    public static void AddDependencyInjection(this IServiceCollection service)
    {
        service.AddScoped<IShippingRepository, ShippingRepository>();
        service.AddScoped<IShippingService, ShippingService>();
        service.AddScoped<IHttpRequest, HttpRequest>();
    }
}