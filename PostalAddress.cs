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

using Newtonsoft.Json;

namespace MXTires.Microdata
{
    /// <summary>
    /// The mailing address.
    /// </summary>
    public class PostalAddress : ContactPoint
    {
        /// <summary>
        /// Country - The country. For example, USA. You can also provide the two-letter ISO 3166-1 alpha-2 country code.
        /// </summary>
        [JsonProperty("addressCountry")]
        public string AddressCountry { get; set; }

        /// <summary>
        /// Text - The locality. For example, Mountain View.
        /// </summary>
        [JsonProperty("addressLocality")]
        public string AddressLocality { get; set; }

        /// <summary>
        /// Text - The region. For example, CA.
        /// </summary>
        [JsonProperty("addressRegion")]
        public string AddressRegion { get; set; }

        /// <summary>
        /// Text - The post office box number for PO box addresses.
        /// </summary>
        [JsonProperty("postOfficeBoxNumber")]
        public string PostOfficeBoxNumber { get; set; }

        /// <summary>
        /// Text - The postal code. For example, 94043.
        /// </summary>
        [JsonProperty("postalCode")]
        public string PostalCode { get; set; }

        /// <summary>
        /// Text - The street address. For example, 1600 Amphitheatre Pkwy.
        /// </summary>
        [JsonProperty("streetAddress")]
        public string StreetAddress { get; set; }
    }
}
