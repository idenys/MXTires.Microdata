using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace MXTires.Microdata.Actions.InteractActions
{
    /// <summary>
    /// An agent joins an event/group with participants/friends at a location.
    /// Related actions:
    /// RegisterAction: Unlike RegisterAction, JoinAction refers to joining a group/team of people.
    /// SubscribeAction: Unlike SubscribeAction, JoinAction does not imply that you'll be receiving updates.
    /// FollowAction: Unlike FollowAction, JoinAction does not imply that you'll be polling for updates
    /// </summary>
    public class JoinAction : InteractAction
    {
        /// <summary>
        /// Event - Upcoming or past event associated with this place, organization, or action. Supersedes events.
        /// </summary>
        [JsonProperty("event")]
        public Event Event { get; set; }

        /// <summary>
        /// Gets or sets the events.
        /// </summary>
        /// <value>The events.</value>
        [JsonProperty("events")]
        public List<Event> Events { get; set; }	
    }
}
