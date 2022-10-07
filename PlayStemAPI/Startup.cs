using PlayStemAPI.ServicesConfiguration;

namespace PlayStemAPI
{
    public class Startup
    {
        public static IConfiguration Configuration { get; set; }    
        public static IHostEnvironment HostEnvironment { get; set; }

        public Startup(IConfiguration configuration, IHostEnvironment environment)
        {
            Configuration = configuration;
            HostEnvironment = environment;
        }

        public static WebApplication InitiateApp(string[] parameters)
        {
            var builder = WebApplication.CreateBuilder(parameters);

            builder.Logging.ClearProviders();

            ConfigureServices(builder);

            // configurePolicies when JWT token - TODO

            var app = builder.Build();

            Configure(app);

            return app;
        }

        private static void ConfigureServices(WebApplicationBuilder builder)
        {
            AstronomyServiceConfiguration.ConfigureDependencyInjection(builder.Services, builder.Configuration);
            PlayStemServiceConfiguration.ConfigureDependencyInjection(builder.Services, builder.Configuration);
            MvcServiceConfiguration.AddControllers(builder.Services);
            SwaggerServiceConfiguration.AddSwaggerService(builder.Services);

            builder.Services.AddHttpClient();
        }

        private static void Configure(WebApplication app)
        {
            //app.ConfigureCustomExceptionMiddleware -- missing - TBD

            app.UseForwardedHeaders();

            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }
            else
            {
                app.UseHsts();
            }

            app.UseAuthorization();

            app.MapControllers();
        }
    }
}
