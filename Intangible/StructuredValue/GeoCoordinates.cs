using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace MXTires.Microdata.Intangible.StructuredValue
{
    /// <summary>
    /// The geographic coordinates of a place or event.
    /// </summary>
    public class GeoCoordinates : Thing
    {
        public GeoCoordinates(string latitude, string longitude) {
            Latitude = latitude; 
            Longitude = longitude;
        }

        public GeoCoordinates(string elevation, string latitude, string longitude)
        {
            Latitude = latitude;
            Longitude = longitude;
            Elevation = elevation;
        }
        /// <summary>
        /// Text  or Number - The elevation of a location.
        /// </summary>
        [JsonProperty("elevation")]
        public string Elevation { get; set; }

        /// <summary>
        /// Text  or Number - The latitude of a location. For example 37.42242.
        /// </summary>
        [JsonProperty("latitude")]
        public string Latitude;

        /// <summary>
        /// Text  or Number - The longitude of a location. For example -122.08585.
        /// </summary>
        [JsonProperty("longitude")]
        public string Longitude;
    }
}
