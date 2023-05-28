using System;
using System.Collections.Generic;
using MXTires.Microdata.Intangible.Enumeration;
using MXTires.Microdata.Intangible.StructuredValues;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using MXTires.Microdata.Validators;

namespace MXTires.Microdata.Intangible
{
    /// <summary>
    /// An offer to transfer some rights to an item or to provide a service—for example,
    /// an offer to sell tickets to an event, to rent the DVD of a movie, to stream a TV show over the internet,
    /// to repair a motorcycle, or to loan a book. For GTIN-related fields, see Check Digit calculator and validation guide from GS1.
    /// </summary>
    public class Offer : Thing
    {
        /// <summary>
        /// Gets or sets the price.
        /// </summary>
        /// <value>The price.</value>
        [JsonProperty("price")]
        public string Price { get; set; }

        /// <summary>
        /// The currency (in 3-letter ISO 4217 format) of the price or a price component, when attached to PriceSpecification and its subtypes.
        /// </summary>
        /// <value>The price currency.</value>
        [JsonProperty("priceCurrency")]
        public string PriceCurrency { get; set; }

        private object priceSpecification;
        /// <summary>
        /// One or more detailed price specifications, indicating the unit price and delivery or payment charges.
        /// </summary>
        /// <value>The price specification.</value>
        [JsonProperty("priceSpecification")]
        public object PriceSpecification
        {
            get { return priceSpecification; }
            set
            {
                var validator = new TypeValidator(typeof(PriceSpecification), typeof(IList<PriceSpecification>));
                validator.Validate(value);
                priceSpecification = value;
            }
        }

        /// <summary>
        /// Date - The date after which the price is no longer available.
        /// </summary>
        [JsonProperty("priceValidUntil")]
        public DateTime? PriceValidUntil { get; set; }

        /// <summary>
        /// The payment method(s) accepted by seller for this offer.
        /// </summary>
        /// <value>The accepted payment method.</value>
        [JsonProperty ("acceptedPaymentMethod")]
        [JsonConverter(typeof(StringEnumConverter))]
        public PaymentMethod? AcceptedPaymentMethod { get; set; }

        /// <summary>
        /// The payment method(s) accepted by seller for this offer.
        /// </summary>
        /// <value>The category.</value>
        [JsonProperty("category")]
        public string Category { get; set; }

        /// <summary>
        /// The date when the item becomes valid.
        /// </summary>
        /// <value>The valid from.</value>
        [JsonProperty("validFrom")]
        public string ValidFrom { get; set; }

        /// <summary>
        /// The end of the validity of offer, price specification, or opening hours data.
        /// </summary>
        /// <value>The valid through.</value>
        [JsonProperty("validThrough")]
        public string ValidThrough { get; set; }

        /// <summary>
        /// An additional offer that can only be obtained in combination with the first base offer (e.g. supplements and extensions that are available for a surcharge).
        /// </summary>
        /// <value>The add on.</value>
        [JsonProperty("addOn")]
        public Offer AddOn { get; set; }

        /// <summary>
        /// The Stock Keeping Unit (SKU), i.e. a merchant-specific identifier for a product or service, or the product to which the offer refers.
        /// </summary>
        /// <value>The sku.</value>
        [JsonProperty("sku")]
        public string Sku { get; set; }

        /// <summary>
        /// The serial number or any alphanumeric identifier of a particular product.
        /// When attached to an offer, it is a shortcut for the serial number of the product included in the offer.
        /// </summary>
        /// <value>The serial number.</value>
        [JsonProperty("serialNumber")]
        public string SerialNumber { get; set; }

        /// <summary>
        /// OfferShippingDetails Indicates information about the shipping policies and options associated with an <see cref="Offer"/>.
        /// </summary>
        [JsonProperty("shippingDetails")]
        public OfferShippingDetails ShippingDetails { get; set; }

        Thing seller;
        /// <summary>
        /// <see cref="Organization" />   or <see cref="Person" /> - An entity which offers (sells / leases / lends / loans) the services / goods. A seller may also be a provider. Supersedes merchant, vendor.
        /// </summary>
        /// <value>The seller.</value>
        [JsonProperty("seller")]
        public Thing Seller
        {
            get { return seller; }
            set
            {
                var validator = new TypeValidator(typeof(Person), typeof(Organization));
                validator.Validate(value);
                seller = value;
            }
        }

