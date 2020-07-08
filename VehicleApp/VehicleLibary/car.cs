using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleLibary
{
    class car : WheeledVehicle , IRepair, Drive
    {
        public EnginTypeEnum EngineType { get; set; }
        public int FuleConsumption { get; set; }
        public int NumOfDoors { get; set; }
        public int MaxSpeed { get; set; }

        public car()
        {
            Id = 2;
            Type = "Car";
            NumOfWheeles = 4;
        }

        public car(string manufacturer, string model, EnginTypeEnum engine, int fuelConsumption, int numberOfDoors, int maxSpeed, int mass)
        {
            Manufacturer = manufacturer;
            Model = model;
            EngineType = engine;
            FuleConsumption = fuelConsumption;
            NumOfDoors = numberOfDoors;
            MaxSpeed = maxSpeed;
            Mass = mass;
        }

        public void Drive()
        {
            Console.WriteLine("Brrrrm, Brrrm ");
        }

        public void Repair()
        {
            Console.WriteLine("Repair the car");
        }
    }
}
