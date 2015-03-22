using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MXTires.Microdata.Intangible.Enumeration
{
    /// <summary>
    /// Enumerated options related to a ContactPoint.
    /// </summary>
    [Flags]
    public enum ContactPointOption
    {
        HearingImpairedSupported = 1 << 0,
        TollFree = 1 << 1
    }
}
