#region License
// Copyright (c) 2020 1010Tires.com
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

namespace MXTires.Microdata.Intangible
{
    /// <summary>
    /// Indicates a range of postalcodes, usually defined as the set of valid codes between postalCodeBegin and postalCodeEnd, inclusively.
    /// </summary>
    public class PostalCodeRangeSpecification : Thing
    {
        /// <summary>
        /// Text - First postal code in a range(included).
        /// </summary>
        [JsonProperty("postalCodeBegin")]
        public string PostalCodeBegin { get; set; }

        /// <summary>
        ///  Text - Last postal code in the range(included). Needs to be after <see cref="PostalCodeBegin"/> .
        /// </summary>
        [JsonProperty("postalCodeEnd")]
        public string PostalCodeEnd { get; set; }
    }
}
