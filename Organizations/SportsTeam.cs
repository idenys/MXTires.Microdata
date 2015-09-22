using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MXTires.Microdata.Validators;
using Newtonsoft.Json;

namespace MXTires.Microdata.Organizations
{
    /// <summary>
    /// The act of organizing tasks/objects/events by associating resources to it.
    /// </summary>
    public class SportsTeam : SportsOrganization
    {
        /// <summary>
        /// Person - A person that acts as performing member of a sports team; a player as opposed to a coach.
        /// </summary>
        [JsonProperty("athlete")]
        public Person Athlete { get; set; }

        /// <summary>
        /// Person - A person that acts in a coaching role for a sports team.
        /// </summary>
        [JsonProperty("coach")]
        public Person Coach { get; set; }
    }
}
