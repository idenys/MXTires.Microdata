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
    /// The costs of settling the payment using a particular payment method.
    /// </summary>
    public class PaymentChargeSpecification : PriceSpecification
    {
        /// <summary>
        /// DeliveryMethod  The delivery method(s) to which the delivery charge or payment charge specification applies.
        /// </summary>
        [JsonProperty("appliesToDeliveryMethod")]
        public DeliveryMethod AppliesToDeliveryMethod { get; set; }

        /// <summary>
        /// PaymentMethod The payment method(s) to which the payment charge specification applies.
        /// </summary>
        [JsonProperty("appliesToPaymentMethod")]
        public PaymentMethod AppliesToPaymentMethod { get; set; }
        
    }
}
