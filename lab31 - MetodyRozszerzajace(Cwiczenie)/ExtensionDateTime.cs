using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab31___MetodyRozszerzajace_Cwiczenie_
{
    public static class ExtensionDateTime
    {
        public static int DaysOnEarth (this DateTime birthDayDate)
        {
            return Convert.ToInt32((DateTime.Today - birthDayDate).TotalDays);
        }
    }
}
