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
