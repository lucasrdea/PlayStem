
using CosineKitty;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PlayStem;
using System.Security.Cryptography.X509Certificates;

namespace PlayStemAPI.ServicesConfiguration
{
    public class PlayStemServiceConfiguration
    {
        public static void ConfigureDependencyInjection(IServiceCollection services, IConfiguration configuration)
        {
            services.AddSingleton<IPlayStemService, PlayStemService>();            
        }
    }
}
