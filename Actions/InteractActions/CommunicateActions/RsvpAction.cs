using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MXTires.Microdata.Intangible.Enumeration;
using Newtonsoft.Json;

namespace MXTires.Microdata.Actions.InteractActions.CommunicateActions
{
    /// <summary>
    /// The act of notifying an event organizer as to whether you expect to attend the event.
    /// </summary>
    public class RsvpAction : InformAction
    {
        /// <summary>
        /// Number - If responding yes, the number of guests who will attend in addition to the invitee.
        /// </summary>
        [JsonProperty("additionalNumberOfGuests")]
        public Int32? AdditionalNumberOfGuests { get; set; }

        /// <summary>
        /// Comment - Comments, typically from users.
        /// </summary>
        [JsonProperty("comment")]
        public List<Comment> comment { get; set; }

        /// <summary>
        /// Number - If responding yes, the number of guests who will attend in addition to the invitee.
        /// </summary>
        [JsonProperty("rsvpResponse")]
        public RsvpResponseType RsvpResponse { get; set; }
    }
}
