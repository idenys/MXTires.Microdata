using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace MXTires.Microdata.Actions.InteractActions.CommunicateActions
{
    /// <summary>
    /// The act of asking someone to attend an event. Reciprocal of <see cref="RsvpAction"/>.
    /// </summary>
    public class InviteAction : CommunicateAction
    {
        /// <summary>
        /// Upcoming or past event associated with this place, organization, or action. Supersedes <see cref="Events"/>.
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
