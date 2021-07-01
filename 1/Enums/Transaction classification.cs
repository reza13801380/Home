using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace _1.Enums
{
    public enum Transaction_classification
    {
        [Description("خوراک و پوشاک")] foodandclothes=1,
        [Description("سلامت ودرمان")] Healthandtreatment=2,
        [Description("مسکن")] Housing=3,
        [Description("آموزش و تحصیلات")] Education=4,
        [Description("افزودن دسته بندی")] Addcategories=5
    }
}
