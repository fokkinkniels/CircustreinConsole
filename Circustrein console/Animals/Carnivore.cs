using Circustrein_console;
using System.Collections.Generic;


namespace CircusTrein.classes
{
    public class Carnivore : Animal
    {
        public Carnivore(float size, string name)
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
            float wagonOccupied = 0;
            foreach(var _animal in animals)
            {
                wagonOccupied += _animal.GetSize();

                //check is animal fots in wagon
                if (wagonOccupied + animal.GetSize() > 10)
                {
                    return false;
                }
            }


            //loop throug all animals in wagon and checks if animal wont eat an other animal or wont be eaten
            foreach (var _animal in animals)
            {
                if (_animal is Carnivore && _animal.GetSize() >= animal.GetSize())
                {
                    return false;
                }
                if (_animal.GetSize() <= animal.GetSize())
                {
                    return false;
                }
            }
            return true;
        }
    }
}
