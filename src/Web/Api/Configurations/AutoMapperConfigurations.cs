using Core.Delivery.Mappings;

namespace MelhorEnvios.Configurations;

public static class AutoMapperConfigurations
{
    public static void AddAutoMapper(this IServiceCollection services)
    {
        services.AddAutoMapper(x => { x.AddProfile(new ShippingMappingProfile()); });
    }
}