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
        /// <summary>
        /// The event canceled
        /// </summary>
        EventCancelled = 1 << 0,
        /// <summary>
        /// The event postponed
        /// </summary>
        EventPostponed = 1 << 1,
        /// <summary>
        /// The event rescheduled
        /// </summary>
        EventRescheduled = 1 << 2,
        /// <summary>
        /// The event scheduled
        /// </summary>
        EventScheduled = 1 << 3,
    }
}
