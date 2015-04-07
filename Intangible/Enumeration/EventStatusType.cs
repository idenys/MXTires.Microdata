using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MXTires.Microdata.Intangible.Enumeration
{
    /// <summary>
    /// EventStatusType is an enumeration type whose instances represent several states that an Event may be in.
    /// </summary>
    public enum EventStatusType
    {
        EventCancelled = 1 << 0,
        EventPostponed = 1 << 1,
        EventRescheduled = 1 << 2,
        EventScheduled = 1 << 3,
    }
}
