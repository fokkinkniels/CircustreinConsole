using Circustrein_console;
using System.Collections.Generic;

namespace CircusTrein.classes
{
    public class Herbivore : Animal
    {
        public Herbivore(float size, string name)
        {
            Size = size;
            if (name == null || name == "")
            {
                name = size.ToString();
            }
            this.Name = name;
        }

        public override bool CanFitInWagon(List<Animal> animals, Animal animal)
        {
            //calculate occupied places in wagon
            float wagonOccupied= 0;
            foreach (var _animal in animals)
            {
                wagonOccupied += _animal.GetSize();

                //check is animal fots in wagon
                if (wagonOccupied + animal.GetSize() > 10)
                {
                    return false;
                }
            }

            //loop throug all animals in wagon and checks if animal wont be eaten
            foreach (var _animal in animals)
            {
                if (_animal is Carnivore && _animal.GetSize() >= animal.GetSize())
                {
                    return false;
                }
            }
            return true;
        }
    }
}