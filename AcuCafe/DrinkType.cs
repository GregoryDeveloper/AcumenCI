using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace AcuCafe
{
    public enum DrinkType
    {
        [Description("Expresso")]
        Expresso,
        [Description("Hot tea")]
        Tea,
        [Description("Ice Tea")]
        IceTea
    }

}