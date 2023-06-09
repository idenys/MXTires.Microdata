﻿#region License
// Copyright (c) 2016 1010Tires.com
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

namespace MXTires.Microdata.Intangible.StructuredValues
{
    /// <summary>
    /// A monetary value or range. This type can be used to describe an amount of money such as $50 USD, 
    /// or a range as in describing a bank account being suitable for a balance between £1,000 and £1,000,000 GBP, or the value of a salary, etc. 
    /// It is recommended to use PriceSpecification Types to describe the price of an Offer, Invoice, etc.
    /// </summary>
    public class MonetaryAmount : StructuredValue
    {
        /// <summary>
        /// Text - The currency in which the monetary amount is expressed (in 3-letter ISO 4217 format).
        /// </summary>
        [JsonProperty("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// Number - The upper value of some characteristic or property.
        /// </summary>
        [JsonProperty("maxValue")]
        public decimal MaxValue { get; set; } = 0;

        /// <summary>
        /// Number - The lower value of some characteristic or property.
        /// </summary>
        [JsonProperty("minValue")]
        public decimal MinValue { get; set; } = 0;

        /// <summary>
        /// DateTime 	The date when the item becomes valid.
        /// </summary>
        [JsonProperty("validFrom")]
        public DateTime? ValidFrom { get; set; }

        /// <summary>
        /// DateTime - The date after when the item is not valid. For example the end of an offer, salary period, or a period of opening hours.
        /// </summary>
        [JsonProperty("validThrough")]
        public DateTime? ValidThrough { get; set; }

        /// <summary>
        /// Boolean  or Number  or StructuredValue  or Text - 	
        /// The value of the quantitative value or property value node.
        /// For QuantitativeValue and MonetaryAmount, the recommended type for values is 'Number'.
        /// For PropertyValue, it can be 'Text;', 'Number', 'Boolean', or 'StructuredValue'.
        /// </summary>
        [JsonProperty("value")]
        public object Value { get; set; }
        
    }
}
