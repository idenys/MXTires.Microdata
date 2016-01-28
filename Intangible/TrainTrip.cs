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
using MXTires.Microdata.Places.CivicStructures;
using MXTires.Microdata.Validators;
using Newtonsoft.Json;

namespace MXTires.Microdata.Intangible
{
    /// <summary>
    /// A trip on a commercial train line.
    /// </summary>
    public class TrainTrip : Thing
    {
        /// <summary>
        /// Text - The platform where the train arrives.
        /// </summary>
        [JsonProperty("arrivalPlatform")]
        public String ArrivalPlatform
        {
            get;
            set;
        }

        /// <summary>
        /// TrainStation - The station where the train trip ends.
        /// </summary>
        [JsonProperty("arrivalStation")]
        public TrainStation ArrivalStation { get; set; }

        /// <summary>
        /// DateTime - The expected arrival time.
        /// </summary>
        [JsonProperty("arrivalTime")]
        public DateTime? ArrivalTime { get; set; }

        /// <summary>
        /// Text - The platform from which the train departs.
        /// </summary>
        [JsonProperty("departurePlatform")]
        public String DeparturePlatform { get; set; }

        /// <summary>
        /// TrainStation - The station from which the train departs.
        /// </summary>
        [JsonProperty("departureStation")]
        public TrainStation DepartureStation { get; set; }

        /// <summary>
        /// DateTime - The expected departure time.
        /// </summary>
        [JsonProperty("departureTime")]
        public DateTime? DepartureTime { get; set; }

        private Thing provider;
        /// <summary>
        /// Person  or Organization - The service provider, service operator, or service performer; the goods producer. 
        /// Another party (a seller) may offer those services or goods on behalf of the provider. 
        /// A provider may also serve as the seller. Supersedes carrier.
        /// </summary>
        [JsonProperty("provider")]
        public Thing Provider
        {
            get { return this.provider; }
            set
            {
                TypeValidator validator = new TypeValidator(typeof(Organization), typeof(ProgramMembership));
                validator.Validate(value);
                this.provider = value;
            }
        }

        /// <summary>
        /// Text - The name of the train (e.g. The Orient Express).
        /// </summary>
        [JsonProperty("trainName")]
        public String TrainName { get; set; }

        /// <summary>
        /// Text - The unique identifier for the train.
        /// </summary>
        [JsonProperty("trainNumber")]
        public String TrainNumber { get; set; }
    }
}
