using PetStoreApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PetStoreApp.Services
{
    public class PetService<T> where T : Pet
    {
        
        public List<T> Pets = new List<T>();

        public void printPet()
        {
            foreach (T pet in Pets)
            {
                pet.PrintInfo();
            }
        }

        public void buyPet(string name)
        {
            T pet = Pets.FirstOrDefault(pet => pet.Name == name);

            if(pet == null)
            {
                Console.WriteLine("No such pet in the store");
                
            } else
            {
                Pets.Remove(pet);
                Console.WriteLine($"You are the proud owner of {pet.Name} the {pet.Type}");
            }
            
        }
    }
}
