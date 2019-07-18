#region License
// Copyright (c) 2019 1010Tires.com
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

using MXTires.Microdata.Intangible.Quantities;
using Newtonsoft.Json;

namespace MXTires.Microdata.Intangible.StructuredValues
{
    /// <summary>
    /// A statistical distribution of values.
    /// </summary>
    public class QuantitativeValueDistribution : Thing
    {
        /// <summary>
        /// Duration - The duration of the item(movie, audio recording, event, etc.) in ISO 8601 date format.
        /// </summary>
        [JsonProperty("duration")]
        public Duration Duration { get; set; }

        /// <summary>
        /// Number - The median value.
        /// </summary>
        [JsonProperty("median")]
        public object Median { get; set; }

        /// <summary>
        ///  Number - The 10th percentile value.
        /// </summary>
        [JsonProperty("percentile10")]
        public object Percentile10 { get; set; }

        /// <summary>
        /// Number -The 25th percentile value.
        /// </summary>
        [JsonProperty("percentile25")]
        public object Percentile25 { get; set; }

        /// <summary>
        /// Number - The 75th percentile value.
        /// </summary>
        [JsonProperty("percentile75")]
        public object Percentile75 { get; set; }

        /// <summary>
        /// Number -The 90th percentile value.
        /// </summary>
        [JsonProperty("percentile90")]
        public object Percentile90 { get; set; }

    }
}
