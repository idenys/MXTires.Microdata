#region License
// Copyright (c) 2017 1010Tires.com
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

using MXTires.Microdata.Intangible.Enumeration;
using Newtonsoft.Json;

namespace MXTires.Microdata.Intangible.StructuredValues.PriceSpecifications
{
    /// <summary>
    /// The price for the delivery of an offer using a particular delivery method.
    /// </summary>
    public class DeliveryChargeSpecification : PriceSpecification
    {
        /// <summary>
        /// DeliveryMethod - The delivery method(s) to which the delivery charge or payment charge specification applies.
        /// </summary>
        [JsonProperty("appliesToDeliveryMethod")]
        public DeliveryMethod AppliesToDeliveryMethod { get; set; }

        /// <summary>
        /// AdministrativeArea or GeoShape or Place or Text - The geographic area where a service or offered item is provided. 
        /// Supersedes <see cref="ServiceArea"/> .
        /// </summary>
        [JsonProperty("areaServed")]
        public object AreaServed { get; set; }

        /// <summary>
        /// AdministrativeArea or GeoShape or Place or Text - The geographic area where a service or offered item is provided. 
        /// Superseded by <see cref="AreaServed"/>.
        /// </summary>
        [JsonProperty("serviceArea")]
        public object ServiceArea { get; set; }

        /// <summary>
        /// GeoShape  or Place  or Text    The ISO 3166-1 (ISO 3166-1 alpha-2) or ISO 3166-2 code, the place, or the GeoShape for the geo-political region(s) 
        /// for which the offer or delivery charge specification is valid.
        /// <seealso cref="IneligibleRegion"/>.
        /// </summary>
        [JsonProperty("eligibleRegion")]
        public object EligibleRegion { get; set; }

        /// <summary>
        /// GeoShape  or Place  or Text - The ISO 3166-1 (ISO 3166-1 alpha-2) or ISO 3166-2 code, the place, or the GeoShape for the geo-political region(s) 
        /// for which the offer or delivery charge specification is not valid, e.g.a region where the transaction is not allowed.
        /// <seealso cref="EligibleRegion"/>
        /// </summary>
        [JsonProperty("ineligibleRegion")]
        public object IneligibleRegion { get; set; }
    }
}
