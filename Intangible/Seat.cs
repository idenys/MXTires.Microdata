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
namespace MXTires.Microdata.Intangible
{
    /// <summary>
    /// Used to describe a seat, such as a reserved seat in an event reservation.
    /// </summary>
    public class Seat : Thing
    {
        /// <summary>
        /// Text 	The location of the reserved seat (e.g., 27).
        /// </summary>
        [JsonProperty("seatNumber")]
        public string SeatNumber { get; set; }

        /// <summary>
        /// Text 	The row location of the reserved seat (e.g., B).
        /// </summary>
        [JsonProperty("seatRow")]
        public string SeatRow { get; set; }

        /// <summary>
        /// Text 	The section location of the reserved seat (e.g. Orchestra).
        /// </summary>
        [JsonProperty("seatSection")]
        public string SeatSection { get; set; }

        /// <summary>
        /// Text  or QualitativeValue 	The type/class of the seat.
        /// </summary>
        [JsonProperty("seatingType")]
        public string SeatingType { get; set; }
    }
}