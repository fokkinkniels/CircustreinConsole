using System.Collections.Generic;
using System.Linq;

namespace Circustrein_console
{
    class Train 
    {
        public List<Wagon> wagons = new List<Wagon>();

        public void AddToTrain(Animal animal)
        {
            //checks is train isnt empty
            if (wagons == null || wagons.Any())
            {
                foreach (var wagon in wagons)
                {
                    //calls method to see if animal can go in this wagon
                    if (wagon.AddToWagon(animal))
                    {
                        //Console.WriteLine("Animals has been added");
                        return;
                    }
                }
                //if animal cant fit in any wagon, a new wagon has to be created
                AddToNewWagon(animal);
            }
            //if train is empty a new wagon needs to be created
            else
            {
                //Console.WriteLine("There a no wagon yet");
                AddToNewWagon(animal);
            }
        }

        private void AddToNewWagon(Animal animal)
        {
            //create new wagon and add animal to it
            var newWagon = new Wagon(wagons.Count+1);
            wagons.Add(newWagon);
            newWagon.AddToWagon(animal);
            //Console.WriteLine("A new wagon has been created");
        }
    }
}
