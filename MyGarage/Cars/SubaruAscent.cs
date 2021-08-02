using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGarage.Cars
{
    class SubaruAscent : CarBase
    {
        public override void Refuel()
        {
            Console.WriteLine("The Ascent needs 25 gallons to refuel the tank.");
        }

        public override void Driving()
        {
            Console.WriteLine($"The Ascent holds {FuelCapacity} gallons and needs at least 1 gallon to keep running.");
        }

        public void ThirdRow()
        {
            Console.WriteLine("The Ascent has a third row to fit more people or junk.");
        }
    }
}
