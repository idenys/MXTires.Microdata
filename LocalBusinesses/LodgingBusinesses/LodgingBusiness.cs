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
using System.Text;
using System.Threading.Tasks;
using MXTires.Microdata.Intangible;
using MXTires.Microdata.Intangible.StructuredValues;
using MXTires.Microdata.Validators;
using Newtonsoft.Json;

namespace MXTires.Microdata.LocalBusinesses.LodgingBusinesses
{
    /// <summary>
    /// A lodging business, such as a motel, hotel, or inn.
    /// </summary>
    public class LodgingBusiness : LocalBusiness
    {
        /// <summary>
        /// LocationFeatureSpecification - An amenity feature (e.g. a characteristic or service) of the Accommodation. This generic property does not make a statement about whether the feature is included in an offer for the main accommodation or available at extra costs.
        /// </summary>
        [JsonProperty("amenityFeature")]
        public LocationFeatureSpecification AmenityFeature { get; set; }

        /// <summary>
        /// Audience - An intended audience, i.e. a group for whom something was created. Supersedes <see cref="ServiceAudience"/>.
        /// </summary>
        [JsonProperty("audience")]
        public Audience Audience { get; set; }

        /// <summary>
        /// Audience - The audience eligible for this service. Superseded by <see cref="Audience"/>
        /// </summary>
        [JsonProperty("serviceAudience")]
        public Audience ServiceAudience { get; set; }

        object availableLanguage;

        /// <summary>
        /// Language  or Text - A language someone may use with the item. Please use one of the language codes from the IETF BCP 47 standard. <seealso cref="InLanguage"/> 
        /// </summary>
        [JsonProperty("availableLanguage")]
        public object AvailableLanguage
        {
            get { return availableLanguage; }
            set
            {
                var validator = new TypeValidator(typeof(Language), typeof(String));
                validator.Validate(value);
                availableLanguage = value;
            }
        }

        object inLanguage;

        /// <summary>
        /// Language  or Text - The language of the content or performance or used in an action. Please use one of the language codes from the IETF BCP 47 standard. <seealso cref="AvailableLanguage"/> 
        /// </summary>
        [JsonProperty("inLanguage")]
        public object InLanguage
        {
            get { return inLanguage; }
            set
            {
                var validator = new TypeValidator(typeof(Language), typeof(String));
                validator.Validate(value);
                inLanguage = value;
            }
        }

        /// <summary>
        /// DateTime - The earliest someone may check into a lodging establishment.
        /// </summary>
        [JsonProperty("checkinTime")]
        public DateTime? CheckinTime { get; set; }

        /// <summary>
        /// DateTime - The latest someone may check out of a lodging establishment.
        /// </summary>
        [JsonProperty("checkoutTime")]
        public DateTime? CheckoutTime { get; set; }

        object petsAllowed;
        /// <summary>
        /// Boolean  or Text - Indicates whether pets are allowed to enter the accommodation or lodging business. More detailed information can be put in a text value.
        /// </summary>
        [JsonProperty("petsAllowed")]
        public object PetsAllowed
        {
            get { return petsAllowed; }
            set
            {
                var validator = new TypeValidator(typeof(Boolean), typeof(String));
                validator.Validate(value);
                petsAllowed = value;
            }
        }

        /// <summary>
        /// Rating - An official rating for a lodging business or food establishment, e.g. from national associations or standards bodies. Use the author property to indicate the rating organization, e.g. as an Organization with name such as (e.g. HOTREC, DEHOGA, WHR, or Hotelstars).
        /// </summary>
        [JsonProperty("starRating")]
        public Rating StarRating { get; set; }
    }
}
