using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace MXTires.Microdata
{
    public class QuantitativeValue : Thing
    {
        /// <summary>
        /// Number 	The upper value of some characteristic or property.
        /// </summary>
        [JsonProperty("maxValue")]
        public float MaxValue { get; set; }
        /// <summary>
        /// Number 	The lower value of some characteristic or property.
        /// </summary>
        [JsonProperty("minValue")]
        public float MinValue { get; set; }

        /// <summary>
        /// Text -The unit of measurement given using the UN/CEFACT Common Code (3 characters).
        /// </summary>
        [JsonProperty("unitCode")]
        public string UnitCode { get; set; }

        /// <summary>
        /// Number 	The value of the product characteristic.
        /// </summary>
        [JsonProperty("value")]
        public float Value { get; set; }

        /// <summary>
        /// Enumeration  or StructuredValue 	A pointer to a secondary value that provides additional information on the original value, e.g. a reference temperature.
        /// </summary>
        [JsonProperty("valueReference")]
        public object ValueReference { get; set; }
    }
}
