using System;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AcuCafe.Drinks
{
    public abstract class Drink
    {
        public const double MilkCost = 0.5;
        public const double SugarCost = 0.5;
        public const double ChocolateCost = 0.5;


        public bool HasMilk { get; private set; }
        public bool HasSugar { get; private set; }
        public bool HasChocolate { get; private set; }


        protected abstract double BasicCost { get; }

        public Drink(bool hasSugar, bool hasMilk = false, bool hasChocolate = false)
        {
            HasSugar = hasSugar;
            HasMilk = hasMilk;
            HasChocolate = hasChocolate;
        }

        /// <summary>
        /// Returns the cost base on the basic cost of the drink order plus the differents toppings
        /// </summary>
        /// <returns></returns>
        public double Cost()
        {
            double total = BasicCost;

            if (HasMilk)
                total += MilkCost;

            if (HasSugar)
                total += SugarCost;

            if (HasChocolate)
                total += ChocolateCost;

            return total;
        }
        
        public Task<string>Prepare(CancellationToken cancellationToken)
        {
            Task<string> task = null;

            task = Task.Run(() =>
            {
                for (int i = 0; i < Constants.ITERATION_NUMBER; i++)
                {
                    if (cancellationToken.IsCancellationRequested)
                        throw new TaskCanceledException(Constants.CANCELLATION_MESSAGE);

                    Thread.Sleep(Constants.WAITING_TIME);
                }

                return GetPreparation();
            });

            return task;
        }

        private string GetPreparation()
        {
            StringBuilder sb = new StringBuilder($"{Constants.PREPARATION_MESSAGE} {this.ToString()} ");

            if (HasMilk)
                sb.Append(Constants.WITH_MILK);
            else
                sb.Append(Constants.WITHOUT_MILK);

            sb.Append(' ');

            if (HasSugar)
                sb.Append(Constants.WITH_SUGAR);
            else
                sb.Append(Constants.WITHOUT_SUGAR);

            return sb.ToString();
        }

        public abstract override string ToString();
    }
}