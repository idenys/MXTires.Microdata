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

using MXTires.Microdata.Places.AdministrativeAreas;
using MXTires.Microdata.Validators;
using Newtonsoft.Json;

namespace MXTires.Microdata.Intangible.StructuredValues
{
    /// <summary>
    /// A DefinedRegion is a geographic area defined by potentially arbitrary (rather than political, administrative or natural geographical) criteria. 
    /// Properties are provided for defining a region by reference to sets of postal codes.
    /// Examples: a delivery destination when shopping.Region where regional pricing is configured.
    /// Requirement 1: Country: US States: "NY", "CA"
    /// Requirement 2: Country: US PostalCode Set: { [94000-94585], [97000, 97999], [13000, 13599]} { [12345, 12345], [78945, 78945], } Region = state, canton, prefecture, autonomous community...
    /// </summary>
    public class DefinedRegion : Thing
    {
        object addressCountry;
        /// <summary>
        /// Country  or Text The country.For example, USA.You can also provide the two-letter ISO 3166-1 alpha-2 country code.
        /// </summary>
        [JsonProperty("addressCountry")]
        public object AddressCountry
        {
            get { return addressCountry; }
            set
            {
                var validator = new TypeValidator(typeof(string), typeof(Country));
                validator.Validate(value);
                addressCountry = value;
            }
        }

        /// <summary>
        /// Text    The region in which the locality is, and which is in the country. For example, California or another appropriate first-level Administrative division
        /// </summary>
        [JsonProperty("addressRegion")]
        public string AddressRegion { get; set; }

        /// <summary>
        /// Text The postal code. For example, 94043.
        /// </summary>
        [JsonProperty("postalCode")]
        public string PostalCode { get; set; }

        /// <summary>
        /// Text    A defined range of postal codes indicated by a common textual prefix. Used for non-numeric systems such as UK.
        /// </summary>
        [JsonProperty("postalCodePrefix")]
        public string PostalCodePrefix { get; set; }

        /// <summary>
        /// PostalCodeRangeSpecification - A defined range of postal codes.
        /// </summary>
        [JsonProperty("postalCodeRange")]
        public PostalCodeRangeSpecification PostalCodeRange { get; set; }
        
    }
}
