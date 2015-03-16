using System.Collections.Generic;
using Newtonsoft.Json;

namespace MXTires.Microdata
{
    /// <summary>
    /// Entities that have a somewhat fixed, physical extension.
    /// </summary>
    public class Place : Thing
    {
        /// <summary>
        /// The location of the event, organization or action.
        /// </summary>
        [JsonProperty("geo")]
        public GeoCoordinates Geo { get; set; }

        /// <summary>
        /// A URL to a map of the place. Supersedes map, maps.
        /// </summary>
        [JsonProperty("hasMap")]
        public Map HasMap { get; set; }

        /// <summary>
        /// OpeningHoursSpecification - The opening hours of a certain place.
        /// </summary>
        [JsonProperty("openingHoursSpecification")]
        public List<OpeningHoursSpecification> OpeningHoursSpecification { get; set; }
    }
}
