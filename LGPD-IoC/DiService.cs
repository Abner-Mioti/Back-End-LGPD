
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
            services.AddScoped<ICompanyService, CompanyService>();
            services.AddScoped<IFieldService, FieldService>();
            services.AddScoped<ICompanyCategoryService, CompanyCategoryService>();
            services.AddScoped<IReportPeriodService, ReportPeriodService>();
            services.AddScoped<IAreaService, AreaService>();
            services.AddScoped<IQuestionCategoryService, QuestionCategoryService>();
            services.AddScoped<IImpactService, ImpactService>();
            services.AddScoped<IProbabilityService, ProbabilityService>();
            services.AddScoped<IQuestionService, QuestionService>();
            services.AddScoped<IRiskService, RiskService>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IObservationService, ObservationService>();
            services.AddScoped<IStepService, StepService>();

            return services;
        }

    }
}
