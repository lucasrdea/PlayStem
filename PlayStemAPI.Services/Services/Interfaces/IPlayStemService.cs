using PlayStemAPI;

namespace PlayStem
{
    public interface IPlayStemService
    {
        void SetUserLocation();
        Cosmos GetCosmoAndCelestial();
    }
}
