using CircusTrein.classes;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Circustrein_console
{
    public class trainController
    {
        Train train = new Train();
        Train shortestTrain = new Train();

        List<string> userInputText = new List<string>();
        List<Animal> userInputAnimals = new List<Animal>();


        /// <summary>
        /// User and test input functions
        /// </summary>
        /// <param name="animals"></param>


        public void AddToTrainFromTest(List<Animal> animals)
        {
            foreach (var animal in animals)
            {
                userInputAnimals.Add(animal);
            }
            CalculateWagons();
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

        //transform userinput to an animal
        private Animal textToAnimal(string animalText)
        {
            Animal animal = null;

            if (animalText == "1H" || animalText == "1h" || animalText == "H1" || animalText == "h1")
            {
                animal = new Herbivore(1, "1H");
            }
            else if (animalText == "3H" || animalText == "3h" || animalText == "H3" || animalText == "h3")
            {
                animal = new Herbivore(3, "3H");
            }
            else if (animalText == "5H" || animalText == "5h" || animalText == "H5" || animalText == "h5")
            {
                animal = new Herbivore(5, "5H");
            }
            else if (animalText == "1C" || animalText == "1c" || animalText == "C1" || animalText == "c1")
            {
                animal = new Carnivore(1, "1C");
            }
            else if (animalText == "3C" || animalText == "3c" || animalText == "C3" || animalText == "c3")
            {
                animal = new Carnivore(3, "3C");
            }
            else if (animalText == "5C" || animalText == "5c" || animalText == "C5" || animalText == "c5")
            {
                animal = new Carnivore(5, "5C");
            }

            return animal;
        }


        /// <summary>
        /// Calculate how many wagons are needed and what animals go in what wagons
        /// </summary>


        public void CalculateWagons()
        {
            if (userInputAnimals.Count > 9)
            {
                AddAnimalsToTrain();
            }
            else
                CalculateBestSolution();
        }

        private void AddAnimalsToTrain()
        {
            List<Animal> SortAnimalsOnSize(List<Animal> animals)
            {
                Animal tempAnimal;

                for (int write = 0; write < animals.Count; write++)
                {
                    for (int sort = 0; sort < animals.Count - 1; sort++)
                    {
                        if (animals[sort].GetSize() > animals[sort + 1].GetSize())
                        {
                            tempAnimal = animals[sort + 1];
                            animals[sort + 1] = animals[sort];
                            animals[sort] = tempAnimal;
                        }
                    }
                }

                return animals;
            }
            List<Animal> userInputAnimalsSorted = new List<Animal>();

            userInputAnimalsSorted = SortAnimalsOnSize(userInputAnimals);
            Console.WriteLine("");

            for (int i = 0; i < userInputAnimalsSorted.Count; i++)
            {
                shortestTrain.AddToTrain(userInputAnimalsSorted[i]);

                //drawTextProgressBar(i+1, userInputAnimals.Count);
            }
        }

        private void CalculateBestSolution()
        {
            List<Animal> bigCarnivores = new List<Animal>();
            shortestTrain = new Train();
            int counter = 0;

            //make train 100 long
            for (int i = 0; i < 100; i++)
            {
                shortestTrain.AddToTrain(new Carnivore(5, "5C"));
            }

            //filter all 5C out of list to speed up procces
            foreach (var animal in userInputAnimals.ToList())
            {
                if (animal.ToString() == "5C")
                {
                    bigCarnivores.Add(animal);
                    userInputAnimals.Remove(animal);
                }
            }

            counter = 0;

            foreach (var permu in Permutate(userInputAnimals, userInputAnimals.Count))
            {
                train.GetWagons().Clear();
                counter++;
                foreach (Animal animal in permu)
                {
                    train.AddToTrain(animal);
                    if (train.GetWagons().Count > shortestTrain.GetWagons().Count)
                    {
                        break;
                    }
                }

                if (counter % 1000000 == 0)
                {
                    Console.WriteLine(counter);
                }

                if (train.GetWagons().Count < shortestTrain.GetWagons().Count)
                {
                    shortestTrain = train;
                }

            }

            foreach (var animal in bigCarnivores)
            {
                shortestTrain.AddToTrain(animal);
            }
        }


        /// <summary>
        /// Permutation Functions
        /// </summary>
        /// <param name="sequence"></param>
        /// <param name="count"></param>


        void RotateRight(IList sequence, int count)
        {
            object tmp = sequence[count - 1];
            sequence.RemoveAt(count - 1);
            sequence.Insert(0, tmp);
        }

        IEnumerable<IList> Permutate(IList sequence, int count)
        {
            if (count == 1) yield return sequence;
            else
            {
                for (int i = 0; i < count; i++)
                {
                    foreach (var perm in Permutate(sequence, count - 1))
                        yield return perm;
                    RotateRight(sequence, count);
                }
            }
        }


        /// <summary>
        /// Return Functions
        /// </summary>


        public int GetWagonsInTrain()
        {
            return shortestTrain.GetWagons().Count;
        }

        public int GetAnimalsInTrain()
        {
            int counter = 0;
            foreach (var wagon in shortestTrain.GetWagons())
            {
                counter = counter + wagon.GetAnimals().Count;
            }
            return counter;
        }

        //displays all wagons
        public void drawWagons()
        {
            foreach (var wagon in shortestTrain.GetWagons())
            {
                Console.WriteLine("");
                Console.WriteLine($"The following animals are in wagon #{wagon.GetId()}:");
                foreach (var animals in wagon.GetAnimals())
                {
                    Console.WriteLine(animals.ToString());
                }
            }
        }
    }
}
