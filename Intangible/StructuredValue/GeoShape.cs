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
    /// The geographic shape of a place.
    /// </summary>
    public class GeoShape : Thing
    {
        /// <summary>
        /// Text 	A polygon is the area enclosed by a point-to-point path for which the starting and ending points are the same. A polygon is expressed as a series of four or more space delimited points where the first and final points are identical.
        /// </summary>
        /// <value>The box.</value>
        [JsonProperty("box")]
        public string Box { get; private set; }

        /// <summary>
        /// Text 	A circle is the circular region of a specified radius centered at a specified latitude and longitude. A circle is expressed as a pair followed by a radius in meters.
        /// </summary>
        /// <value>The circle.</value>
        [JsonProperty("circle")]
        public string Circle { get; private set; }

        /// <summary>
        /// Text  or Number - The elevation of a location.
        /// </summary>
        /// <value>The elevation.</value>
        [JsonProperty("elevation")]
        public string Elevation { get; private set; }

        /// <summary>
        /// Text 	A line is a point-to-point path consisting of two or more points. A line is expressed as a series of two or more point objects separated by space.
        /// </summary>
        /// <value>The line.</value>
        [JsonProperty("line")]
        public string Line { get; private set; }

        /// <summary>
        /// Text 	A polygon is the area enclosed by a point-to-point path for which the starting and ending points are the same. A polygon is expressed as a series of four or more space delimited points where the first and final points are identical.
        /// </summary>
        /// <value>The polygon.</value>
        [JsonProperty("polygon")]
        public string Polygon { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="GeoShape"/> class.
        /// </summary>
        /// <param name="box">The box.</param>
        /// <param name="circle">The circle.</param>
        /// <param name="elevation">The elevation.</param>
        /// <param name="line">The line.</param>
        /// <param name="polygon">The polygon.</param>
        public GeoShape(string box, string circle, string elevation, string line, string polygon)
        {
            Box = box;
            Circle = circle;
            Elevation = elevation;
            Line = line;
            Polygon = polygon;
        }
    }
}
