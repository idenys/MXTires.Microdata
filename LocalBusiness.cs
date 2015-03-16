using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace MXTires.Microdata
{
    public class LocalBusiness : Organization
    {
        [JsonProperty("branchOf")]
        public Organization BranchOf { get; set; }

        /// <summary>
        /// Text 	The currency accepted (in ISO 4217 currency format).
        /// </summary>
        [JsonProperty("currenciesAccepted")]
        public string CurrenciesAccepted { get; set; }

        /// <summary>
        /// Duration 	The opening hours for a business. Opening hours can be specified as a weekly time range, starting with days, then times per day. Multiple days can be listed with commas ',' separating each day. Day or time ranges are specified using a hyphen '-'.
        ///- Days are specified using the following two-letter combinations: Mo, Tu, We, Th, Fr, Sa, Su.
        ///- Times are specified using 24:00 time. For example, 3pm is specified as 15:00. 
        ///- Here is an example: <time itemprop="openingHours" datetime="Tu,Th 16:00-20:00">Tuesdays and Thursdays 4-8pm</time>. 
        ///- If a business is open 7 days a week, then it can be specified as <time itemprop="openingHours" datetime="Mo-Su">Monday through Sunday, all day</time>.
        /// </summary>
        [JsonProperty("openingHours")]
        public List<Duration> OpeningHours { get; set; }

        /// <summary>
        /// Text 	Cash, credit card, etc.
        /// </summary>
        [JsonProperty("paymentAccepted")]
        public string PaymentAccepted { get; set; }

        [JsonProperty("priceRange")]
        public string PriceRange { get; set; }
    }
}