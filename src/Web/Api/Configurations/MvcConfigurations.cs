using System.Globalization;
using System.Text.Json.Serialization;
using FluentValidation.AspNetCore;
using MelhorEnvios.Validators.Delivery;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace MelhorEnvios.Configurations;

public static class MvcConfigurations
{
    public static void AddMvcConfigurations(this IServiceCollection services)
    {
        services.AddControllers()
            .AddNewtonsoftJson(x =>
            {
                x.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
                x.SerializerSettings.Converters.Add(new StringEnumConverter());
            })
            .AddJsonOptions(x => { x.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter()); })
            .AddFluentValidation(x =>
            {
                x.RegisterValidatorsFromAssemblyContaining<ShippingProductsRequestValidator>();
                x.RegisterValidatorsFromAssemblyContaining<ShippingRequestValidator>();
                x.ValidatorOptions.LanguageManager.Culture = new CultureInfo("pt-BR");
            });
    }
}