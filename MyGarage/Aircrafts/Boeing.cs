using MyGarage.Aircrafts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGarage
{
    class Boeing : AircraftBase
    {
        public override void Refuel()
        {
            Console.WriteLine($"The 737 needs to stop at BNA to refuel {FuelCapacity} gallons.");
        }

        public override void Flying()
        {
            Console.WriteLine($"The Boeing 737 has flying range of 3800 miles.");
        }
    }
}
