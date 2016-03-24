using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Newtonsoft.Json;
using MXTires.Microdata.CreativeWorks;
using MXTires.Microdata.Validators;

namespace MXTires.Microdata.Intangible
{
    /// <summary>
    /// A brand is a name used by an organization or business person for labeling a product, product group, or similar.
    /// </summary>
    public class Brand : Thing
    {
        object logo;
        /// <summary>
        /// An associated logo.
        /// </summary>
        [JsonProperty("logo")]
        public object Logo
        {
            get { return logo; }
            set
            {
                var validator = new TypeValidator(typeof(ImageObject), typeof(String));
                validator.Validate(value);
                logo = value;
            }
        }

        /// <summary>
        /// Review - A review of the item. Supersedes reviews.
        /// </summary>
        [JsonProperty("review")]
        public Review Review { get; set; }

        /// <summary>
        /// Reviews - A reviews of the item. Superseded by review.
        /// </summary>
        [JsonProperty("reviews")]
        public IList<Review> Reviews { get; set; }

        /// <summary>
        /// AggregateRating - The overall rating, based on a collection of reviews or ratings, of the item.
        /// </summary>
        [JsonProperty("aggregateRating")]
        public AggregateRating AggregateRating { get; set; }
    }
}
