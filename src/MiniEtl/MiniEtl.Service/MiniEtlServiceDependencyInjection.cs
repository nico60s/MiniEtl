

using Microsoft.Extensions.DependencyInjection;

namespace MiniEtl.Service
{
    public static class MiniEtlServiceDependencyInjection
    {
        public static IServiceCollection AddMiniEtlService(this IServiceCollection services)
        {
            services.AddScoped<IMiniEtlService, MiniEtlService>();
            return services;
        }
    }
}
