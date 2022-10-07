using System.Numerics;
using CosineKitty;
using PlayStemAPI;

namespace PlayStem
{
    public class PlayStemService : IPlayStemService
    {
        private readonly IAstronomyService _astronomyService;
        private readonly Cosmos _cosmo;
        
        public PlayStemService(IAstronomyService astronomyService)
        {
            _astronomyService = astronomyService;            
        }

        
        
        public Cosmos GetCosmoAndCelestial()
        {
            return _astronomyService.GetPositions();
        }

        public void SetUserLocation()
        {
            throw new NotImplementedException();
        }
    }
}
