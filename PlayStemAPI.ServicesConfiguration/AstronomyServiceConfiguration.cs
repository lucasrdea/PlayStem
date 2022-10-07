using CosineKitty;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PlayStem;

namespace PlayStemAPI.ServicesConfiguration
{
    public class AstronomyServiceConfiguration
    {
        public static void ConfigureDependencyInjection(IServiceCollection services, IConfiguration configuration)
        {

            Cosmos _cosmo;

            // TERRIBLE - TBD
            _cosmo = new Cosmos(); // number of planets
            _cosmo.celestial = new CelestialBody[9];
            _cosmo.celestial[0] = new CelestialBody();
            _cosmo.celestial[1] = new CelestialBody();
            _cosmo.celestial[2] = new CelestialBody();
            _cosmo.celestial[3] = new CelestialBody();
            _cosmo.celestial[4] = new CelestialBody();
            _cosmo.celestial[5] = new CelestialBody();
            _cosmo.celestial[6] = new CelestialBody();
            _cosmo.celestial[7] = new CelestialBody();
            _cosmo.celestial[8] = new CelestialBody();

            _cosmo.celestial[0].body = Body.Sun;
            _cosmo.celestial[0].isSun = true;
            _cosmo.celestial[1].body = Body.Mercury;
            _cosmo.celestial[2].body = Body.Venus;
            _cosmo.celestial[3].body = Body.Earth;
            _cosmo.celestial[4].body = Body.Mars;
            _cosmo.celestial[5].body = Body.Jupiter;
            _cosmo.celestial[6].body = Body.Saturn;
            _cosmo.celestial[7].body = Body.Uranus;
            _cosmo.celestial[8].body = Body.Neptune;

            services.AddSingleton<IAstronomyService, AstronomyService>(serviceProvider => new AstronomyService(_cosmo));
        }
    }
}
