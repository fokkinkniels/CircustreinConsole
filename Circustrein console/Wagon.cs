using System;
using System.Collections.Generic;
using System.Linq;

namespace Circustrein_console
{
    class Wagon
    {
        public List<Animal> animals = new List<Animal>();
        public int id;

        public Wagon(int _id)
        {
            id = _id;
        }

        public bool AddToWagon(Animal animal)
        {
            //check if wagon isnt empty
            if(animals == null || animals.Any())
            {
                //checks if animals can fit in this wagon
                if (animal.CanFitInWagon(animals, animal))
                {
                    animals.Add(animal);
                    //Console.WriteLine($"animal: {animal} has succesfully been added to a wagon");
                    return true;
                }
            }
            //if wagon is empty animals can always fit in
            else
            {
                //Console.WriteLine("Wagon was empty so animal always fit");
                animals.Add(animal);
                return true;
            }

            //if animals cant fit in wagon this method will return false
            //Console.WriteLine("Animals didnt fit in this wagon");
            return false;
        }
    }
}
