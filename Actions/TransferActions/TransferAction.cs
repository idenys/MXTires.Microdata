using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MXTires.Microdata.Validators;
using Newtonsoft.Json;

namespace MXTires.Microdata.Actions.TransferActions
{
    /// <summary>
    /// The act of transferring/moving (abstract or concrete) animate or inanimate objects from one place to another.
    /// </summary>
    public class TransferAction : Action
    {
        /// <summary>
        /// Place - A sub property of location. The original location of the object or the agent before the action.
        /// </summary>
        [JsonProperty("fromLocation")]
        public Place FromLocation { get; set; }

        /// <summary>
        /// Place - A sub property of location. The final location of the object or the agent after the action.
        /// </summary>
        [JsonProperty("toLocation")]
        public Place ToLocation { get; set; }
    }
}
