using System;
using System.Collections.Generic;
using System.Linq;

namespace Circustrein_console
{
    class Wagon
    {
        private List<Animal> animals = new List<Animal>();
        private int id;

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
                    return true;
                }
            }
            //if wagon is empty animals can always fit in
            else
            {
                animals.Add(animal);
                return true;
            }

            //if animals cant fit in wagon this method will return false
            return false;
        }

        public List<Animal> GetAnimals()
        {
            return animals;
        }

        public int GetId()
        {
            return id;
        }
    }

}
