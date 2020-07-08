using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleLibary
{
    public abstract class Vehicle : IDimensions
    {
        public int Id { get; set; }

        public  string Manufacturer { get; set; }

        public string Model { get; set; }

        public int Mass { get; set; }
        public int Height { get; set; }
        public int Length { get; set; }

        public Vehicle() { }

        public void PrintDimensions()
        {
            Console.WriteLine($"The Vehicle with {Id}#, manufacturer: {Manufacturer} and  model {Model} has a mass of {Mass}kg, height of {Height}cm and length {Length}cm") ;
        }
    }
}
