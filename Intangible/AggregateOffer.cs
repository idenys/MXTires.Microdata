using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace MXTires.Microdata.Intangible
{
    /// <summary>
    /// When a single product is associated with multiple offers (for example, the same pair of shoes is offered by different merchants), then AggregateOffer can be used.
    /// </summary>
    public class AggregateOffer : Offer
    {
        /// <summary>
        /// Number  or Text - The highest price of all offers available.
        /// </summary>
        [JsonProperty("highPrice")]
        public string HighPrice { get; set; }

        /// <summary>
        /// Number  or Text - The lowest price of all offers available.
        /// </summary>
        [JsonProperty("lowPrice")]
        public string LowPrice { get; set; }

        /// <summary>
        /// Integer - The number of offers for the product.
        /// </summary>
        [JsonProperty("offerCount")]
        public Int32 OfferCount { get; set; }

        /// <summary>
        /// Offer -	An offer to provide this item. For example, an offer to sell a product, rent the DVD of a movie, 
        /// or give away tickets to an event.
        /// </summary>
        [JsonProperty("offers")]
        public IList<Offer> Offers { get; set; }
    }
}
