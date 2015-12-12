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
        /// <summary>
        /// The hearing impaired supported
        /// </summary>
        HearingImpairedSupported = 1 << 0,
        /// <summary>
        /// The toll free
        /// </summary>
        TollFree = 1 << 1
    }
}
