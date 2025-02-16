
using Microsoft.Extensions.DependencyInjection;

namespace MiniEtl.Common
{
    public static class MiniEtlCommonDependencyInjection
    {
        public static IServiceCollection AddMiniEtlCommon(this IServiceCollection services) {

            services.AddScoped(typeof(IMiniEtlResponse<>), typeof(MiniEtlCommonResponse<>));
            services.AddScoped<IJsonService, JsonService>();
            return services;
        }
    }
}
