using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleOOP
{
    interface IVehicle
    {
        void drive();
        bool refuel(int amount);
    }
}
