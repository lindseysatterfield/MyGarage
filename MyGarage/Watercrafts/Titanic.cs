using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGarage.Watercrafts
{
    class Titanic : WatercraftBase
    {
       public void TitanicSank()
        {
            Console.WriteLine("Unfortantely the Titanic hit an iceberg and sank.");
        }

        public override void Driving()
        {
            Console.WriteLine("The Titanic was driven by a captain.");
        }

        public override void Refuel()
        {
            Console.WriteLine("Coal was used to keep the Titanic running.");
        }
    }
}
