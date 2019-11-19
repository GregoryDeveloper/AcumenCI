namespace AcuCafe.Drinks
{
    public class Expresso : Drink
    {
        public Expresso(bool hasSugar, bool hasMilk, bool hasChocolate) : base(hasSugar, hasMilk, hasChocolate) { }

        protected override double BasicCost => 1.8;

        public override string ToString()
        {
            return DrinkType.Expresso.GetDescription();
        }
    }
}