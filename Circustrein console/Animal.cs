using System.Collections.Generic;

namespace Circustrein_console
{
    public abstract class Animal
    {
        public float Size { get; set; }
        public string Name { get; set; }

        public abstract bool CanFitInWagon(List<Animal> wagon, Animal animal);
    }
}
