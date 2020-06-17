using PetStoreApp.Models;
using PetStoreApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PetStoreApp
{
    class Program
    {

        private static PetService<Dog> _dogService = new PetService<Dog>();
        private static PetService<Cat> _catService = new PetService<Cat>();
        private static PetService<Fish> _fishService = new PetService<Fish>();

        static void Main(string[] args)
        {

            Dog bob = new Dog("Bob", 3, false);
            bob.FavoriteFoods.AddRange(new List<string>() { "bone", "apple" });
            Dog rex = new Dog("Rex", 5, true);
            rex.FavoriteFoods.AddRange(new List<string>() { "bread", "ham" });

            _dogService.Pets.AddRange(new List<Dog>() { bob, rex});

            _catService.Pets.AddRange(new List<Cat>() { new Cat("Tom", 6, true, 1), new Cat("Marko", 2, false, 9)});

            _fishService.Pets.AddRange(new List<Fish>() { new Fish("Nemo", 1, "Orange", 2), new Fish("Omo", 2, "Red", 5) });

            _dogService.printPet();
            Console.WriteLine("================================");
            _catService.printPet();
            Console.WriteLine("================================");
            _fishService.printPet();
            Console.WriteLine("================================");

            _dogService.buyPet("Rex");
            Console.WriteLine("================================");
            _catService.buyPet("Tom");
            Console.WriteLine("================================");
            _fishService.buyPet("emo");


            Console.ReadLine();
        }
    }
}