        /// <summary>
        /// <see cref="Review" /> - A review of the item. Supersedes reviews.
        /// </summary>
        /// <value>The review.</value>
        [JsonProperty("review")]
        public Review Review { get; set; }

        /// <summary>
        /// Collection of <see cref="Review" />
        /// </summary>
        /// <value>The reviews.</value>
        [JsonProperty("reviews")]
        public IList<Review> Reviews { get; set; }

        /// <summary>
        /// ItemAvailability - The availability of this item—for example In stock, Out of stock, Pre-order, etc.
        /// </summary>
        /// <value>The availability.</value>
        [JsonProperty("availability")]
        [JsonConverter(typeof(StringEnumConverter))]
        public ItemAvailability? Availability { get; set; }

        /// <summary>
        /// QuantitativeValue - The amount of time that is required between accepting the offer and the actual usage of the resource or service.
        /// </summary>
        /// <value>The advance booking requirement.</value>
        [JsonProperty("advanceBookingRequirement")]
        public QuantitativeValue AdvanceBookingRequirement { get; set; }

        /// <summary>
        /// DateTime - The end of the availability of the product or service included in the offer.
        /// </summary>
        /// <value>The availability ends.</value>
        [JsonProperty("availabilityEnds")]
        public DateTime? AvailabilityEnds { get; set; }

        /// <summary>
        /// DateTime - The beginning of the availability of the product or service included in the offer.
        /// </summary>
        /// <value>The availability starts.</value>
        [JsonProperty("availabilityStarts")]
        public DateTime? AvailabilityStarts { get; set; }

        /// <summary>
        /// Place - The place(s) from which the offer can be obtained (e.g. store locations).
        /// </summary>
        /// <value>The available at or from.</value>
        [JsonProperty("availableAtOrFrom")]
        public Place AvailableAtOrFrom { get; set; }

        /// <summary>
        /// DeliveryMethod - The delivery method(s) available for this offer.
        /// </summary>
        /// <value>The available delivery method.</value>
        [JsonProperty("availableDeliveryMethod")]
        [JsonConverter(typeof(StringEnumConverter))]
        public DeliveryMethod? AvailableDeliveryMethod { get; set; }

        /// <summary>
        /// The business function
        /// </summary>
        private BusinessFunction businessFunction = BusinessFunction.Sell;
        /// <summary>
        /// BusinessFunction - The business function (e.g. sell, lease, repair, dispose) of the offer or component of a bundle (TypeAndQuantityNode). The default is http://purl.org/goodrelations/v1#Sell.
        /// </summary>
        /// <value>The business function.</value>
        [JsonProperty("businessFunction")]
        [JsonConverter(typeof(StringEnumConverter))]
        public BusinessFunction BusinessFunction{
            get { return businessFunction; }
            set { businessFunction = value; }
        }

        /// <summary>
        /// QuantitativeValue - The typical delay between the receipt of the order and the goods leaving the warehouse.
        /// </summary>
        /// <value>The delivery lead time.</value>
        [JsonProperty("deliveryLeadTime")]
        public QuantitativeValue DeliveryLeadTime { get; set; }

