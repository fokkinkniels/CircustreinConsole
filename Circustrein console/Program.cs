using System;
using System.Collections.Generic;

namespace Circustrein_console
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintTutorial();
            MainProgram();

            Console.ReadLine();
        }

        static void MainProgram()
        {
            int amount = 0;
            int amountEnd = 0;
            var controller = new trainController();

            Console.Write("Please enter the amount of animals you like to start with: ");
            amountEnd = amount = int.Parse(Console.ReadLine());

            Console.WriteLine($"The provisional amount of animals is {amountEnd}");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Now start entering all animals, Please hit ENTER after every animals you want to add:");
            Console.WriteLine("");

            //get userinput for how many animals he/she wants to add and saves this data
            controller.GetUserInputConsole(amount);

            //if user wants to add more animals it can be done now
            Console.WriteLine("");
            Console.WriteLine($"You have insert {amount} animals now, would you like to enter more? y/n");
            var answer = Console.ReadLine();
            if (answer.Contains('y') || answer.Contains('Y'))
            {
                Console.WriteLine("How many would you like to add?");
                amountEnd += amount = int.Parse(Console.ReadLine());
                Console.WriteLine($"The final number of animals is {amountEnd}");
                controller.GetUserInputConsole(amount);
            }
            Console.Clear();
            
            //start the adding animals to train procces
            controller.AddAnimalsToTrain();
            Console.WriteLine("");
            Console.WriteLine("All animals have been succecfully added to the train!!");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Here are your results:");
            controller.drawWagons();
        }


        //give a brief explanation on how to enter data
        static void PrintTutorial()
        {
            Console.WriteLine("Welcome to my Circustrein Program!");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("There are a certain amount of animals species you can add to the train:");
            Console.WriteLine("");
            Console.WriteLine("A Herbivore, with the size of 1, 3 or 5");
            Console.WriteLine("A Carnivore, with the size of 1, 3 or 5");
            Console.WriteLine("");
            Console.WriteLine("You can do this by typing the first character of the animal diet and the size after it,");
            Console.WriteLine("For example 'H1', of 'C5'");
            Console.WriteLine("");
            Console.WriteLine("If you understand this please hit ENTER to continue");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("The next step is to specify the amount of animals you would like to add");
            Console.WriteLine("you can always add more animals later if you would like.");
            Console.WriteLine("");
        }
    }
}
