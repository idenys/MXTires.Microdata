using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MXTires.Microdata
{
    public class AggregateRating : Rating
    {
        /// <summary>
        /// Thing 	The item that is being reviewed/rated.
        /// </summary>
        [JsonProperty("itemReviewed")]
        public Thing ItemReviewed { get; set; }

        /// <summary>
        /// The count of total number of ratings.
        /// </summary>
        [JsonProperty("ratingCount")]
        public string RatingCount { get; set; }

        /// <summary>
        /// The count of total number of reviews.
        /// </summary>
        [JsonProperty("reviewCount")]
        public string ReviewCount { get; set; }
    }
}