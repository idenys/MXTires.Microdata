#region License
// Copyright (c) 2015 1010Tires.com
//
// Permission is hereby granted, free of charge, to any person
// obtaining a copy of this software and associated documentation
// files (the "Software"), to deal in the Software without
// restriction, including without limitation the rights to use,
// copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the
// Software is furnished to do so, subject to the following
// conditions:
//
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
// OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
// HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
// WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
// OTHER DEALINGS IN THE SOFTWARE.
#endregion

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MXTires.Microdata.Validators;

namespace MXTires.Microdata.Intangible
{
    /// <summary>
    /// Class Rating.
    /// </summary>
    public class Rating : Thing
    {
        private Thing author;
        /// <summary>
        /// Organization or Person - The author of this content or rating. Please note that author is special in that HTML 5 provides a special mechanism for indicating authorship via the rel tag.
        /// </summary>
        [JsonProperty("author")]
        public Thing Author
        {
            get { return author; }
            set
            {
                var validator = new TypeValidator(typeof(Organization), typeof(Person));
                validator.Validate(value);
                author = value;
            }
        }

        /// <summary>
        /// The best rating
        /// </summary>
        string bestRating = "5";
        /// <summary>
        /// Number  or Text. The highest value allowed in this rating system. If bestRating is omitted, 5 is assumed.
        /// </summary>
        /// <value>The best rating.</value>
        [JsonProperty("bestRating")]
        public string BestRating
        {
            get { return bestRating; }
            set { bestRating = value; }
        }
        /// <summary>
        /// Text. The rating for the content.
        /// </summary>
        /// <value>The rating value.</value>
        [JsonProperty("ratingValue")]
        public string RatingValue { get; set; }

        /// <summary>
        /// Text - A short explanation (e.g. one to two sentences) providing background context and other information that led to the conclusion expressed in the rating.
        /// </summary>
        [JsonProperty("ratingExplanation")]
        public string RatingExplanation { get; set; }

        /// <summary>
        /// StructuredValue or Text - This Review or Rating is relevant to this part or facet of the itemReviewed.
        /// </summary>
        [JsonProperty("reviewAspect")]
        public string ReviewAspect { get; set; }

        /// <summary>
        /// The worst rating
        /// </summary>
        string worstRating = "1";
        /// <summary>
        /// The lowest value allowed in this rating system. If worstRating is omitted, 1 is assumed.
        /// </summary>
        /// <value>The worst rating.</value>
        [JsonProperty("worstRating")]
        public string WorstRating
        {
            get { return worstRating; }
            set { worstRating = value; }
        }

        /// <summary>
        /// Default struct
        /// </summary>
        public Rating() { }

        /// <summary>
        /// Default struct
        /// </summary>
        /// <param name="ratingValue">The rating value.</param>
        public Rating(double ratingValue) {
            RatingValue = ratingValue.ToString("#.##");
        }

        /// <summary>
        /// Default struct
        /// </summary>
        /// <param name="ratingValue">The rating value.</param>
        public Rating(string ratingValue)
        {
            RatingValue = ratingValue;
        }

    }
}