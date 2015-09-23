using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MXTires.Microdata.LocalBusinesses;
using Newtonsoft.Json;

namespace MXTires.Microdata.Actions.PlayActions
{
    /// <summary>
    /// The act of posing a question / favor to someone.
    /// Related actions:
    /// ReplyAction: Appears generally as a response to MXTires
    /// </summary>
    public class PerformAction : PlayAction
    {
        /// <summary>
        /// EntertainmentBusiness 	A sub property of location. The entertainment business where the action occurred.
        /// </summary>
        [JsonProperty("entertainmentBusiness")]
        public EntertainmentBusiness EntertainmentBusiness { get; set; }
    }
}
