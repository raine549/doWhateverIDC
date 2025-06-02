using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleOOP
{
    class Car 
    {

        public int gasolineAmount;
        public void drive()
        {
            if (gasolineAmount > 0)
            {
                Console.WriteLine("The car is driving.");
            }
            else
            {
                Console.WriteLine("The car cannot drive, it needs to be refueled.");
            }
        }

        public bool refuel(int amount)
        {
            gasolineAmount += amount;
            return true;
        }
      
    }
}
