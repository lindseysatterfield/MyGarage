using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGarage.Aircrafts
{
    class AircraftBase : VehicleBase
    {
        public virtual void Flying()
        {
            Console.WriteLine($"The plane loves to fly.");
        }

        public void Landing()
        {
            Console.WriteLine($"The {Color} plane lands at BNA.");
        }
    }
}
