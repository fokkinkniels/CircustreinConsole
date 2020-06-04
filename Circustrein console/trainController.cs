using CircusTrein.classes;
using System;
using System.Collections.Generic;

namespace Circustrein_console
{
    public class trainController
    {
        List<string> userInputText = new List<string>();
        List<Animal> userInputAnimals = new List<Animal>();
        List<Animal> testInputAnimals = new List<Animal>();
        List<Animal> userInputAnimalsSorted = new List<Animal>();
        Train train = new Train();




        public void AddAnimalsToTrain()
        {
            userInputAnimalsSorted = SortAnimalsOnSize(userInputAnimals);
            Console.WriteLine("");

            for (int i = 0; i < userInputAnimalsSorted.Count; i++)
            {
                train.AddToTrain(userInputAnimalsSorted[i]);

                //drawTextProgressBar(i+1, userInputAnimals.Count);
            }
        }


        //stores the userinput as text and as animals
        public void GetUserInputConsole(int amount)
        {
            for (int i = 0; i < amount; i++)
            {
                var input = Console.ReadLine();
                userInputText.Add(input);

                if(textToAnimal(input) != null)
                {
                    userInputAnimals.Add(textToAnimal(input));
                }
            }
        }

        //sort animals from small to big using a bubble sort
        public List<Animal> SortAnimalsOnSize(List<Animal> animals)
        {
            Animal temp;

            for (int write = 0; write < animals.Count; write++)
            {
                for (int sort = 0; sort < animals.Count - 1; sort++)
                {
                    if (animals[sort].Size > animals[sort + 1].Size)
                    {
                        temp = animals[sort + 1];
                        animals[sort + 1] = animals[sort];
                        animals[sort] = temp;
                    }
                }
            }

            return animals;
        }


        //transform userinput to an animal
        private Animal textToAnimal(string animalText)
        {
            Animal animal = null;

            if (animalText == "1H" || animalText == "1h")
            {
                animal = new Herbivore(1, "1H");
            }
            else if (animalText == "3H" || animalText == "3h")
            {
                animal = new Herbivore(3, "3H");
            }
            else if (animalText == "5H" || animalText == "5h")
            {
                animal = new Herbivore(5, "5H");
            }
            else if (animalText == "1C" || animalText == "1c")
            {
                animal = new Carnivore(1, "1C");
            }
            else if (animalText == "3C" || animalText == "3c")
            {
                animal = new Carnivore(3, "3C");
            }
            else if (animalText == "5C" || animalText == "5c")
            {
                animal = new Carnivore(5, "5C");
            }

            return animal;
        }


        //displays all wagons
        public void drawWagons()
        {
            foreach(var wagon in train.wagons)
            {
                Console.WriteLine("");
                Console.WriteLine($"The following animals are in wagon #{wagon.id}:");
                foreach (var animals in wagon.animals)
                {
                    Console.WriteLine(animals.Name);
                }
            }
        }


        public void AddToTrainFromTest(List<Animal> animals)
        {
            foreach (var animal in animals)
            {
                userInputAnimals.Add(animal);
            }
            AddAnimalsToTrain();
        }


        private void drawTextProgressBar(int progress, int total)
        {
            //draw empty progress bar
            Console.CursorLeft = 0;
            Console.Write("["); //start
            Console.CursorLeft = 32;
            Console.Write("]"); //end
            Console.CursorLeft = 1;
            float onechunk = 30.0f / total;

            //draw filled part
            int position = 1;
            for (int i = 0; i < onechunk * progress; i++)
            {
                Console.BackgroundColor = ConsoleColor.Gray;
                Console.CursorLeft = position++;
                Console.Write(" ");
            }

            //draw unfilled part
            for (int i = position; i <= 31; i++)
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.CursorLeft = position++;
                Console.Write(" ");
            }

            //draw totals
            Console.CursorLeft = 35;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write(progress.ToString() + " of " + total.ToString() + "    "); //blanks at the end remove any excess
        }

        public int GetWagons()
        {
            return train.wagons.Count;
        }
    }
}
