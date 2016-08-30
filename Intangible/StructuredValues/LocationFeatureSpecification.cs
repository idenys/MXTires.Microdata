#region License
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

using System;
using Newtonsoft.Json;

namespace MXTires.Microdata.Intangible.StructuredValues
{
    /// <summary>
    /// Specifies a location feature by providing a structured value representing a feature of an 
    /// accommodation as a property-value pair of varying degrees of formality.
    /// </summary>
    public class LocationFeatureSpecification : PropertyValue
    {
        /// <summary>
        /// OpeningHoursSpecification - The hours during which this service or contact is available.
        /// </summary>
        [JsonProperty("hoursAvailable")]
        public OpeningHoursSpecification HoursAvailable { get; set; }

        /// <summary>
        /// DateTime - The date when the item becomes valid.
        /// </summary>
        [JsonProperty("validFrom")]
        public DateTime? ValidFrom { get; set; }

        /// <summary>
        /// DateTime - The date after when the item is not valid. For example the end of an offer, salary period, or a period of opening hours.
        /// </summary>
        [JsonProperty("validThrough")]
        public DateTime? ValidThrough { get; set; }

        /// <summary>
        /// Default constructor
        /// </summary>
        /// <param name="name"></param>
        /// <param name="value"></param>
        /// <param name="hoursAvailable"></param>
        /// <param name="validFrom"></param>
        /// <param name="validThrough"></param>
        public LocationFeatureSpecification(string name, object value, OpeningHoursSpecification hoursAvailable,
                DateTime? validFrom, DateTime? validThrough)
                : base(name, value)
        {
            HoursAvailable = hoursAvailable;
            ValidFrom = validFrom;
            ValidThrough = validThrough;
        }
    }
}
