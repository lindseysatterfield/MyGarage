using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGarage
{
    class VehicleBase
    {
        public int FuelCapacity { get; set; }
        public string Color { get; set; }
        public int PassengerCount { get; set; }

        public virtual void Refuel()
        {
            Console.WriteLine($"It needs {FuelCapacity} gallons before it runs out of fuel!");
        }

        public virtual void Driving()
        {
            Console.WriteLine($"To keep driving, you need to put {FuelCapacity} gallons in the tank.");
        }
    }
}
