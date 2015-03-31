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
using Newtonsoft.Json;

namespace MXTires.Microdata
{
    public class QuantitativeValue : Thing
    {
        /// <summary>
        /// Number 	The upper value of some characteristic or property.
        /// </summary>
        [JsonProperty("maxValue")]
        public float MaxValue { get; set; }
        /// <summary>
        /// Number 	The lower value of some characteristic or property.
        /// </summary>
        [JsonProperty("minValue")]
        public float MinValue { get; set; }

        /// <summary>
        /// Text -The unit of measurement given using the UN/CEFACT Common Code (3 characters).
        /// </summary>
        [JsonProperty("unitCode")]
        public string UnitCode { get; set; }

        /// <summary>
        /// Number 	The value of the product characteristic.
        /// </summary>
        [JsonProperty("value")]
        public float Value { get; set; }

        /// <summary>
        /// Enumeration  or StructuredValue 	A pointer to a secondary value that provides additional information on the original value, e.g. a reference temperature.
        /// </summary>
        [JsonProperty("valueReference")]
        public object ValueReference { get; set; }
    }
}
