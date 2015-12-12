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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MXTires.Microdata.Intangible;
using Newtonsoft.Json;
using MXTires.Microdata.Intangible.Quantity;
using MXTires.Microdata.Intangible.StructuredValue;

namespace MXTires.Microdata
{
    /// <summary>
    /// A particular physical business or branch of an organization. Examples of LocalBusiness include a restaurant, a particular branch of a restaurant chain, a branch of a bank, a medical practice, a club, a bowling alley, etc.
    /// </summary>
    public class LocalBusiness : Organization, MXTires.Microdata.Places.IPlace
    {
        /// <summary>
        /// The larger organization that this local business is a branch of, if any.
        /// </summary>
        [JsonProperty("branchOf")]
        public Organization BranchOf { get; set; }

        /// <summary>
        /// Text - The currency accepted (in ISO 4217 currency format).
        /// </summary>
        [JsonProperty("currenciesAccepted")]
        public string CurrenciesAccepted { get; set; }

        /// <summary>
        /// Duration 	The opening hours for a business. Opening hours can be specified as a weekly time range, starting with days, then times per day. Multiple days can be listed with commas ',' separating each day. Day or time ranges are specified using a hyphen '-'.
        ///- Days are specified using the following two-letter combinations: Mo, Tu, We, Th, Fr, Sa, Su.
        ///- Times are specified using 24:00 time. For example, 3pm is specified as 15:00. 
        ///- Here is an example: <time itemprop="openingHours" datetime="Tu,Th 16:00-20:00">Tuesdays and Thursdays 4-8pm</time>. 
        ///- If a business is open 7 days a week, then it can be specified as <time itemprop="openingHours" datetime="Mo-Su">Monday through Sunday, all day</time>.
        /// </summary>
        [JsonProperty("openingHours")]
        public List<Duration> OpeningHours { get; set; }

        /// <summary>
        /// Text 	Cash, credit card, etc.
        /// </summary>
        [JsonProperty("paymentAccepted")]
        public string PaymentAccepted { get; set; }

        /// <summary>
        /// The price range of the business, for example $$$.
        /// </summary>
        [JsonProperty("priceRange")]
        public string PriceRange { get; set; }

        /// <summary>
        ///  <see cref="PropertyValue"/> - A property-value pair representing an additional characteristics of the entity, e.g. a product feature or another characteristic for which there is no matching property in schema.org. 
        /// </summary>
        /// <remarks>
        /// Note: Publishers should be aware that applications designed to use specific schema.org properties (e.g. http://schema.org/width, http://schema.org/color, http://schema.org/gtin13, ...) will typically expect such data to be provided using those properties, rather than using the generic property/value mechanism.
        /// </remarks>
        [JsonProperty("additionalProperty")]
        public PropertyValue AdditionalProperty { get; set; }

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
        public string Telephone { get; set; }
    }
}