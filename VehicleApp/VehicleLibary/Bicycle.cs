using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleLibary
{
    public class Bicycle : WheeledVehicle , IRepair
    {
        public int NumberOfSpeedLevels { get; set; }
        public bool IsElectric { get; set; }

        public Bicycle()
        {
            Id = 1;
            Type = "Bicycle";
            NumOfWheeles = 2;
            
        }

        public Bicycle(string manufacturer, string model, int numOfSpeedLevels, bool isElectric, int mass )
        {

            Manufacturer = manufacturer;
            Model = model;
            NumberOfSpeedLevels = numOfSpeedLevels;
            IsElectric = isElectric;
            Mass = mass;
            
        }

        public void Ride()
        {
            Console.WriteLine("Zooom, ZOOOOM");
        }

        public void Repair()
        {
            Console.WriteLine("Repair the bike");
        }
    }
}
