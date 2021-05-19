﻿using Microsoft.Extensions.DependencyInjection;

namespace RetoSisteBack.Application.Extension
{
    public static class CorsExtension
    {
        public static IServiceCollection AddCorsExtension(this IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddPolicy("mycors",
                builder =>
                {
                    builder.AllowAnyHeader()
                    .AllowAnyMethod()
                    .AllowAnyOrigin();
                });
            });
            return services;
        }
    }
}
