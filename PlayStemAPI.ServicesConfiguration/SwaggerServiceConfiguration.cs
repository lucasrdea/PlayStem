using Microsoft.Extensions.DependencyInjection;

namespace PlayStemAPI.ServicesConfiguration
{
    public static class SwaggerServiceConfiguration
    {
        public static void AddSwaggerService(IServiceCollection services)
        {
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen();
        }
    }
}
