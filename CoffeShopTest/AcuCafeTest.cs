using Microsoft.VisualStudio.TestTools.UnitTesting;
using AcuCafe;
using AcuCafe.Drinks;
using AcuCafe.Topping;
using System.Threading.Tasks;

namespace CoffeShopTest
{
    [TestClass]
    public class AcuCafeTest
    {
        [TestMethod]
        public void ExpressoMilkSugarTest()
        {
            // Arrange
            double expectedPrice = 2.8;
            bool hasSugar = true;
            bool hasMilk = true;


            // act
            ITopping topping = new Topping(true,true);
            Drink actual = DrinkFactory.OrderDrink(DrinkType.Expresso, topping);

            Assert.AreEqual(expectedPrice, actual.Cost());
            Assert.AreEqual(hasSugar, actual.HasSugar);
            Assert.AreEqual(hasMilk, actual.HasMilk);
        }

        [TestMethod]
        public void ExpressoNoMilkSugarTest()
        {
            // Arrange
            double expectedPrice = 2.3;
            bool hasSugar = true;
            bool hasMilk = false;

            // act
            ITopping topping = new Topping(true, false);
            Drink actual = DrinkFactory.OrderDrink(DrinkType.Expresso, topping);

            Assert.AreEqual(expectedPrice, actual.Cost());
            Assert.AreEqual(hasSugar, actual.HasSugar);
            Assert.AreEqual(hasMilk, actual.HasMilk);
        }

        [TestMethod]
        public void ExpressoMilkSugarChocolateTest()
        {
            // Arrange
            double expectedPrice = 3.3;
            bool hasSugar = true;
            bool hasMilk = true;
            bool hasChocolate = true;

            // act
            ITopping topping = new Topping(true, true,true);
            Drink actual = DrinkFactory.OrderDrink(DrinkType.Expresso, topping);

            Assert.AreEqual(expectedPrice, actual.Cost());
            Assert.AreEqual(hasSugar, actual.HasSugar);
            Assert.AreEqual(hasMilk, actual.HasMilk);
            Assert.AreEqual(hasChocolate, actual.HasChocolate);

        }

        [TestMethod]
        public void ExpressoMilkNoSugarTest()
        {
            // Arrange
            double expectedPrice = 2.3;
            bool hasSugar = false;
            bool hasMilk = true;

            // act
            ITopping topping = new Topping(false, true);
            Drink actual = DrinkFactory.OrderDrink(DrinkType.Expresso, topping);

            Assert.AreEqual(expectedPrice, actual.Cost());
            Assert.AreEqual(hasSugar, actual.HasSugar);
            Assert.AreEqual(hasMilk, actual.HasMilk);
        }
        [TestMethod]
        public void ExpressoNoMilkNoSugarTest()
        {
            // Arrange
            double expectedPrice = 1.8;
            bool hasSugar = false;
            bool hasMilk = false;

            // act
            ITopping topping = new Topping(false, false);
            Drink actual = DrinkFactory.OrderDrink(DrinkType.Expresso, topping);

            Assert.AreEqual(expectedPrice, actual.Cost());
            Assert.AreEqual(hasSugar, actual.HasSugar);
            Assert.AreEqual(hasMilk, actual.HasMilk);
        }


        [TestMethod]
        public void TeaMilkSugarTest()
        {
            // Arrange
            double expectedPrice = 1.5;
            bool hasSugar = true;
            bool hasMilk = false;

            // act
            ITopping topping = new Topping(true, true);
            Drink actual = DrinkFactory.OrderDrink(DrinkType.Tea, topping);

            Assert.AreEqual(expectedPrice, actual.Cost());
            Assert.AreEqual(hasSugar, actual.HasSugar);
            Assert.AreEqual(hasMilk, actual.HasMilk);
        }

        [TestMethod]
        public void TeaMilkNoSugarTest()
        {
            // Arrange
            double expectedPrice = 1;
            bool hasSugar = false;
            bool hasMilk = false;

            // act
            ITopping topping = new Topping(false, false);
            Drink actual = DrinkFactory.OrderDrink(DrinkType.Tea, topping);

            Assert.AreEqual(expectedPrice, actual.Cost());
            Assert.AreEqual(hasSugar, actual.HasSugar);
            Assert.AreEqual(hasMilk, actual.HasMilk);
        }

        [TestMethod]
        public void TeaNoMilkSugarTest()
        {
            // Arrange
            double expectedPrice = 1.5;
            bool hasSugar = true;
            bool hasMilk = false;

            // act
            ITopping topping = new Topping(true, false);
            Drink actual = DrinkFactory.OrderDrink(DrinkType.Tea, topping);

            Assert.AreEqual(expectedPrice, actual.Cost());
            Assert.AreEqual(hasSugar, actual.HasSugar);
            Assert.AreEqual(hasMilk, actual.HasMilk);
        }

        [TestMethod]
        public void IceTeaMilkSugarTest()
        {
            // Arrange
            double expectedPrice = 2;
            bool hasSugar = true;
            bool hasMilk = false;

            // act
            ITopping topping = new Topping(true, true);
            Drink actual = DrinkFactory.OrderDrink(DrinkType.IceTea, topping);

            Assert.AreEqual(expectedPrice, actual.Cost());
            Assert.AreEqual(hasSugar, actual.HasSugar);
            Assert.AreEqual(hasMilk, actual.HasMilk);
        }

        [TestMethod]
        public void IceTeaMilkNoSugarTest()
        {
            // Arrange
            double expectedPrice = 1.5;
            bool hasSugar = false;
            bool hasMilk = false;

            // act
            ITopping topping = new Topping(false, true);
            Drink actual = DrinkFactory.OrderDrink(DrinkType.IceTea, topping);

            Assert.AreEqual(expectedPrice, actual.Cost());
            Assert.AreEqual(hasSugar, actual.HasSugar);
            Assert.AreEqual(hasMilk, actual.HasMilk);
        }

        [TestMethod]
        public void IceTeaMilkSugarChocolateTest()
        {
            // Arrange
            double expectedPrice = 2;
            bool hasSugar = true;
            bool hasMilk = false;
            bool hasChocolate = false;
            
            // act
            ITopping topping = new Topping(true, true,true);
            Drink actual = DrinkFactory.OrderDrink(DrinkType.IceTea, topping);

            Assert.AreEqual(expectedPrice, actual.Cost());
            Assert.AreEqual(hasSugar, actual.HasSugar);
            Assert.AreEqual(hasMilk, actual.HasMilk);
            Assert.AreEqual(hasChocolate, actual.HasChocolate);

        }

        [TestMethod]
        public async Task PrepareOrderTest()
        {
            // ARRANGE
            string expected = "We are preparing the following drink for you:  Ice Tea without milk without sugar";

            // ACT
            ITopping topping = new Topping(false, false);
            Drink drink = DrinkFactory.OrderDrink(DrinkType.IceTea, topping);
            string actual = await AcuCafe.AcuCafe.PrepareOrder(drink, topping.HasMilk);

            //ASSERT
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(TaskCanceledException))]
        public async Task PrepareOrderExpectedExceptionTest()
        {
            // ARRANGE
            string expected = "We are preparing the following drink for you:  Ice Tea without milk without sugar";

            // ACT
            ITopping topping = new Topping(false, true);
            Drink drink = DrinkFactory.OrderDrink(DrinkType.IceTea, topping);
            string actual = await AcuCafe.AcuCafe.PrepareOrder(drink, topping.HasMilk);

            //ASSERT
            Assert.AreEqual(expected, actual);
        }

    }
}
