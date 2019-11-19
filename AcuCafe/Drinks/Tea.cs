namespace AcuCafe.Drinks
{
    public class Tea : Drink
    {
        public Tea(bool hasSugar) : base(hasSugar) { }

        protected override double BasicCost => 1;

        public override string ToString()
        {
            return DrinkType.Tea.GetDescription();
        }
    }
}