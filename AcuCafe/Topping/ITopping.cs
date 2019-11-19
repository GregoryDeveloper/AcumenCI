using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcuCafe.Topping
{
    public interface ITopping
    {
        bool HasSugar { get; set; }
        bool HasMilk { get; set; }
        bool HasChocolate { get; set; }
    }
}
