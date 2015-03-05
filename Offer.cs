using System;
using Newtonsoft.Json;

namespace MXTires.Microdata
{
    /// <summary>
    /// A payment method is a standardized procedure for transferring the monetary amount for a purchase. 
    /// Payment methods are characterized by the legal and technical structures used, and by the organization or group carrying out the transaction. 
    /// Commonly used values: http://purl.org/goodrelations/v1#ByBankTransferInAdvance http://purl.org/goodrelations/v1#ByInvoice 
    /// http://purl.org/goodrelations/v1#Cash http://purl.org/goodrelations/v1#CheckInAdvance http://purl.org/goodrelations/v1#COD 
    /// http://purl.org/goodrelations/v1#DirectDebit http://purl.org/goodrelations/v1#GoogleCheckout http://purl.org/goodrelations/v1#PayPal 
    /// http://purl.org/goodrelations/v1#PaySwarm
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
    }
}
