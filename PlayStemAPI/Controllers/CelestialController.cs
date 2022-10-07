using Microsoft.AspNetCore.Mvc;
using PlayStem;

namespace PlayStemAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CelestialController : ControllerBase
    {
        private readonly IPlayStemService _playStemService;
        private readonly IAstronomyService _astronomyService;

        public CelestialController(IPlayStemService playStemService, IAstronomyService astronomyService)
        {
            _playStemService = playStemService;
            _astronomyService = astronomyService;
        }


        [HttpGet("position")]
        public async Task<Cosmos> RetrieveCelestialBodies()
        {
            var resp = _playStemService.GetCosmoAndCelestial();
            return resp;
        }
    }
}
