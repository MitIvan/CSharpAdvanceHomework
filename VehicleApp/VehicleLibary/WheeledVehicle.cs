using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleLibary
{
    public abstract class WheeledVehicle : Vehicle 
    {
        public int NumOfWheeles { get; set; }

        public string Type { get; set; }

        public WheeledVehicle() { }


    }
}
