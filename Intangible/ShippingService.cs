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

using MXTires.Microdata.Intangible.StructuredValues;
using Newtonsoft.Json;

namespace MXTires.Microdata.Intangible
{
    /// <summary>
    /// A ShippingService describes a class of shipping service available for a certain type of shipping, generally used
    /// for the customer-facing description of specific shipping services.
    /// </summary>
    public class ShippingService : StructuredValue
    {
        /// <summary>
        /// Text - Indicates when shipping to a particular fulfillmentDestination is not available.
        /// </summary>
        [JsonProperty("fulfillmentType")]
        public string FulfillmentType { get; set; }

        /// <summary>
        /// QuantitativeValue - The typical delay the order has been sent for delivery and the goods reach the final customer.
        /// </summary>
        [JsonProperty("handlingTime")]
        public QuantitativeValue HandlingTime { get; set; }

        /// <summary>
        /// MemberProgramTier - The membership program tier an Offer (or a PriceSpecification, OfferShippingDetails, or MerchantReturnPolicy) is valid for.
        /// </summary>
        [JsonProperty("validForMemberTier")]
        public MemberProgramTier ValidForMemberTier { get; set; }
    }
}
