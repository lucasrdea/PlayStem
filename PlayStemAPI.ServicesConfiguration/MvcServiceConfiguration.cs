
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PlayStem;
using PlayStemAPI.Filters;

namespace PlayStemAPI.ServicesConfiguration
{
    public class MvcServiceConfiguration
    {
        public static void AddControllers(IServiceCollection services)
        {
            services.AddControllers(options =>
            {
                options.Filters.Add(new ValidateModelStateFilter());
            })
                .AddNewtonsoftJson(JsonDefaultConfig.GetConfig);
        }
    }
}
