using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MXTires.Microdata
{
    [Flags]
    public enum ActionStatusType
    {

        ActiveActionStatus,

        CompletedActionStatus,

        FailedActionStatus,

        PotentialActionStatus
    }
}
