using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MXTires.Microdata.Intangible.Enumeration
{
    [Flags]
    public enum DaysOfWeek
    {
        Mo = 1 << 0, Tu = 1 << 1, We = 1 << 2, Th = 1 << 3, Fr = 1 << 4, Sa = 1 << 5, Su = 1 << 6
    }
}
