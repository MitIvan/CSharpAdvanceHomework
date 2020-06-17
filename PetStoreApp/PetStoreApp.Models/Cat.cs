using System;
using System.Collections.Generic;
using System.Text;

namespace PetStoreApp.Models
{
    public class Cat : Pet
    {
        public bool Lazy { get; set; }
        public int LivesLeft { get; set; }
        
        public Cat()
        {
            
        }

        public Cat(string name, int age, bool lazy, int livesLeft)
        {
            Name = name;
            Age = age;
            Lazy = lazy;
            LivesLeft = livesLeft;
            Type = "Cat";

        }

        public override void PrintInfo()
        {
            Console.WriteLine($"The {Type} {Name} has {LivesLeft} lives left");
        }
    }
}
