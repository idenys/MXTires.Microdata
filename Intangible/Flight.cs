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
using MXTires.Microdata.Intangible.Enumeration;
using MXTires.Microdata.Places.CivicStructures;
using MXTires.Microdata.Validators;
using Newtonsoft.Json;

namespace MXTires.Microdata.Intangible
{
    /// <summary>
    /// An airline flight.
    /// </summary>
    public class Flight : Thing
    {
        /// <summary>
        /// Vehicle  or Text 	The kind of aircraft (e.g., "Boeing 747").
        /// </summary>
        [JsonProperty("aircraft")]
        public object Aircraft { get; set; }

        /// <summary>
        /// Airport 	The airport where the flight terminates.
        /// </summary>
        [JsonProperty("arrivalAirport")]
        public Airport ArrivalAirport { get; set; }

        /// <summary>
        /// Text 	Identifier of the flight's arrival gate.
        /// </summary>
        [JsonProperty("arrivalGate")]
        public String ArrivalGate { get; set; }

        /// <summary>
        /// Text 	Identifier of the flight's arrival terminal.
        /// </summary>
        [JsonProperty("arrivalTerminal")]
        public String ArrivalTerminal { get; set; }

        /// <summary>
        /// DateTime 	The expected arrival time.
        /// </summary>
        [JsonProperty("arrivalTime")]
        public DateTime? ArrivalTime { get; set; }

        /// <summary>
        /// BoardingPolicyType 	The type of boarding policy used by the airline (e.g. zone-based or group-based).
        /// </summary>
        [JsonProperty("boardingPolicy")]
        public BoardingPolicyType BoardingPolicy { get; set; }

        /// <summary>
        /// Airport - The airport where the flight originates.
        /// </summary>
        [JsonProperty("departureAirport")]
        public Airport DepartureAirport { get; set; }

        /// <summary>
        /// Text 	Identifier of the flight's departure gate.
        /// </summary>
        [JsonProperty("departureGate")]
        public String DepartureGate { get; set; }

        /// <summary>
        /// Text - Identifier of the flight's departure terminal.
        /// </summary>
        [JsonProperty("departureTerminal")]
        public String DepartureTerminal { get; set; }

        /// <summary>
        /// DateTime  - The expected departure time.
        /// </summary>
        [JsonProperty("departureTime")]
        public DateTime? DepartureTime { get; set; }

        /// <summary>
        /// Duration  or Text - The estimated time the flight will take.
        /// </summary>
        [JsonProperty("estimatedFlightDuration")]
        public DateTime? EstimatedFlightDuration { get; set; }

        /// <summary>
        /// Distance  or Text - The distance of the flight.
        /// </summary>
        [JsonProperty("flightDistance")]
        public object FlightDistance { get; set; }

        /// <summary>
        /// Text - The unique identifier for a flight including the airline IATA code. For example, if describing United flight 110, where the IATA code for United is 'UA', the flightNumber is 'UA110'.
        /// </summary>
        [JsonProperty("flightNumber")]
        public String FlightNumber { get; set; }

        /// <summary>
        /// Text - Description of the meals that will be provided or available for purchase.
        /// </summary>
        [JsonProperty("mealService")]
        public String MealService { get; set; }

        Thing provider;
        /// <summary>
        /// Person  or Organization - The service provider, service operator, or service performer; the goods producer. Another party (a seller) may offer those services or goods on behalf of the provider. A provider may also serve as the seller. Supersedes carrier.
        /// </summary>
        /// <value>Person or Organization</value>
        [JsonProperty("provider")]
        public Thing Provider
        {
            get { return provider; }
            set
            {
                var validator = new TypeValidator(typeof(Organization), typeof(Person));
                validator.Validate(value);
                provider = value;
            }
        }

        Thing seller;
        /// <summary>
        /// Person  or Organization - An entity which offers (sells / leases / lends / loans) the services / goods. A seller may also be a provider. Supersedes vendor, merchant.
        /// </summary>
        /// <value>Person or Organization</value>
        [JsonProperty("seller")]
        public Thing Seller
        {
            get { return seller; }
            set
            {
                var validator = new TypeValidator(typeof(Organization), typeof(Person));
                validator.Validate(value);
                seller = value;
            }
        }

        /// <summary>
        /// DateTime - The time when a passenger can check into the flight online.
        /// </summary>
        [JsonProperty("webCheckinTime")]
        public DateTime? WebCheckinTime { get; set; }
    }
}
