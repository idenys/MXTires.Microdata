using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MXTires.Microdata.Intangible.Enumeration
{
    /// <summary>
    /// An enumeration of several kinds of Map
    /// </summary>
    [Flags]
    public enum MapCategoryType
    {
        /// <summary>
        /// The parking map
        /// </summary>
        ParkingMap = 1 << 0,
        /// <summary>
        /// The seating map
        /// </summary>
        SeatingMap = 1 << 1,
        /// <summary>
        /// The transit map
        /// </summary>
        TransitMap = 1 << 2,
        /// <summary>
        /// The venue map
        /// </summary>
        VenueMap = 1 << 3,
    }
}
