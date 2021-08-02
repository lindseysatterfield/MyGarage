using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGarage.Aircrafts
{
    class AirForceOne : AircraftBase
    {
        public bool HasPresident { get; set; }

        public void IsPresidentOnBoard()
        {
            if (HasPresident)
            {
                Console.WriteLine("The President is on board Air Force One.");
            } else
            {
                Console.WriteLine("The President is not on board Air Force One.");
            }
        }

        public override void Refuel()
        {
            Console.WriteLine("Air Force One needs to stop at a military base to refuel.");
        }

        public override void Flying()
        {
            Console.WriteLine($"Air Force One can fly 7800 miles.");
        }
    }
}
