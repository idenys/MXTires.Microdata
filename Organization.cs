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

using System.Collections.Generic;
using MXTires.Microdata.Intangible;
using Newtonsoft.Json;
namespace MXTires.Microdata
{
    public class Organization : Thing
    {
        /// <summary>
        /// PostalAddress 	Physical address of the item.
        /// </summary>
        [JsonProperty("address")]
        public PostalAddress Address { get; set; }

        /// <summary>
        /// The location of the event, organization or action.
        /// </summary>
        [JsonProperty("location")]
        public Place Location { get; set; }

        /// <summary>
        /// The telephone number.
        /// </summary>
        [JsonProperty("telephone")]
        public string Telephone { get; set; }

        /// <summary>
        /// A review of the item. Supersedes reviews.
        /// </summary>
        [JsonProperty("review")]
        public Review Review { get; set; }

        /// <summary>
        /// Offer - A pointer to products or services offered by the organization or person.
        /// </summary>
        [JsonProperty("makesOffer")]
        public List<Offer> MakesOffer { get; set; }

        /// <summary>
        /// Text - The official name of the organization, e.g. the registered company name.
        /// </summary>
        [JsonProperty("legalName")]
        public string LegalName { get; set; }

        /// <summary>
        /// AggregateRating - The overall rating, based on a collection of reviews or ratings, of the item.
        /// </summary>
        [JsonProperty("aggregateRating")]
        public AggregateRating AggregateRating { get; set; }

        /// <summary>
        /// Brand  or Organization 	The brand(s) associated with a product or service, or the brand(s) maintained by an organization or business person.
        /// </summary>
        [JsonProperty("brand")]
        public List<Thing> Brand { get; set; }

        /// <summary>
        /// URL - An associated logo.
        /// </summary>
        [JsonProperty("logo")]
        public string Logo { get; set; }

       /// <summary>
        /// ContactPoint - A contact point for a person or organization. Supersedes contactPoints.
        /// </summary>
        [JsonProperty("contactPoint")]
        public ContactPoint ContactPoint { get; set; }
    }
}
