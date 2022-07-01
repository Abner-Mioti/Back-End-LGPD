
using LGPD_BLL.Services;
using LGPD_BLL_Infra.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace LGPD_IoC
{
    public static class DiService
    {
        public static IServiceCollection AddService(this IServiceCollection services)
        {
            services.AddScoped<IWorkshopService, WorkshopService>();
            services.AddScoped<IExceptionService, ExceptionService>();
            services.AddScoped<IEnterpriseService, EnterpriseService>();
            services.AddScoped<IFieldService, FieldService>();
            services.AddScoped<IEnterpriseCategoryService, EnterpriseCategoryService>();
            services.AddScoped<IReportPeriodService, ReportPeriodService>();
            services.AddScoped<IAreaService, AreaService>();
            services.AddScoped<IQuestionCategoryService, QuestionCategoryService>();
            services.AddScoped<IImpactService, ImpactService>();


            return services;
        }

    }
}
