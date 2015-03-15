using Newtonsoft.Json;

namespace MXTires.Microdata
{
    /// <summary>
    /// The mailing address.
    /// </summary>
    public class PostalAddress : ContactPoint
    {
        /// <summary>
        /// Country - The country. For example, USA. You can also provide the two-letter ISO 3166-1 alpha-2 country code.
        /// </summary>
        [JsonProperty("addressCountry")]
        public string AddressCountry { get; set; }

        /// <summary>
        /// Text - The locality. For example, Mountain View.
        /// </summary>
        [JsonProperty("addressLocality")]
        public string AddressLocality { get; set; }

        /// <summary>
        /// Text - The region. For example, CA.
        /// </summary>
        [JsonProperty("addressRegion")]
        public string AddressRegion { get; set; }

        /// <summary>
        /// Text - The post office box number for PO box addresses.
        /// </summary>
        [JsonProperty("postOfficeBoxNumber")]
        public string PostOfficeBoxNumber { get; set; }

        /// <summary>
        /// Text - The postal code. For example, 94043.
        /// </summary>
        [JsonProperty("postalCode")]
        public string PostalCode { get; set; }

        /// <summary>
        /// Text - The street address. For example, 1600 Amphitheatre Pkwy.
        /// </summary>
        [JsonProperty("streetAddress")]
        public string StreetAddress { get; set; }
    }
}
