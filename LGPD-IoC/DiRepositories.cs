using LGPD_Repository.Repositories;
using LGPD_Repository_Infra.Repositories.Interface;
using Microsoft.Extensions.DependencyInjection;

namespace LGPD_IoC
{
    public static class DiRepositories
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddScoped<IUsuarioRepository, UsuarioRepository>();
            services.AddScoped<IExceptionRepository, ExceptionRepository>();
            services.AddScoped<IWorkshopRepository, WorkshopRepository>();
            services.AddScoped<IEnterpriseRepository, EnterpriseRepository>();
            services.AddScoped<IFieldRepository, FieldRepository>();
            services.AddScoped<IEnterpriseCategoryRepository, EnterpriseCategoryRepository>();
            services.AddScoped<IReportPeriodRepository, ReportPeriodRepository>();
            services.AddScoped<IAreaRepository, AreaRepository>();
            services.AddScoped<IQuestionCategoryRepositoy, QuestionCategoryRepositoy>();
            services.AddScoped<IImpactRepository, ImpactRepository>();


            


            return services;
        }


    }
}
