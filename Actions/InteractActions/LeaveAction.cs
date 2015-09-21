using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MXTires.Microdata.Actions.InteractActions
{
    /// <summary>
    /// An agent leaves an event / group with participants/friends at a location.
    /// Related actions:
    /// JoinAction: The antonym of LeaveAction.
    /// UnRegisterAction: Unlike UnRegisterAction, LeaveAction implies leaving a group/team of people rather than a service
    /// </summary>
    public class LeaveAction : JoinAction
    {
    }
}
