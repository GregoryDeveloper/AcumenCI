using AcuCafe.Drinks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AcuCafe
{
    public static class AcuCafe
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="drinkOrdered">The drink ordered</param>
        /// <param name="hasMilk">Indicates whether the drinks contains milk or not. 
        /// It wasn't necessary given that the class drink amready contains the information
        /// However, it doesn't let us to enter invalid data e.g. icetea with milk</param>
        /// <returns></returns>
        public static async Task<string> PrepareOrder(Drink drinkOrdered, bool hasMilk)
        {
            Task<string> orderPreparation = null;

            CancellationTokenSource cancellationToken = new CancellationTokenSource();
            orderPreparation = drinkOrdered.Prepare(cancellationToken.Token);

            if (drinkOrdered is IceTea && hasMilk)
            {
                Thread.Sleep(Constants.CANCELLATION_WAITING_TIME);
                cancellationToken.Cancel();
            }
            
            
            return await orderPreparation;
        }
    }
}
