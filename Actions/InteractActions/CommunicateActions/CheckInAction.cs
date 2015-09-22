using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MXTires.Microdata.Actions.InteractActions.CommunicateActions
{
    /// <summary>
    /// The act of an agent communicating (service provider, social media, etc) their arrival by registering/confirming for a previously reserved service (e.g. flight check in) or at a place (e.g. hotel), possibly resulting in a result (boarding pass, etc).
    /// Related actions:
    /// CheckOutAction: The antonym of CheckInAction.
    /// <see cref="ArriveAction"/>: Unlike ArriveAction, CheckInAction implies that the agent is informing/confirming the start of a previously reserved service.
    /// ConfirmAction: Unlike <see cref="ConfirmAction"/>, <see cref="CheckInAction"/> implies that the agent is informing/confirming the *start* of a previously reserved service rather than its validity/existence
    /// </summary>
    public class CheckInAction : CommunicateAction
    {
    }
}
