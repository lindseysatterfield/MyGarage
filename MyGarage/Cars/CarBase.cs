using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGarage.Cars
{
    class CarBase : VehicleBase
    {
        public void Braking()
        {
            Console.WriteLine($"Keep braking too much and all {PassengerCount} passengers will start to get car sick!");
        }
    }
}
