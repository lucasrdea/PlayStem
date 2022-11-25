using CosineKitty;
using PlayStemAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace PlayStem
{
    public class AstronomyService : IAstronomyService
    {
        private readonly string _userposition;
        private readonly Cosmos _cosmo;
        private readonly DateTime _dateTime;
        private readonly float _secondToDaysFactor = 1f;
        private readonly float _planetDistanceConvertMultiplier = 1f;
        private int _daysToAdd = 0;

        public AstronomyService(Cosmos cosmos)
        {
            // nth atm.
            _cosmo = cosmos;
        }

        private void getCelestialPosition()
        {
            var date = new DateTime(2014, 05, 05); // not in use as of now
            float delta = DateTime.Now.Subtract(DateTime.Now).Seconds * _secondToDaysFactor; // same here

            DateTime simulationTime = DateTime.Now.AddDays(_daysToAdd);
            foreach (var planet in _cosmo.celestial)
            {
                AstroVector av = Astronomy.HelioVector(planet.body, new AstroTime(simulationTime));

                planet.position = new Vector3(
                                    Convert.ToSingle(av.x),
                                    Convert.ToSingle(av.y),
                                    Convert.ToSingle(av.z)) * _planetDistanceConvertMultiplier;
            }
            _daysToAdd++; // faking time passing by
        }

        public Cosmos GetPositions()
        {
            getCelestialPosition();
            return _cosmo;
        }

        public void SetUserLocation()
        {
            throw new NotImplementedException();
        }
    }
}
