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
using MXTires.Microdata.Intangible.StructuredValue;
using Newtonsoft.Json;
using MXTires.Microdata.Intangible;

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

        /// <summary>
        /// PostalAddress - Physical address of the item.
        /// </summary>
        [JsonProperty("address")]
        public PostalAddress address { get; set; }

        /// <summary>
        ///  AggregateRating - The overall rating, based on a collection of reviews or ratings, of the item.
        /// </summary>
        [JsonProperty("aggregateRating")]
        public AggregateRating aggregateRating { get; set; }

        /// <summary>
        /// Place - The basic containment relation between places.
        /// </summary>
        [JsonProperty("containedIn")]
        public Place containedIn { get; set; }

        /// <summary>
        /// Event - Upcoming or past event associated with this place, organization, or action. Supersedes events.
        /// </summary>
        [JsonProperty("event")]
        public Event Event { get; set; }

        /// <summary>
        /// Text - The fax number.
        /// </summary>
        [JsonProperty("faxNumber")]
        public string FaxNumber { get; set; }

        /// <summary>
        /// Text - The Global Location Number (GLN, sometimes also referred to as International Location Number or ILN) of the respective organization, person, or place. The GLN is a 13-digit number used to identify parties and physical locations.
        /// </summary>
        [JsonProperty("globalLocationNumber")]
        public string GlobalLocationNumber { get; set; }

        /// <summary>
        /// Text - A count of a specific user interactions with this item—for example, 20 UserLikes, 5 UserComments, or 300 UserDownloads. The user interaction type should be one of the sub types of UserInteraction.
        /// </summary>
        [JsonProperty("interactionCount")]
        public string InteractionCount { get; set; }

        /// <summary>
        /// Text 	The International Standard of Industrial Classification of All Economic Activities (ISIC), Revision 4 code for a particular organization, business person, or place.
        /// </summary>
        [JsonProperty("isicV4")]
        public string IsicV4 { get; set; }

        /// <summary>
        /// ImageObject  or URL - An associated logo.
        /// </summary>
        [JsonProperty("logo")]
        public object Logo { get; set; }

        /// <summary>
        /// Photograph  or ImageObject 	A photograph of this place. Supersedes photos.
        /// </summary>
        [JsonProperty("photo")]
        public Thing Photo { get; set; }

        /// <summary>
        /// Photos.
        /// </summary>
        [JsonProperty("photos")]
        public IList<Thing> Photos { get; set; }

        /// <summary>
        /// Review - A review of the item. Supersedes reviews.
        /// </summary>
        [JsonProperty("review")]
        public Review Review { get; set; }

        /// <summary>
        /// Reviews.
        /// </summary>
        [JsonProperty("reviews")]
        public IList<Review> Reviews { get; set; }

        /// <summary>
        /// Text - The telephone number.
        /// </summary>
        [JsonProperty("telephone")]
        public PostalAddress Telephone { get; set; }
    }
}
