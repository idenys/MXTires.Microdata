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
using MXTires.Microdata.Intangible.Enumeration;
using Newtonsoft.Json;

namespace MXTires.Microdata.Intangible.StructuredValues
{
    /// <summary>
    /// A structured value representing the duration and scope of services that will be provided to a customer free of charge in case of a defect or malfunction of a product.
    /// </summary>
    public class WarrantyPromise : StructuredValue
    {
        /// <summary>
        /// QuantitativeValue - The duration of the warranty promise. 
        /// Common unitCode values are ANN for year, MON for months, or DAY for days.
        /// </summary>
        /// <value>The duration of warranty.</value>
        [JsonProperty("durationOfWarranty")]
        public QuantitativeValue DurationOfWarranty { get; private set; }

        /// <summary>
        /// WarrantyScope 	The scope of the warranty promise.
        /// </summary>
        /// <value>The warranty scope.</value>
        [JsonProperty("warrantyScope")]
        public WarrantyScope WarrantyScope { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="WarrantyPromise"/> class.
        /// </summary>
        /// <param name="durationOfWarranty">The duration of warranty.</param>
        /// <param name="warrantyScope">The warranty scope.</param>
        public WarrantyPromise(QuantitativeValue durationOfWarranty, WarrantyScope warrantyScope) {
            DurationOfWarranty = durationOfWarranty;
            WarrantyScope = warrantyScope;
        }
    }
}
