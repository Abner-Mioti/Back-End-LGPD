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
            services.AddScoped<ICompanyRepository, CompanyRepository>();
            services.AddScoped<IFieldRepository, FieldRepository>();
            services.AddScoped<ICompanyCategoryRepository, CompanyCategoryRepository>();
            services.AddScoped<IReportPeriodRepository, ReportPeriodRepository>();
            services.AddScoped<IAreaRepository, AreaRepository>();
            services.AddScoped<IQuestionCategoryRepository, QuestionCategoryRepository>();
            services.AddScoped<IImpactRepository, ImpactRepository>();
            services.AddScoped<IProbabilityRepository, ProbabilityRepository>();
            services.AddScoped<IQuestionRepository, QuestionRepository>();
            services.AddScoped<IRiskRepository, RiskRepository>();

            return services;
        }


    }
}
