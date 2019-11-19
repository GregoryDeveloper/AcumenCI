namespace AcuCafe.Drinks
{
    public class IceTea : Drink
    {
        public IceTea(bool hasSugar) : base(hasSugar) { }

        protected override double BasicCost => 1.5;

        public override string ToString()
        {
            return DrinkType.IceTea.GetDescription();
        }
    }
}