using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MXTires.Microdata.Intangible.Enumeration
{
    /// <summary>
    /// Enum DaysOfWeek
    /// </summary>
    [Flags]
    public enum DaysOfWeek
    {
        /// <summary>
        /// Monday
        /// </summary>
        Mo = 1 << 0,
        /// <summary>
        /// Tuesday
        /// </summary>
        Tu = 1 << 1,
        /// <summary>
        /// Wednesday
        /// </summary>
        We = 1 << 2,
        /// <summary>
        /// Thursday
        /// </summary>
        Th = 1 << 3,
        /// <summary>
        /// Friday
        /// </summary>
        Fr = 1 << 4,
        /// <summary>
        /// Saturday
        /// </summary>
        Sa = 1 << 5,
        /// <summary>
        /// Sunday
        /// </summary>
        Su = 1 << 6
    }
}
