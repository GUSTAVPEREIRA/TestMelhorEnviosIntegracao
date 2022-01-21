using System.Reflection;
using MicroElements.Swashbuckle.FluentValidation.AspNetCore;
using Microsoft.OpenApi.Models;

namespace MelhorEnvios.Configurations;

public static class SwaggerConfiguration
{
    public static void AddSwaggerConfiguration(this IServiceCollection services)
    {
        services.AddSwaggerGen(c =>
        {
            c.SwaggerDoc("v1",
                new OpenApiInfo
                {
                    Title = "Melhor Envios",
                    Version = "v1",
                    Description = "Api feita para testar a integração com o melhor envios",
                    Contact = new OpenApiContact
                    {
                        Email = "gugupereira123@hotmail.com",
                        Name = "Gustavo Antonio Pereira"
                    }
                });

            var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
            var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
            c.IncludeXmlComments(xmlPath);

            xmlPath = Path.Combine(AppContext.BaseDirectory, "Core.xml");
            c.IncludeXmlComments(xmlPath);
        });

        services.AddFluentValidationRulesToSwagger();
    }
}