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

using MXTires.Microdata.Intangible.Enumeration;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace MXTires.Microdata.Intangible.StructuredValues
{
    /// <summary>
    /// A structured value indicating the quantity, unit of measurement, and business function of goods included in a bundle offer.
    /// </summary>
    public class TypeAndQuantityNode : StructuredValue
    {
        /// <summary>
        /// Number 	The quantity of the goods included in the offer.
        /// </summary>
        [JsonProperty("amountOfThisGood")]
        public float AmountOfThisGood { get; set; }		

        /// <summary>
        /// BusinessFunction - The business function (e.g. sell, lease, repair, dispose) of the offer or component of a bundle (TypeAndQuantityNode). The default is http://purl.org/goodrelations/v1#Sell.
        /// </summary>
        [JsonProperty("businessFunction")]
        [JsonConverter(typeof(StringEnumConverter))]
        public BusinessFunction BusinessFunction { get; set; }		
        
        /// <summary>
        /// Product 	The product that this structured value is referring to.
        /// </summary>
        [JsonProperty("typeOfGood")]
        public Product TypeOfGood  { get; set; }		

        /// <summary>
        /// Text - The unit of measurement given using the UN/CEFACT Common Code (3 characters).
        /// </summary>
        [JsonProperty("unitCode")]
        public string UnitCode  { get; set; }		
    }
}
