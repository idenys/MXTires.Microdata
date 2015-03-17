using System;
using Newtonsoft.Json;

namespace MXTires.Microdata
{
    /// <summary>
    /// An offer to transfer some rights to an item or to provide a service—for example, 
    /// an offer to sell tickets to an event, to rent the DVD of a movie, to stream a TV show over the internet, 
    /// to repair a motorcycle, or to loan a book. For GTIN-related fields, see Check Digit calculator and validation guide from GS1.
    /// </summary>
    public class Offer : Thing
    {
        /// <summary>

        /// The offer price of a product, or of a price component when attached to PriceSpecification and its subtypes. 
        /// <list type="bullet">        
        ///     <listheader>
        ///         <term>Usage guidelines:</term>
        ///     </listheader>
        ///     <item>   
        ///     <description>
        ///         Use the priceCurrency property (with ISO 4217 codes e.g. "USD") instead of including ambiguous symbols such as '$' in the value.
        ///         </description>
        ///     </item>
        ///     <item>
        ///         <description>
        ///         Use '.' (Unicode 'FULL STOP' (U+002E)) rather than ',' to indicate a decimal point. Avoid using these symbols as a readability separator.
        ///         Note that both RDFa and Microdata syntax allow the use of a "content=" attribute for publishing simple machine-readable values alongside more human-friendly formatting.
        ///         </description>
        ///     </item>
        ///         <description>
        ///         Use values from 0123456789 (Unicode 'DIGIT ZERO' (U+0030) to 'DIGIT NINE' (U+0039)) rather than superficially similiar Unicode symbols.
        ///         </description>
        ///      </item>
        /// </list>
        /// </summary>
        [JsonProperty("price")]
        public string Price { get; set; }

        /// <summary>
        /// The currency (in 3-letter ISO 4217 format) of the price or a price component, when attached to PriceSpecification and its subtypes.
        /// </summary>
        [JsonProperty("priceCurrency")]
        public string PriceCurrency { get; set; }

        /// <summary>
        /// One or more detailed price specifications, indicating the unit price and delivery or payment charges.
        /// </summary>
         [JsonProperty("priceSpecification")]
        public PriceSpecification PriceSpecification { get; set; }
        
        /// <summary>
         /// The payment method(s) accepted by seller for this offer.
        /// </summary>
        [JsonProperty ("acceptedPaymentMethod")]
         public PaymentMethod AcceptedPaymentMethod { get; set; }

        /// <summary>
        /// The payment method(s) accepted by seller for this offer.
        /// </summary>
        [JsonProperty("category")]
        public string Category { get; set; }

        /// <summary>
        /// The date when the item becomes valid.
        /// </summary>
        [JsonProperty("validFrom")]
        public string ValidFrom { get; set; }

        /// <summary>
        /// The end of the validity of offer, price specification, or opening hours data.
        /// </summary>
        [JsonProperty("validThrough")]
        public string ValidThrough { get; set; }

        /// <summary>
        /// An additional offer that can only be obtained in combination with the first base offer (e.g. supplements and extensions that are available for a surcharge).
        /// </summary>
        [JsonProperty("addOn")]
        public Offer AddOn { get; set; }

        /// <summary>
        /// The Stock Keeping Unit (SKU), i.e. a merchant-specific identifier for a product or service, or the product to which the offer refers.
        /// </summary>
        [JsonProperty("sku")]
        public string Sku { get; set; }

        /// <summary>
        /// The serial number or any alphanumeric identifier of a particular product. 
        /// When attached to an offer, it is a shortcut for the serial number of the product included in the offer.
        /// </summary>
        [JsonProperty("serialNumber")]
        public string SerialNumber { get; set; }

        /// <summary>
        /// Organization  or Person -An entity which offers (sells / leases / lends / loans) the services / goods. A seller may also be a provider. Supersedes merchant, vendor.
        /// </summary>
        [JsonProperty("seller")]
        public Thing Seller { get; set; }

        /// <summary>
        /// Review - A review of the item. Supersedes reviews.
        /// </summary>
        [JsonProperty("review")]
        public Review Review { get; set; }

        /// <summary>
        /// ItemAvailability - The availability of this item—for example In stock, Out of stock, Pre-order, etc.
        /// </summary>
        [JsonProperty("availability")]
        public string Availability { get; set; }
    }
}
