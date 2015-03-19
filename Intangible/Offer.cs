using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace MXTires.Microdata
{
    /// <summary>
    /// An offer to transfer some rights to an item or to provide a service—for example, 
    /// an offer to sell tickets to an event, to rent the DVD of a movie, to stream a TV show over the internet, 
    /// to repair a motorcycle, or to loan a book. For GTIN-related fields, see Check Digit calculator and validation guide from GS1.
    /// </summary>
    public class Offer : Intangible
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
        [JsonConverter(typeof(StringEnumConverter))]
        public ItemAvailability Availability { get; set; }

        /// <summary>
        /// QuantitativeValue - The amount of time that is required between accepting the offer and the actual usage of the resource or service.
        /// </summary>
        [JsonProperty("advanceBookingRequirement")]
        public QuantitativeValue AdvanceBookingRequirement { get; set; }

        /// <summary>
        /// DateTime - The end of the availability of the product or service included in the offer.
        /// </summary>
        [JsonProperty("availabilityEnds")]
        public DateTime AvailabilityEnds { get; set; }

        /// <summary>
        /// DateTime - The beginning of the availability of the product or service included in the offer.
        /// </summary>
        [JsonProperty("availabilityStarts")]
        public DateTime AvailabilityStarts { get; set; }

        /// <summary>
        /// Place - The place(s) from which the offer can be obtained (e.g. store locations).
        /// </summary>
        [JsonProperty("availableAtOrFrom")]
        public Place AvailableAtOrFrom { get; set; }

        /// <summary>
        /// DeliveryMethod - The delivery method(s) available for this offer.
        /// </summary>
        [JsonProperty("availableDeliveryMethod")]
        public DeliveryMethod AvailableDeliveryMethod { get; set; }

        private BusinessFunction businessFunction = BusinessFunction.Sell;
        /// <summary>
        /// BusinessFunction - The business function (e.g. sell, lease, repair, dispose) of the offer or component of a bundle (TypeAndQuantityNode). The default is http://purl.org/goodrelations/v1#Sell.
        /// </summary>
        [JsonProperty("businessFunction")]
        public BusinessFunction BusinessFunction{
            get { return businessFunction; }
            set { businessFunction = value; }
        }
        
        /// <summary>
        /// QuantitativeValue - The typical delay between the receipt of the order and the goods leaving the warehouse.
        /// </summary>
        [JsonProperty("deliveryLeadTime")]
        public QuantitativeValue DeliveryLeadTime { get; set; }

        /// <summary>
        /// BusinessEntityType -The type(s) of customers for which the given offer is valid.
        /// </summary>
        [JsonProperty("eligibleCustomerType")]
        public BusinessEntityType EligibleCustomerType { get; set; }

        /// <summary>
        /// QuantitativeValue - The duration for which the given offer is valid.
        /// </summary>
        [JsonProperty("eligibleDuration")]
        public QuantitativeValue EligibleDuration { get; set; }

        /// <summary>
        /// QuantitativeValue - The interval and unit of measurement of ordering quantities for which the offer or price specification is valid. This allows e.g. specifying that a certain freight charge is valid only for a certain quantity.
        /// </summary>
        [JsonProperty("eligibleQuantity")]
        public QuantitativeValue EligibleQuantity { get; set; }

        /// <summary>
        /// GeoShape  or Text - The ISO 3166-1 (ISO 3166-1 alpha-2) or ISO 3166-2 code, 
        /// or the GeoShape for the geo-political region(s) for which the offer or delivery charge specification is valid.
        /// </summary>
        [JsonProperty("eligibleRegion")]
        public GeoShape EligibleRegion	{ get; set; }

        /// <summary>
        /// PriceSpecification -The transaction volume, in a monetary unit, for which the offer or price specification is valid, e.g. for indicating a minimal purchasing volume, 
        /// to express free shipping above a certain order volume, or to limit the acceptance of credit cards to purchases to a certain minimal amount.
        /// </summary>
        [JsonProperty("eligibleTransactionVolume")]
        public PriceSpecification EligibleTransactionVolume { get; set; }

        /// <summary>
        /// The GTIN-13 code of the product, or the product to which the offer refers. This is equivalent to 13-digit ISBN codes and EAN UCC-13. Former 12-digit UPC codes can be converted into a GTIN-13 code by simply adding a preceeding zero. See GS1 GTIN Summary for more details.
        /// </summary>
        [JsonProperty("gtin13")]
        public string Gtin13 { get; set; }
        /// <summary>
        /// The GTIN-14 code of the product, or the product to which the offer refers. See GS1 GTIN Summary for more details.
        /// </summary>
        [JsonProperty("gtin14")]
        public string Gtin14 { get; set; }
        /// <summary>
        /// The GTIN-8 code of the product, or the product to which the offer refers. This code is also known as EAN/UCC-8 or 8-digit EAN. See GS1 GTIN Summary for more details.
        /// </summary>
        [JsonProperty("gtin8")]
        public string Gtin8 { get; set; }

        /// <summary>
        /// TypeAndQuantityNode - This links to a node or nodes indicating the exact quantity of the products included in the offer.
        /// </summary>
        [JsonProperty("includesObject")]
        public TypeAndQuantityNode IncludesObject { get; set; }	

        /// <summary>
        /// Place 	The place(s) from which the offer cannot be obtained (e.g. a region where the transaction is not allowed).
        /// </summary>
        [JsonProperty("ineligibleRegion")]
        public Place IneligibleRegion { get; set; }	

        /// <summary>
        /// The GTIN-8 code of the product, or the product to which the offer refers. This code is also known as EAN/UCC-8 or 8-digit EAN. See GS1 GTIN Summary for more details.
        /// </summary>
        [JsonProperty("inventoryLevel")]
        public QuantitativeValue InventoryLevel { get; set; }	

        /// <summary>
        /// OfferItemCondition 	A predefined value from OfferItemCondition or a textual description of the condition of the product or service, 
        /// or the products or services included in the offer.
        /// </summary>
        [JsonProperty("itemCondition")]
        public OfferItemCondition ItemCondition { get; set; }	

        /// <summary>
        /// Product - The item being offered.
        /// </summary>
        [JsonProperty("itemOffered")]
        public Product ItemOffered { get; set; }	

        /// <summary>
        /// WarrantyPromise - The warranty promise(s) included in the offer..
        /// </summary>
        [JsonProperty("warranty")]
        public WarrantyPromise Warranty { get; set; }	
    }
}
