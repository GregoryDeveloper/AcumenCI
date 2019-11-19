using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcuCafe.Topping
{
    public class Topping : ITopping
    {
        public bool HasSugar { get ; set; }
        public bool HasMilk { get; set; }
        public bool HasChocolate { get; set; }

        public Topping(bool hasSugar, bool hasMilk = false, bool hasChocolate = false)
        {
            HasSugar = hasSugar;
            HasMilk = hasMilk;
            HasChocolate = hasChocolate;
        }
    }
}
