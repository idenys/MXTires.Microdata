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

namespace MXTires.Microdata.Intangible.StructuredValue
{
    /// <summary>
    /// The geographic coordinates of a place or event.
    /// </summary>
    public class GeoCoordinates : Thing
    {
        public GeoCoordinates(string latitude, string longitude) {
            Latitude = latitude; 
            Longitude = longitude;
        }

        public GeoCoordinates(string elevation, string latitude, string longitude)
        {
            Latitude = latitude;
            Longitude = longitude;
            Elevation = elevation;
        }
        /// <summary>
        /// Text  or Number - The elevation of a location.
        /// </summary>
        [JsonProperty("elevation")]
        public string Elevation { get; set; }

        /// <summary>
        /// Text  or Number - The latitude of a location. For example 37.42242.
        /// </summary>
        [JsonProperty("latitude")]
        public string Latitude;

        /// <summary>
        /// Text  or Number - The longitude of a location. For example -122.08585.
        /// </summary>
        [JsonProperty("longitude")]
        public string Longitude;
    }
}
