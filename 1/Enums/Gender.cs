using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace _1.Enums
{
    public enum Gender
    {
        [Description("خانم")] Female = 1,
        [Description("آقا")] Male = 2
    }
}
