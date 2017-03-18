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

using Newtonsoft.Json;

namespace MXTires.Microdata.Intangible.StructuredValues.PriceSpecifications
{
    /// <summary>
    /// The price asked for a given offer by the respective organization or person.
    /// </summary>
    public class UnitPriceSpecification : PriceSpecification
    {
        /// <summary>
        /// Number - This property specifies the minimal quantity and rounding increment that will be the basis for the billing.
        /// The unit of measurement is specified by the unitCode property.
        /// </summary>
        [JsonProperty("billingIncrement")]
        public string BillingIncrement { get; set; }

        /// <summary>
        /// Text - A short text or acronym indicating multiple price specifications for the same offer, e.g. 
        /// SRP for the suggested retail price or INVOICE for the invoice price, mostly used in the car industry.
        /// </summary>
        [JsonProperty("priceType")]
        public string PriceType { get; set; }

        /// <summary>
        /// QuantitativeValue - The reference quantity for which a certain price applies, e.g. 1 EUR per 4 kWh of electricity.This property is a replacement for unitOfMeasurement for the advanced cases where the price does not relate to a standard unit.
        /// </summary>
        [JsonProperty("referenceQuantity")]
        public QuantitativeValue ReferenceQuantity { get; set; }

        /// <summary>
        /// Text  or URL - The unit of measurement given using the UN/CEFACT Common Code(3 characters) or a URL.Other codes than the UN/CEFACT Common Code may be used with a prefix followed by a colon.
        /// </summary>
        [JsonProperty("unitCode")]
        public string UnitCode { get; set; }

        ///Text - A string or text indicating the unit of measurement.Useful if you cannot provide a standard unit code for unitCode.    
        [JsonProperty("unitText")]
        public string UnitText { get; set; }

    }
}
