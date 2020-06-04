using Microsoft.VisualStudio.TestTools.UnitTesting;
using Circustrein_console;
using System.Collections.Generic;
using CircusTrein.classes;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            trainController trainController = new trainController();
            List<Animal> animals = new List<Animal>();

            animals.Add(new Herbivore(1, "1H"));
            animals.Add(new Herbivore(1, "1H"));

            trainController.AddToTrainFromTest(animals);
            Assert.AreEqual(trainController.GetWagons(), 1);
        }

        [TestMethod]
        public void TestMethod2()
        {
            trainController trainController = new trainController();
            List<Animal> animals = new List<Animal>();

            animals.Add(new Carnivore(3, "3C"));
            animals.Add(new Carnivore(3, "3C"));
            animals.Add(new Carnivore(3, "3C"));

            animals.Add(new Herbivore(5, "5H"));
            animals.Add(new Herbivore(5, "5H"));
            animals.Add(new Herbivore(5, "5H"));

            animals.Add(new Herbivore(1, "1H"));
            animals.Add(new Herbivore(1, "1H"));
            animals.Add(new Herbivore(1, "1H"));
            animals.Add(new Herbivore(1, "1H"));
            animals.Add(new Herbivore(1, "1H"));
            animals.Add(new Herbivore(1, "1H"));

            trainController.AddToTrainFromTest(animals);
            Assert.AreEqual(trainController.GetWagons(), 4);
        }

        [TestMethod]
        public void TestMethod3()
        {
            trainController trainController = new trainController();
            List<Animal> animals = new List<Animal>();

            animals.Add(new Carnivore(3, "3C"));
            animals.Add(new Carnivore(3, "3C"));
            animals.Add(new Carnivore(3, "3C"));

            animals.Add(new Herbivore(5, "5H"));
            animals.Add(new Herbivore(5, "5H"));
            animals.Add(new Herbivore(5, "5H"));

            animals.Add(new Carnivore(5, "5C"));

            animals.Add(new Herbivore(3, "3H"));

            animals.Add(new Carnivore(1, "1C"));


            trainController.AddToTrainFromTest(animals);
            Assert.AreEqual(trainController.GetWagons(), 5);
        }

        [TestMethod]
        public void TestMethod4()
        {
            trainController trainController = new trainController();
            List<Animal> animals = new List<Animal>();

            animals.Add(new Herbivore(1, "1H"));
            animals.Add(new Herbivore(1, "1H"));
            animals.Add(new Herbivore(1, "1H"));
            animals.Add(new Herbivore(1, "1H"));
            animals.Add(new Herbivore(1, "1H"));

            animals.Add(new Herbivore(3, "3H"));
            animals.Add(new Herbivore(3, "3H"));
            animals.Add(new Herbivore(3, "3H"));
            animals.Add(new Herbivore(3, "3H"));
            animals.Add(new Herbivore(3, "3H"));

            animals.Add(new Herbivore(5, "5H"));
            animals.Add(new Herbivore(5, "5H"));
            animals.Add(new Herbivore(5, "5H"));
            animals.Add(new Herbivore(5, "5H"));
            animals.Add(new Herbivore(5, "5H"));

            animals.Add(new Carnivore(1, "1C"));
            animals.Add(new Carnivore(1, "1C"));

            animals.Add(new Carnivore(3, "3C"));
            animals.Add(new Carnivore(3, "3C"));

            animals.Add(new Carnivore(5, "5C"));
            animals.Add(new Carnivore(5, "5C"));


            trainController.AddToTrainFromTest(animals);
            Assert.AreEqual(trainController.GetWagons(), 8);
        }

        [TestMethod]
        public void TestMethod5()
        {
            trainController trainController = new trainController();
            List<Animal> animals = new List<Animal>();

            animals.Add(new Carnivore(5, "5C"));
            animals.Add(new Carnivore(5, "5C"));
            animals.Add(new Carnivore(5, "5C"));

            animals.Add(new Herbivore(5, "5H"));
            animals.Add(new Herbivore(5, "5H"));
            animals.Add(new Herbivore(5, "5H"));
            animals.Add(new Herbivore(5, "5H"));

            animals.Add(new Carnivore(3, "3C"));
            animals.Add(new Carnivore(3, "3C"));

            animals.Add(new Herbivore(3, "3H"));
            animals.Add(new Herbivore(3, "3H"));

            animals.Add(new Herbivore(1, "1H"));
            animals.Add(new Herbivore(1, "1H"));
            animals.Add(new Herbivore(1, "1H"));
            animals.Add(new Herbivore(1, "1H"));
            animals.Add(new Herbivore(1, "1H"));
            animals.Add(new Herbivore(1, "1H"));
            animals.Add(new Herbivore(1, "1H"));
            animals.Add(new Herbivore(1, "1H"));
            animals.Add(new Herbivore(1, "1H"));
            animals.Add(new Herbivore(1, "1H"));
            animals.Add(new Herbivore(1, "1H"));
            animals.Add(new Herbivore(1, "1H"));
            animals.Add(new Herbivore(1, "1H"));
            animals.Add(new Herbivore(1, "1H"));




            trainController.AddToTrainFromTest(animals);
            Assert.AreEqual(trainController.GetWagons(), 8);
        }
    }
}
