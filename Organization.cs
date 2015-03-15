
using Newtonsoft.Json;
namespace MXTires.Microdata
{
    public class Organization : Thing
    {
        /// <summary>
        /// PostalAddress 	Physical address of the item.
        /// </summary>
        [JsonProperty("address")]
        public PostalAddress Address {get;set;}

        /// <summary>
        /// The location of the event, organization or action.
        /// </summary>
        [JsonProperty("location")]
        public Place Location { get; set; }	
    }
}
