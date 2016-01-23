using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MXTires.Microdata.Intangible.Enumeration;
using MXTires.Microdata.Validators;
using Newtonsoft.Json;

namespace MXTires.Microdata.Organizations
{
    /// <summary>
    /// An organization that provides flights for passengers.
    /// </summary>
    public class Airline : Organization
    {
        /// <summary>
        /// BoardingPolicyType - The type of boarding policy used by the airline (e.g. zone-based or group-based).
        /// </summary>
        [JsonProperty("boardingPolicy")]
        public BoardingPolicyType BoardingPolicy { get; set; }

        /// <summary>
        /// Text - IATA identifier for an airline or airport.
        /// </summary>
        [JsonProperty("iataCode")]
        public string IataCode { get; set; }
    }
}
