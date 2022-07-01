using AutoMapper;
using LGPD_API.AutoMapping;
using LGPD_API.Infra.Extensions;
using LGPD_BLL.AutoMapping;
using LGPD_IoC;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.OpenApi.Models;

namespace LGPD_API
{
    public class Startup : IStartup
    {
        public IConfiguration Configuration { get; }


        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            //services.AddRazorPages();
            services.AddHttpClient();
            services.AddSQLDatabase(Configuration);
            services.AddRepositories();
            services.AddService();
            services.RegisterWebApiServices();
            services.RegisterPolicies();
            services.AddJWTAuth(Configuration);
            services.AddMvc();
            services.TryAddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            var mapConf = new MapperConfiguration(x =>
            {
                x.AddProfile(new AutoMappingApi());//model <-> DTO
                x.AddProfile(new AutoMappingBLL());//DTO <-> entity
            });

            IMapper mapper = mapConf.CreateMapper();
            services.AddSingleton(mapper);



            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc(Configuration["Application:Version"], new OpenApiInfo { Title = Configuration["Application:Title"], Version = Configuration["Application:Version"] });
                c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
                {
                    Name = "Authorization",
                    Type = SecuritySchemeType.ApiKey,
                    Scheme = "Bearer",
                    BearerFormat = "JWT",
                    In = ParameterLocation.Header,
                    Description = "JWT Authorization header using the Bearer scheme."
                });
                c.AddSecurityRequirement(new OpenApiSecurityRequirement
                {
                    {
                          new OpenApiSecurityScheme
                            {
                                Reference = new OpenApiReference
                                {
                                    Type = ReferenceType.SecurityScheme,
                                    Id = "Bearer"
                                }
                            },
                            new string[] {}
                    }
                });
            });

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(WebApplication app, IWebHostEnvironment environment)
        {
            if (environment.IsDevelopment())
                app.UseDeveloperExceptionPage();
            app.UseCustomExceptionHandler();
            app.UseHttpsRedirection();
            app.UseAuthorization();
            app.MapControllers();
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.RoutePrefix = "";
                c.SwaggerEndpoint("/swagger/v1/swagger.json", Configuration["Application:Title"]);
            });
        }

    }

    public interface IStartup
    {
        IConfiguration Configuration { get; }
        void Configure(WebApplication app, IWebHostEnvironment environment);
        void ConfigureServices(IServiceCollection services);
    }

    public static class StartupExtensions
    {
        public static WebApplicationBuilder UseStartup<TStartup>(this WebApplicationBuilder WebAppABuilder) where TStartup : IStartup
        {
            var startup = Activator.CreateInstance(typeof(TStartup), WebAppABuilder.Configuration) as IStartup;
            if (startup == null) throw new ArgumentException("Classe Startup.cs invÃ¡lida");
            startup.ConfigureServices(WebAppABuilder.Services);
            var app = WebAppABuilder.Build();
            startup.Configure(app, app.Environment);
            app.Run();

            return WebAppABuilder;
        }
    }
}
