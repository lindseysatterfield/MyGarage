using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGarage.Watercrafts
{
    class WatercraftBase : VehicleBase
    {
        public bool IsDocked { get; set; }

        public void DockedWatercraft()
        {
            if (IsDocked)
            {
                Console.WriteLine("The watercraft is docked.");
            } else
            {
                Console.WriteLine("The watercraft is not docked and is out in the ocean.");
            }
        }
    }
}
