using AcuCafe;
using AcuCafe.Drinks;
using System;
using System.Threading;
using System.Threading.Tasks;
using System.Configuration;
using AcuCafe.Topping;

namespace CoffeShop
{
    class Program
    {
        public static async Task Main(string[] args)
        {
            try
            {
                ITopping topping = new Topping(false,false);
                Drink drink = DrinkFactory.OrderDrink(DrinkType.IceTea, topping);
                string result = await AcuCafe.AcuCafe.PrepareOrder(drink, topping.HasMilk);
                var cost = drink.Cost();
                Console.WriteLine(result);
                Console.WriteLine($"The price is: {cost}");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                string path = ConfigurationManager.AppSettings[Constants.FILE_PATH];

                System.IO.File.WriteAllText(path, ex.ToString());
            }

            Console.ReadLine();
        }
    }
}
