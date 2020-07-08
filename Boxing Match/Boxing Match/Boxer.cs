using System;
using System.Collections.Generic;
using System.Text;

namespace Boxing_Match
{
   public class Boxer
    {
        public string Name { get; set; }

        public int Weight { get; set; }

        public int Hitpoints { get; set; }

        public bool activePlayer { get; set; }

        public Dictionary<string, int> Strength { get; set; }

        public Dictionary<string, int> Agility { get; set; }

        public Boxer() { }

        public Boxer (string name, int weight, int hitpoints, Dictionary<string, int> strenght, Dictionary<string, int> agility) 
        {
            Name = name;
            Weight = weight;
            Hitpoints = hitpoints;
            Strength = strenght;
            Agility = agility;
        } 
    }
}
