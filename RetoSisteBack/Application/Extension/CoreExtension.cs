using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using RetoSisteBack.Infraestructure.Repositories;
using RetoSisteBack.Infraestructure;
using RetoSisteBack.Settings;

namespace RetoSisteBack.Application.Extension
{
    public static class CoreExtension
    {
        public static IServiceCollection AddCoreExtension(this IServiceCollection services, IConfiguration configuration)
        {
            //Configuration
            services.Configure<GlobalSettings>(configuration);

            //repositories     
            services.AddTransient<ICreditsRepository, CreditsRepository>();            


            //tasks

            //Services            

            //HTTP Clients

            return services;
        }     
    }
}
