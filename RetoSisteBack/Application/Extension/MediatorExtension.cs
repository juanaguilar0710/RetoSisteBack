using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace RetoSisteBack.Application.Extension
{
    public static class MediatorExtension
    {
        public static IServiceCollection AddMediatorExtension(this IServiceCollection services)
        {
            services.AddMediatR(typeof(Startup));
            return services;
        }
    }
}
