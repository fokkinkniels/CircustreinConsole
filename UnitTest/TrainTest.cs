using Microsoft.VisualStudio.TestTools.UnitTesting;
using Circustrein_console;
using System.Collections.Generic;
using CircusTrein.classes;

namespace Circustrein_tests
{
    [TestClass]
    public class TrainTest
    {
        [TestMethod]
        public void Test_2SmallH()
        {
            //Arrange
            trainController trainController = new trainController();
            List<Animal> animals = new List<Animal>();

            animals.Add(new Herbivore(1, "1H"));
            animals.Add(new Herbivore(1, "1H"));

            //Action
            trainController.AddToTrainFromTest(animals);

            //Assert
            Assert.AreEqual(trainController.GetWagonsInTrain(), 1);
            Assert.AreEqual(trainController.GetAnimalsInTrain(), 2);
        }

        [TestMethod]
        public void Test_3BigC_3BigH_6SmallH()
        {
            //Arrange   
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

            //Action
            trainController.AddToTrainFromTest(animals);

            //Assert
            Assert.AreEqual(trainController.GetWagonsInTrain(), 4);
            Assert.AreEqual(trainController.GetAnimalsInTrain(), 12);
        }

        [TestMethod]
        public void Test_3MediumC_3BigH_1BigC_1MediumH_1SmallC()
        {
            //Arrange   
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

            //Action
            trainController.AddToTrainFromTest(animals);

            //Assert
            Assert.AreEqual(trainController.GetWagonsInTrain(), 6);
            Assert.AreEqual(trainController.GetAnimalsInTrain(), 9);
        }

        [TestMethod]
        public void Test_5SmallH_5MediumH_5BigH_2SmallC_3MediumC_5BigC()
        {
            //Arrange   
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

            //Action
            trainController.AddToTrainFromTest(animals);

            //Assert
            Assert.AreEqual(trainController.GetWagonsInTrain(), 8);
            Assert.AreEqual(trainController.GetAnimalsInTrain(), 21);
        }

        [TestMethod]
        public void Test_3BigC_4MediumH_2MediumC_2MediumH_14SMallH()
        {
            //Arrange   
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

            //Action
            trainController.AddToTrainFromTest(animals);

            //Assert
            Assert.AreEqual(trainController.GetWagonsInTrain(), 8);
            Assert.AreEqual(trainController.GetAnimalsInTrain(), 25);
        }
    }
}
