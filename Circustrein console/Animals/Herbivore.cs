using Circustrein_console;
using System.Collections.Generic;

namespace CircusTrein.classes
{
    class Herbivore : Animal
    {
        public Herbivore(float size, string name)
        {
            Size = size;
            if (name == null || name == "")
            {
                name = size.ToString();
            }
            Name = name;
        }

        public override bool CanFitInWagon(List<Animal> animals, Animal animal)
        {
            //calculate occupied places in wagon
            float wagonOccupied= 0;
            foreach (var a in animals)
            {
                wagonOccupied += a.Size;

                //check is animal fots in wagon
                if (wagonOccupied + animal.Size > 10)
                {
                    return false;
                }
            }

            //loop throug all animals in wagon and checks if animal wont be eaten
            foreach (var a in animals)
            {
                if (a is Carnivore && a.Size >= animal.Size)
                {
                    return false;
                }
            }
            return true;
        }
    }
}