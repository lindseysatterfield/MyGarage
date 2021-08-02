using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGarage.Watercrafts
{
    class Mayflower : WatercraftBase
    {
        public void MayflowerPassengers()
        {
            Console.WriteLine($"The Mayflower carried {PassengerCount} people with half of them dying in the first winter.");
        }

        public override void Driving()
        {
            Console.WriteLine("The Mayflower was driven to America.");
        }

        public override void Refuel()
        {
            Console.WriteLine("The Mayflower used wind for refueling.");
        }
    }
}
