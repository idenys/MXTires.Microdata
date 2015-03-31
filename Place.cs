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

using System.Collections.Generic;
using Newtonsoft.Json;

namespace MXTires.Microdata
{
    /// <summary>
    /// Entities that have a somewhat fixed, physical extension.
    /// </summary>
    public class Place : Thing
    {
        /// <summary>
        /// The location of the event, organization or action.
        /// </summary>
        [JsonProperty("geo")]
        public GeoCoordinates Geo { get; set; }

        /// <summary>
        /// A URL to a map of the place. Supersedes map, maps.
        /// </summary>
        [JsonProperty("hasMap")]
        public Map HasMap { get; set; }

        /// <summary>
        /// OpeningHoursSpecification - The opening hours of a certain place.
        /// </summary>
        [JsonProperty("openingHoursSpecification")]
        public List<OpeningHoursSpecification> OpeningHoursSpecification { get; set; }
    }
}
