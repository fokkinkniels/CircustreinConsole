using System.Collections.Generic;

namespace Circustrein_console
{
    public abstract class Animal
    {
        protected float Size;
        protected string Name;

        public abstract bool CanFitInWagon(List<Animal> wagon, Animal animal);

        public override string ToString()
        {
            return Name;
        }

        public float GetSize()
        {
            return Size;
        }
    }
}
