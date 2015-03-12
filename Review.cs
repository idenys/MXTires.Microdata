using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MXTires.Microdata
{
    public class Review : CreativeWork
    {
        /// <summary>
        /// Thing 	The item that is being reviewed/rated.
        /// </summary>
        [JsonProperty("itemReviewed")]
        public Thing ItemReviewed { get; set; }

        /// <summary>
        /// Text - The actual body of the review.
        /// </summary>
        [JsonProperty("reviewBody")]
        public string reviewBody { get; set; }

        /// <summary>
        /// Rating 	The rating given in this review. Note that reviews can themselves be rated. 
        /// The reviewRating applies to rating given by the review. The aggregateRating property applies to the review itself, as a creative work.
        /// </summary>
        [JsonProperty("reviewRating")]
        public string reviewRating { get; set; }
    }
}
