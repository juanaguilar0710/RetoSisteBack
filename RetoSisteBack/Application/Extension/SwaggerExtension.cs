using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using System;

namespace RetoSisteBack.Application.Extension
{
    public static class SwaggerExtension
    {
        public static IServiceCollection AddSwaggerExtension(this IServiceCollection services, IConfiguration configuration)
        { 
            services.AddSwaggerGen(options =>
            {
                var groupName = "v1";

                options.SwaggerDoc(groupName, new OpenApiInfo
                {
                    Title = $"Reto {groupName}",
                    Version = groupName,
                    Description = "Reto Sistecrédito",
                    Contact = new OpenApiContact
                    {
                        Name = "Reto SisteCredito",
                        Email = string.Empty,
                        Url = new Uri("https://www.sistecredito.com/"),
                    }
                });
            });

            return services;
        }
    }
}
