using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MXTires.Microdata.Intangible
{
    public class Audience : Thing
    {
        /// <summary>
        /// The target group associated with a given audience (e.g. veterans, car owners, musicians, etc.) domain: Audience Range: Text
        /// </summary>
        [JsonProperty("audienceType")]
        public string AudienceType { get; set; }

        /// <summary>
        /// The geographic area associated with the audience.
        /// </summary>
        [JsonProperty("administrativeArea")]
        public string AdministrativeArea { get; set; }

    }
}