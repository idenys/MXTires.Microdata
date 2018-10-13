#region License
// Copyright (c) 2018 1010Tires.com
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

namespace MXTires.Microdata.Places
{
    /// <summary>
    /// A tourist destination. In principle any Place can be a TouristDestination from a City, Region or Country to an AmusementPark or Hotel. 
    /// This Type can be used on its own to describe a general TourstDestination, 
    /// or be used as an additionalType to add tourist relevant properties to any other Place. 
    /// A TouristDestination is defined as a Place that contains, or is colocated with, one or more TourstAttractions, 
    /// often linked by a similar theme or interest to a particular touristType. 
    /// The UNWTO defines Destination (main destination of a tourism trip) as the place visited that is central to the decision to take the trip. 
    /// (See examples below).
    /// </summary>
    public class TouristDestination : Place
    {
        /// <summary>
        /// TouristAttraction - Attraction located at destination.
        /// </summary>
        [JsonProperty("includesAttraction")]
        public TouristAttraction IncludesAttraction { get; set; }

        /// <summary>
        /// Audience or Text - Attraction suitable for type(s) of tourist. eg. Children, visitors from a particular country, etc.
        /// </summary>
        [JsonProperty("touristType")]
        public object TouristType { get; set; }

    }
}
