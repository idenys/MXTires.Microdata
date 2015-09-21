using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MXTires.Microdata.Validators;
using Newtonsoft.Json;

namespace MXTires.Microdata.Actions.InteractActions
{
    /// <summary>
    /// The act of forming a personal connection with someone/something (object) unidirectionally/asymmetrically to get updates polled from.
    /// Related actions:
    /// BefriendAction: Unlike BefriendAction, FollowAction implies that the connection is *not* necessarily reciprocal.
    /// SubscribeAction: Unlike SubscribeAction, FollowAction implies that the follower acts as an active agent constantly/actively polling for updates.
    /// RegisterAction: Unlike RegisterAction, FollowAction implies that the agent is interested in continuing receiving updates from the object.
    /// JoinAction: Unlike JoinAction, FollowAction implies that the agent is interested in getting updates from the object.
    /// TrackAction: Unlike TrackAction, FollowAction refers to the polling of updates of all aspects of animate objects rather than the location of inanimate objects (e.g. you track a package, but you don't follow it)
    /// </summary>
    public class FollowAction : InteractAction
    {
        Thing followee;
        /// <summary>
        /// Organization  or Person - A sub property of object. The person or organization being followed.
        /// </summary>
         [JsonProperty("followee")]
        public Thing Followee
        {
            get { return followee; }
            set
            {
                var validator = new TypeValidator(typeof(Organization), typeof(Person));
                validator.Validate(value);
                followee = value;
            }
        }
    }
}
