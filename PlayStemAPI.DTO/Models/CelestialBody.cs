using CosineKitty;
using PlayStemAPI.Models.Enum;
using System.Numerics;

namespace PlayStemAPI
{
    public class CelestialBody
    {
        //public PlanetEnum Planet { get; set; }
        public Vector3 position { get; set; }
        public Body body { get; set; }
        public bool isSun { get; set; }

        //mass
        //size
        //does it have water
        //number of moons
        //iada iada
    }
}