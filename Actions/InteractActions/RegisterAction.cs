using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MXTires.Microdata.Actions.InteractActions
{
    /// <summary>
    /// The act of registering to be a user of a service, product or web page.
    /// Related actions:
    /// JoinAction: Unlike JoinAction, RegisterAction implies you are registering to be a user of a service, *not* a group/team of people.
    /// FollowAction: Unlike FollowAction, RegisterAction doesn't imply that the agent is expecting to poll for updates from the object.
    /// SubscribeAction: Unlike SubscribeAction, RegisterAction doesn't imply that the agent is expecting updates from the object
    /// </summary>
    public class RegisterAction : InteractAction
    {
    }
}
