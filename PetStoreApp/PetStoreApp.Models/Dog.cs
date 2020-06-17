using System;
using System.Collections.Generic;
using System.Text;

namespace PetStoreApp.Models
{
    public class Dog : Pet
    {
        public bool GoodBoi { get; set; }

        public List<string> FavoriteFoods { get; set; }

        public Dog() 
        {
            
        }
        
        public Dog (string name, int age, bool goodBoi)
        {
            Name = name;
            Age = age;
            GoodBoi = goodBoi;
            FavoriteFoods = new List<string>();
            Type = "Dog";
            // dodadov lista da bide pointeresno
        }


        public override void PrintInfo()
        {
            Console.WriteLine($"{Name} the {Type} likes to eat: ");
            FavoriteFoods.ForEach(Console.WriteLine);
        }
    }
}
