using Domain.Interfaces.Repository;
using Infra.Repository;
using Microsoft.Extensions.DependencyInjection;
namespace App_UrnaEletronica.AppConfig
{
    public static class DependencyInjectionConfig
    {
        public static IServiceCollection AddRepositoriesDI(this IServiceCollection services)
        {
            services.AddTransient<ICandidatoRepository, CandidatoRepository>();
            services.AddTransient<IVotoRepository, VotoRepository>();
            return services;
        }
        public static IServiceCollection AddServicesDI(this IServiceCollection services)
        {

            return services;
        }

        public static IServiceCollection AddSwaggerCustom(this IServiceCollection services)
        {
            services.AddSwaggerGen(options =>
            {
                options.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo
                {
                    Title = "Api Urna Eletrônica",
                    Version = "v1",
                    Description = "",
                });
            });
            return services;
        }

    }
}