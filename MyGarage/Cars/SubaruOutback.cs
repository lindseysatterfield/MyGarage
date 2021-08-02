using MyGarage.Cars;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGarage
{
    class SubaruOutback : CarBase
    {
        public override void Refuel()
        {
            Console.WriteLine("The Outback needs 20 gallons to refuel the tank.");
        }

        public override void Driving()
        {
            Console.WriteLine($"The Outback holds {FuelCapacity} gallons and needs at least 1 gallon to keep running.");
        }

        public void SubaruDogs()
        {
            Console.WriteLine("The Outback can fit five golden retrievers total.");
        }
    }
}
