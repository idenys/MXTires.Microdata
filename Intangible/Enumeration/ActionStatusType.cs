using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MXTires.Microdata.Intangible.Enumeration
{
    [Flags]
    public enum ActionStatusType
    {

        ActiveActionStatus = 1 << 0,

        CompletedActionStatus = 1 << 1,

        FailedActionStatus = 1 << 2,

        PotentialActionStatus = 1 << 3
    }
}
