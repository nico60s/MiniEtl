

using Microsoft.Extensions.DependencyInjection;
using MiniEtl.Common;
using MiniEtl.Excel.Adapters;
using MiniEtl.Excel.Models;
using MiniEtl.Excel.Schemas;

namespace MiniEtl.Excel
{
    public static class MiniEtlExcelDependencyInjection
    {
        public static IServiceCollection AddMiniEtlExcelServices
            (this IServiceCollection services)
        {
            services.AddScoped<IMiniEtlService<MiniEtlExcelResponse>, MiniEtlExcelService>();
            services.AddSingleton<IMiniEtlResponse<WorkBook>, MiniEtlExcelResponse>();
            services.AddSingleton<IMiniEtlExcelExtractSchema, MiniEtlExcelExtractSchema>();
            return services;
        }
    }
}
