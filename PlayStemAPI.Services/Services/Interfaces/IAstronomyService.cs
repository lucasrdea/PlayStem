using PlayStemAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayStem
{
    public interface IAstronomyService
    {
        void SetUserLocation(); 
        Cosmos GetPositions();
    }
}