        /// <summary>
        /// BusinessEntityType -The type(s) of customers for which the given offer is valid.
        /// </summary>
        /// <value>The type of the eligible customer.</value>
        [JsonProperty("eligibleCustomerType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public BusinessEntityType? EligibleCustomerType { get; set; }

        /// <summary>
        /// QuantitativeValue - The duration for which the given offer is valid.
        /// </summary>
        /// <value>The duration of the eligible.</value>
        [JsonProperty("eligibleDuration")]
        public QuantitativeValue EligibleDuration { get; set; }

        /// <summary>
        /// QuantitativeValue - The interval and unit of measurement of ordering quantities for which the offer or price specification is valid. This allows e.g. specifying that a certain freight charge is valid only for a certain quantity.
        /// </summary>
        /// <value>The eligible quantity.</value>
        [JsonProperty("eligibleQuantity")]
        public QuantitativeValue EligibleQuantity { get; set; }

        /// <summary>
        /// GeoShape  or Text - The ISO 3166-1 (ISO 3166-1 alpha-2) or ISO 3166-2 code,
        /// or the GeoShape for the geo-political region(s) for which the offer or delivery charge specification is valid.
        /// </summary>
        /// <value>The eligible region.</value>
        [JsonProperty("eligibleRegion")]
        public GeoShape EligibleRegion	{ get; set; }

        /// <summary>
        /// PriceSpecification -The transaction volume, in a monetary unit, for which the offer or price specification is valid, e.g. for indicating a minimal purchasing volume,
        /// to express free shipping above a certain order volume, or to limit the acceptance of credit cards to purchases to a certain minimal amount.
        /// </summary>
        /// <value>The eligible transaction volume.</value>
        [JsonProperty("eligibleTransactionVolume")]
        public PriceSpecification EligibleTransactionVolume { get; set; }

        /// <summary>
        /// The GTIN-12 code of the product, or the product to which the offer refers. 
        /// The GTIN-12 is the 12-digit GS1 Identification Key composed of a U.P.C. 
        /// Company Prefix, Item Reference, and Check Digit used to identify trade items. 
        /// See GS1 GTIN Summary for more details.
        /// </summary>
        /// <value>The gtin13.</value>
        [JsonProperty("gtin12")]
        public string Gtin12 { get; set; }

        /// <summary>
        /// The GTIN-13 code of the product, or the product to which the offer refers. This is equivalent to 13-digit ISBN codes and EAN UCC-13. Former 12-digit UPC codes can be converted into a GTIN-13 code by simply adding a preceeding zero. See GS1 GTIN Summary for more details.
        /// </summary>
        /// <value>The gtin13.</value>
        [JsonProperty("gtin13")]
        public string Gtin13 { get; set; }
        /// <summary>
        /// The GTIN-14 code of the product, or the product to which the offer refers. See GS1 GTIN Summary for more details.
        /// </summary>
        /// <value>The gtin14.</value>
        [JsonProperty("gtin14")]
        public string Gtin14 { get; set; }
        /// <summary>
        /// The GTIN-8 code of the product, or the product to which the offer refers. This code is also known as EAN/UCC-8 or 8-digit EAN. See GS1 GTIN Summary for more details.
        /// </summary>
        /// <value>The gtin8.</value>
        [JsonProperty("gtin8")]
        public string Gtin8 { get; set; }

        /// <summary>
        /// MerchantReturnPolicy - Specifies a MerchantReturnPolicy that may be applicable. Supersedes <see cref="HasProductReturnPolicy"/>.
        /// </summary>
        [JsonProperty("hasMerchantReturnPolicy")]
        public MerchantReturnPolicy HasMerchantReturnPolicy { get; set; }

        /// <summary>
        /// TypeAndQuantityNode - This links to a node or nodes indicating the exact quantity of the products included in the offer.
        /// </summary>
        /// <value>The includes object.</value>
        [JsonProperty("includesObject")]
        public TypeAndQuantityNode IncludesObject { get; set; }

        /// <summary>
        /// Place 	The place(s) from which the offer cannot be obtained (e.g. a region where the transaction is not allowed).
        /// </summary>
        /// <value>The ineligible region.</value>
        [JsonProperty("ineligibleRegion")]
        public Place IneligibleRegion { get; set; }

        /// <summary>
        /// The GTIN-8 code of the product, or the product to which the offer refers. This code is also known as EAN/UCC-8 or 8-digit EAN. See GS1 GTIN Summary for more details.
        /// </summary>
        /// <value>The inventory level.</value>
        [JsonProperty("inventoryLevel")]
        public QuantitativeValue InventoryLevel { get; set; }

        /// <summary>
        /// <see cref="OfferItemCondition" /> - A predefined value from OfferItemCondition or a textual description of the condition of the product or service,
        /// or the products or services included in the offer.
        /// </summary>
        /// <value>The item condition.</value>
        [JsonProperty("itemCondition")]
        [JsonConverter(typeof(StringEnumConverter))]
        public OfferItemCondition ItemCondition { get; set; }

        /// <summary>
        /// <see cref="Product" /> - The item being offered.
        /// </summary>
        /// <value>The item offered.</value>
        [JsonProperty("itemOffered")]
        public Product ItemOffered { get; set; }

        /// <summary>
        /// Text - The Manufacturer Part Number (MPN) of the product, or the product to which the offer refers.
        /// </summary>
        /// <value>The MPN.</value>
        [JsonProperty("mpn")]
        public string Mpn { get; set; }

        /// <summary>
        /// WarrantyPromise - The warranty promise(s) included in the offer..
        /// </summary>
        /// <value>The warranty.</value>
        [JsonProperty("warranty")]
        public WarrantyPromise Warranty { get; set; }	


    }
}
