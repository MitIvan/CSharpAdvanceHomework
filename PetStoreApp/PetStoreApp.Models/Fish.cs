using System;
using System.Collections.Generic;
using System.Text;

namespace PetStoreApp.Models
{
    public class Fish : Pet
    {
        public string Color { get; set; }
        public int Size { get; set; }

        public Fish()
        {
            
        }
        public Fish(string name, int age, string color, int size )
        {
            Name = name;
            Age = age;
            Color = color;
            Size = size;
            Type = "Fish";

        }

        public override void PrintInfo()
        {
            Console.WriteLine($"The {Type} {Name} is {Color} color");
        }
    }
}
