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
using Newtonsoft.Json;
using MXTires.Microdata.Intangible.Quantities;
using MXTires.Microdata.Intangible.StructuredValues;
using MXTires.Microdata.Validators;
using System;

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
        /// Text - The opening hours for a business. Opening hours can be specified as a weekly time range, starting with days, then times per day. Multiple days can be listed with commas ',' separating each day. Day or time ranges are specified using a hyphen '-'.
        ///- Days are specified using the following two-letter combinations: Mo, Tu, We, Th, Fr, Sa, Su.
        ///- Times are specified using 24:00 time. For example, 3pm is specified as 15:00. 
        ///- Here is an example: <time itemprop="openingHours" datetime="Tu,Th 16:00-20:00">Tuesdays and Thursdays 4-8pm</time>. 
        ///- If a business is open 7 days a week, then it can be specified as <time itemprop="openingHours" datetime="Mo-Su">Monday through Sunday, all day</time>.
        /// </summary>
        /// <remarks>Changed to an object for reverse compatibility, since it was <see cref="Duration"/> before</remarks>
        [JsonProperty("openingHours")]
        public List<object> OpeningHours { get; set; }

        /// <summary>
        /// Text 	Cash, credit card, etc.
        /// </summary>
        [JsonProperty("paymentAccepted")]
        public string PaymentAccepted { get; set; }

        /// <summary>
        /// The price range of the business, for example $100 - $240.
        /// </summary>
        [JsonProperty("priceRange")]
        public string PriceRange { get; set; }

        object additionalProperty;
        /// <summary>
        /// A property-value pair representing an additional characteristics of the entitity, e.g. a product feature or another characteristic 
        /// for which there is no matching property in schema.org. 
        /// Note: Publishers should be aware that applications designed to use specific schema.org properties 
        /// (e.g. http://schema.org/width, http://schema.org/color, http://schema.org/gtin13, ...) 
        /// will typically expect such data to be provided using those properties, rather than using the generic property/value mechanism.
        /// </summary>
        /// <value>The additional property.</value>
        [JsonProperty("additionalProperty")]
        public object AdditionalProperty
        {
            get
            {
                return additionalProperty;
            }
            set
            {
                var validator = new TypeValidator(new List<Type>() { typeof(PropertyValue), typeof(IList<PropertyValue>), typeof(List<PropertyValue>) });
                validator.Validate(value);
                additionalProperty = value;
            }
        }
        /// <summary>
        /// The location of the event, organization or action.
        /// </summary>
        [JsonProperty("geo")]
        public GeoCoordinates Geo { get; set; }

        private object hasMap;
        /// <summary>
        /// A URL to a map of the place. Supersedes map, maps.
        /// </summary>
        [JsonProperty("hasMap")]
        public object HasMap {
            get { return hasMap; }
            set
            {
                var validator = new TypeValidator(typeof(Map), typeof(string));
                validator.Validate(value);
                hasMap = value;
            }
        }

        /// <summary>
        /// Boolean - Indicates whether some facility(e.g. <see cref="FoodEstablishment"/>, <see cref="CovidTestingFacility"/>) offers a service that can be used by driving through in a car.
        /// In the case of CovidTestingFacility such facilities could potentially help with social distancing from other potentially-infected users.
        /// </summary>
        [JsonProperty("hasDriveThroughService")]
        public bool HasDriveThroughService { get; set; }

        /// <summary>
        /// OpeningHoursSpecification - The opening hours of a certain place.
        /// </summary>
        [JsonProperty("openingHoursSpecification")]
        public List<OpeningHoursSpecification> OpeningHoursSpecification { get; set; }

        /// <summary>
        /// Place - The basic containment relation between places.
        /// </summary>
        [JsonProperty("containedIn")]
        public Place ContainedIn { get; set; }

        /// <summary>
        /// ImageObject  or URL - An associated logo.
        /// </summary>
        [JsonProperty("logo")]
        public new object Logo { get; set; }

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
        public new Review Review { get; set; }

        /// <summary>
        /// Reviews.
        /// </summary>
        [JsonProperty("reviews")]
        public new  IList<Review> Reviews { get; set; }

    }
}