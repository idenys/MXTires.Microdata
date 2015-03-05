using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MXTires.Microdata
{
    public class Rating : Thing
    {
        /// <summary>
        /// Number  or Text. The highest value allowed in this rating system. If bestRating is omitted, 5 is assumed.
        /// </summary>
        [JsonProperty("bestRating")]
        public string BestRating { get; set; }
        /// <summary>
        /// Text. The rating for the content.
        /// </summary>
        [JsonProperty("ratingValue")]
        public string RatingValue { get; set; }
        /// <summary>
        /// The lowest value allowed in this rating system. If worstRating is omitted, 1 is assumed.
        /// </summary>
        [JsonProperty("worstRating")]
        public string WorstRating { get; set; }
    }
}