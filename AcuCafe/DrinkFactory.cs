using AcuCafe.Drinks;
using AcuCafe.Topping;
using System;
using System.Threading.Tasks;

namespace AcuCafe
{
    public static class DrinkFactory
    {
        public static Drink OrderDrink(DrinkType drinkType, ITopping topping )
        {
            Drink drink = null;

            switch (drinkType)
            {
                case DrinkType.Expresso:
                    drink = new Expresso(topping.HasSugar, topping.HasMilk, topping.HasChocolate);
                    break;
                case DrinkType.Tea:
                    drink = new Tea(topping.HasSugar);
                    break;
                case DrinkType.IceTea:
                    drink = new IceTea(topping.HasSugar);
                    break;
                default:
                    throw new NotSupportedException();
            }

            return drink;
        }
    }
}