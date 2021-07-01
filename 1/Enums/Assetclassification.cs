using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace _1.Enums
{
    public enum Assetclassification
    {
       [Description("املاک")] estate=1,
       [Description("ارز و سکه")] Currencyandcoins=2,
       [Description("بورس")] Exchange=3,
       [Description("وسایل نقلیه")] vehicles=4,
       [Description("طلا و فلزات گرانبها")] Goldandpreciousmetals=5
    }
}
