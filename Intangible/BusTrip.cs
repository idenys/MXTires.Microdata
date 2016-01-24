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
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MXTires.Microdata.Places.CivicStructures;
using MXTires.Microdata.Validators;
using Newtonsoft.Json;

namespace MXTires.Microdata.Intangible
{
    /// <summary>
    ///A trip on a commercial bus line.
    /// </summary>
    public class BusTrip : Thing
    {
        private Thing arrivalBusStop;
        /// <summary>
        /// BusStation  or BusStop - The stop or station from which the bus arrives.
        /// </summary>
        /// <value>The produces.</value>
        [JsonProperty("arrivalBusStop")]
        public Thing ArrivalBusStop
        {
            get { return this.arrivalBusStop; }
            set
            {
                TypeValidator validator = new TypeValidator(typeof(BusStation), typeof(BusStop));
                validator.Validate(value);
                this.arrivalBusStop = value;
            }
        }

        /// <summary>
        /// DateTime -The expected arrival time.
        /// </summary>
        /// <value>The produces.</value>
        [JsonProperty("arrivalTime")]
        public DateTime? ArrivalTime { get; set; }

        /// <summary>
        /// Text - The name of the bus (e.g. Bolt Express).
        /// </summary>
        /// <value>The produces.</value>
        [JsonProperty("busName")]
        public String BusName { get; set; }

        /// <summary>
        /// Text - The unique identifier for the bus.
        /// </summary>
        /// <value>The produces.</value>
        [JsonProperty("busNumber")]
        public String BusNumber { get; set; }

        private Thing departureBusStop;
        /// <summary>
        /// BusStation  or BusStop - The stop or station from which the bus departs.
        /// </summary>
        /// <value>The produces.</value>
        [JsonProperty("departureBusStop")]
        public Thing DepartureBusStop
        {
            get { return this.departureBusStop; }
            set
            {
                TypeValidator validator = new TypeValidator(typeof(BusStation), typeof(BusStop));
                validator.Validate(value);
                this.departureBusStop = value;
            }
        }

        /// <summary>
        /// DateTime - The expected departure time.
        /// </summary>
        /// <value>The produces.</value>
        [JsonProperty("departureTime")]
        public DateTime? DepartureTime { get; set; }

        private Thing provider;
        /// <summary>
        /// Person or Organization - The service provider, service operator, or service performer; the goods producer. Another party (a seller) may offer those services or goods on behalf of the provider. A provider may also serve as the seller. Supersedes carrier.
        /// </summary>
        /// <value>The produces.</value>
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
    }
}
