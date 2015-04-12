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

using MXTires.Microdata.Intangible.Enumeration;
using Newtonsoft.Json;

namespace MXTires.Microdata.Intangible.StructuredValue
{
    /// <summary>
    /// A structured value providing information about the opening hours of a place or a certain service inside a place.
    /// </summary>
    public class OpeningHoursSpecification : Thing
    {
        public OpeningHoursSpecification(string closes, string dayOfWeek, string opens, string validFrom = null, string validThrough = null)
        {
            Closes = closes;
            DayOfWeek = dayOfWeek;
            Opens = opens;
            ValidFrom = validFrom;
            ValidThrough = validThrough;
        }

        public OpeningHoursSpecification(string closes, DaysOfWeek dayOfWeek, string opens, string validFrom = null, string validThrough = null)
        {
            Closes = closes;
            DayOfWeek = dayOfWeek.ToString();
            Opens = opens;
            ValidFrom = validFrom;
            ValidThrough = validThrough;
        }


        #region Properties
        /// <summary>
        /// Time - The closing hour of the place or service on the given day(s) of the week.
        /// </summary>
        [JsonProperty("closes")]
        public string Closes { get; set; }

        /// <summary>
        /// DayOfWeek 	The day of the week for which these opening hours are valid.
        /// </summary>
        [JsonProperty("dayOfWeek")]
        public string DayOfWeek { get; set; }

        /// <summary>
        /// Time - The opening hour of the place or service on the given day(s) of the week.
        /// </summary>
        [JsonProperty("opens")]
        public string Opens { get; set; }

        /// <summary>
        /// DateTime - The date when the item becomes valid.
        /// </summary>
        [JsonProperty("validFrom")]
        public string ValidFrom { get; set; }

        /// <summary>
        /// DateTime - The end of the validity of offer, price specification, or opening hours data.
        /// </summary>
        [JsonProperty("validThrough")]
        public string ValidThrough { get; set; }

        #endregion
    }
}
