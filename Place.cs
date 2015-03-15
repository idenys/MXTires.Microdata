using System.Collections.Generic;
using Newtonsoft.Json;

namespace MXTires.Microdata
{
    /// <summary>
    /// Entities that have a somewhat fixed, physical extension.
    /// </summary>
    public class Place :Thing
    {
        /// <summary>
        /// The location of the event, organization or action.
        /// </summary>
        [JsonProperty("geo")]
        public GeoCoordinates Geo { get; set; }
    }
}
