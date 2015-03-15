using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace MXTires.Microdata
{
    /// <summary>
    /// A contact point—for example, a Customer Complaints department.
    /// </summary>
    public class ContactPoint : Thing
    {
        /// <summary>
        /// AdministrativeArea 	The location served by this contact point (e.g., a phone number intended for Europeans vs. 
        /// North Americans or only within the United States).
        /// </summary>
        [JsonProperty("areaServed")]
        public string AreaServed { get; set; }

        /// <summary>
        /// Language - A language someone may use with the item.
        /// </summary>
        [JsonProperty("availableLanguage")]
        public Language AvailableLanguage { get; set; }

        /// <summary>
        /// ContactPointOption 	An option available on this contact point (e.g. a toll-free number or support for hearing-impaired callers).
        /// </summary>
        [JsonProperty("contactOption")]
        public string ContactOption { get; set; }

        /// <summary>
        /// Text 	A person or organization can have different contact points, for different purposes. For example, a sales contact point, a PR contact point and so on. This property is used to specify the kind of contact point.
        /// </summary>
        [JsonProperty("contactType")]
        public string ContactType { get; set; }

        /// <summary>
        /// Text - Email address.
        /// </summary>
        [JsonProperty("email")]
        public string Email { get; set; }

        /// <summary>
        /// Text 	The fax number. 
        /// </summary>
        [JsonProperty("faxNumber")]
        public string FaxNumber { get; set; }

        /// <summary>
        /// OpeningHoursSpecification 	The hours during which this contact point is available.
        /// </summary>
        [JsonProperty("hoursAvailable")]
        public List<OpeningHoursSpecification> HoursAvailable { get; set; }

        /// <summary>
        /// Product  or Text - The product or service this support contact point is related to (such as product support for a particular product line). This can be a specific product or product line (e.g. "iPhone") or a general category of products or services (e.g. "smartphones").
        /// </summary>
        [JsonProperty("productSupported")]
        public Product ProductSupported { get; set; }

        /// <summary>
        /// Text - The telephone number.
        /// </summary>
        [JsonProperty("telephone")]
        public string Telephone { get; set; }
    }
}
