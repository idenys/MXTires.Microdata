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

using MXTires.Microdata.Intangible;
using MXTires.Microdata.Intangible.StructuredValues;
using MXTires.Microdata.Validators;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MXTires.Microdata
{
    /// <summary>
    /// A point value or interval for product characteristics and other purposes.
    /// </summary>
    public class QuantitativeValue : StructuredValue
    {
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
        /// Number - The upper value of some characteristic or property.
        /// </summary>
        /// <value>The maximum value.</value>
        [JsonProperty("maxValue")]
        public float? MaxValue { get; set; }

        /// <summary>
        /// Number - The lower value of some characteristic or property.
        /// </summary>
        /// <value>The minimum value.</value>
        [JsonProperty("minValue")]
        public float? MinValue { get; set; }

        /// <summary>
        /// Text - The unit of measurement given using the UN/CEFACT Common Code (3 characters).
        /// </summary>
        /// <value>The unit code.</value>
        [JsonProperty("unitCode")]
        public string UnitCode { get; set; }

        /// <summary>
        /// Number - The value of the product characteristic.
        /// </summary>
        /// <value>The value.</value>
        [JsonProperty("value")]
        public float Value { get; set; }

        /// <summary>
        /// Enumeration or StructuredValue - A pointer to a secondary value that provides additional information on the original value, e.g. a reference temperature.
        /// </summary>
        /// <value>The value reference.</value>
        [JsonProperty("valueReference")]
        public object ValueReference { get; set; }
    }
}
