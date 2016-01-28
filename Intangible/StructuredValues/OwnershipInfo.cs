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
using Newtonsoft.Json;
namespace MXTires.Microdata.Intangible.StructuredValues
{
    /// <summary>
    /// A structured value providing information about when a certain organization or person owned a certain product
    /// </summary>
    public class OwnershipInfo : StructuredValue
    {
        /// <summary>
        /// Organization  or  Person - The organization or person from which the product was acquired.
        /// </summary>
        [JsonProperty("acquiredFrom")]
        public Thing AcquiredFrom { get; set; }

        /// <summary>
        /// DateTime - The date and time of obtaining the product.
        /// </summary>
        [JsonProperty("ownedFrom")]
        public DateTime? OwnedFrom { get; set; }

        /// <summary>
        /// DateTime - The date and time of giving up ownership on the product.
        /// </summary>
        [JsonProperty("ownedThrough")]
        public DateTime? OwnedThrough { get; set; }


        /// <summary>
        /// Product - The product that this structured value is referring to.
        /// </summary>
        [JsonProperty("typeOfGood")]
        public Product TypeOfGood { get; set; }
    }
}