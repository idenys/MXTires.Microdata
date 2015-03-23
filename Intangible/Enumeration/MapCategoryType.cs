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
        ParkingMap = 1 << 0,
        SeatingMap = 1 << 1,
        TransitMap = 1 << 2,
        VenueMap = 1 << 3,
    }
}
