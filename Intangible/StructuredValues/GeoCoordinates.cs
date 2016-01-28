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
    /// The geographic coordinates of a place or event.
    /// </summary>
    public class GeoCoordinates : Thing
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GeoCoordinates"/> class.
        /// </summary>
        /// <param name="latitude">The latitude.</param>
        /// <param name="longitude">The longitude.</param>
        public GeoCoordinates(string latitude, string longitude) {
            Latitude = latitude; 
            Longitude = longitude;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GeoCoordinates"/> class.
        /// </summary>
        /// <param name="latitude">The latitude.</param>
        /// <param name="longitude">The longitude.</param>
        public GeoCoordinates(float latitude, float longitude)
        {
            Latitude = latitude.ToString();
            Longitude = longitude.ToString();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GeoCoordinates"/> class.
        /// </summary>
        /// <param name="elevation">The elevation.</param>
        /// <param name="latitude">The latitude.</param>
        /// <param name="longitude">The longitude.</param>
        public GeoCoordinates(string elevation, string latitude, string longitude)
        {
            Latitude = latitude;
            Longitude = longitude;
            Elevation = elevation;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GeoCoordinates"/> class.
        /// </summary>
        /// <param name="elevation">The elevation.</param>
        /// <param name="latitude">The latitude.</param>
        /// <param name="longitude">The longitude.</param>
        public GeoCoordinates(float elevation, float latitude, float longitude)
        {
            Latitude = latitude.ToString();
            Longitude = longitude.ToString();
            Elevation = elevation.ToString();
        }
        /// <summary>
        /// Text  or Number - The elevation of a location.
        /// </summary>
        /// <value>The elevation.</value>
        [JsonProperty("elevation")]
        public string Elevation { get; private set; }

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
