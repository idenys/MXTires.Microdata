#region License
// Copyright (c) 2015 1010Tires.com
//
// Permission is hereby granted, free of charge, to any person
// obtaining a copy of this software and associated documentation
// files (the "Software"), to deal in the Software without
// restriction, including without limitation the rights to use,
// copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the
// Software is furnished to do so, subject to the following
// conditions:
//
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
// OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
// HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
// WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
// OTHER DEALINGS IN THE SOFTWARE.
#endregion

using System;
using MXTires.Microdata.Intangible.Enumeration;
using Newtonsoft.Json;
namespace MXTires.Microdata.Intangible
{
    /// <summary>
    /// A demand entity represents the public, not necessarily binding, not necessarily exclusive, 
    /// announcement by an organization or person to seek a certain type of goods or services. 
    /// For describing demand using this type, the very same properties used for Offer apply.
    /// </summary>
    public class Demand : Thing
    {
        /// <summary>
        /// PaymentMethod 	The payment method(s) accepted by seller for this offer.
        /// </summary>
        [JsonProperty("acceptedPaymentMethod")]
        public PaymentMethod AcceptedPaymentMethod { get; set; }

        /// <summary>
        /// QuantitativeValue 	The amount of time that is required between accepting the offer and the actual usage of the resource or service.
        /// </summary>
        [JsonProperty("advanceBookingRequirement")]
        public QuantitativeValue AdvanceBookingRequirement { get; set; }

        /// <summary>
        /// Text  or GeoShape  or AdministrativeArea  or Place 	The geographic area where a service or offered item is provided. Supersedes serviceArea.
        /// </summary>
        [JsonProperty("areaServed")]
        public Thing AreaServed { get; set; }

        /// <summary>
        /// ItemAvailability 	The availability of this item—for example In stock, Out of stock, Pre-order, etc.
        /// </summary>
        [JsonProperty("availability")]
        public ItemAvailability Availability { get; set; }

        /// <summary>
        /// DateTime 	The end of the availability of the product or service included in the offer.
        /// </summary>
        [JsonProperty("availabilityEnds")]
        public DateTime? AvailabilityEnds { get; set; }

        /// <summary>
        /// 	DateTime 	The beginning of the availability of the product or service included in the offer.
        /// </summary>
        [JsonProperty("availabilityStarts")]
        public DateTime? AvailabilityStarts { get; set; }

        /// <summary>
        /// Place 	The place(s) from which the offer can be obtained (e.g. store locations).
        /// </summary>
        [JsonProperty("availableAtOrFrom")]
        public Place AvailableAtOrFrom { get; set; }

        /// <summary>
        /// DeliveryMethod 	The delivery method(s) available for this offer.
        /// </summary>
        [JsonProperty("availableDeliveryMethod")]
        public DeliveryMethod AvailableDeliveryMethod { get; set; }

        /// <summary>
        /// BusinessFunction 	The business function (e.g. sell, lease, repair, dispose) of the offer or component of a bundle (TypeAndQuantityNode). The default is http://purl.org/goodrelations/v1#Sell.
        /// </summary>
        [JsonProperty("businessFunction")]
        public BusinessFunction BusinessFunction { get; set; }

        /// <summary>
        /// QuantitativeValue 	The typical delay between the receipt of the order and the goods leaving the warehouse.
        /// </summary>
        [JsonProperty("deliveryLeadTime")]
        public QuantitativeValue DeliveryLeadTime { get; set; }

        /// <summary>
        /// BusinessEntityType - The type(s) of customers for which the given offer is valid.
        /// </summary>
        [JsonProperty("eligibleCustomerType")]
        public BusinessEntityType EligibleCustomerType { get; set; }
       
        ///QuantitativeValue - The interval and unit of measurement of ordering quantities for which the offer or price specification is valid. This allows e.g. specifying that a certain freight charge is valid only for a certain quantity.
        [JsonProperty("eligibleQuantity")]
        public QuantitativeValue EligibleQuantity { get; set; }

        /// <summary>
        /// QuantitativeValue - The duration for which the given offer is valid. 
        /// </summary>
        [JsonProperty("eligibleDuration")]
        public QuantitativeValue EligibleDuration { get; set; }

        /// <summary>
        /// PriceSpecification - The transaction volume, in a monetary unit, for which the offer or price specification is valid, e.g. for indicating a minimal purchasing volume, to express free shipping above a certain order volume, or to limit the acceptance of credit cards to purchases to a certain minimal amount.
        /// </summary>
        [JsonProperty("eligibleTransactionVolume")]
        public PriceSpecification EligibleTransactionVolume { get; set; }

        /// <summary>
        /// Text - The GTIN-12 code of the product, or the product to which the offer refers. The GTIN-12 is the 12-digit GS1 Identification Key composed of a U.P.C. Company Prefix, Item Reference, and Check Digit used to identify trade items. See GS1 GTIN Summary for more details.
        /// </summary>
        [JsonProperty("gtin12")]
        public String Gtin12 { get; set; }
	
        /// <summary>
        /// Text - The GTIN-14 code of the product, or the product to which the offer refers. See GS1 GTIN Summary for more details.
        /// </summary>
        [JsonProperty("gtin14")]
        public String Gtin14 { get; set; }
	
        /// <summary>
        /// Text - The GTIN-8 code of the product, or the product to which the offer refers. This code is also known as EAN/UCC-8 or 8-digit EAN. See GS1 GTIN Summary for more details.
        /// </summary>
        [JsonProperty("gtin8")]
        public String Gtin8 { get; set; }

        /// <summary>
        /// TypeAndQuantityNode - This links to a node or nodes indicating the exact quantity of the products included in the offer.
        /// </summary>
        [JsonProperty("includesObject")]
        public Thing IncludesObject { get; set; }

        /// <summary>
        /// Text  or GeoShape  or Place - The ISO 3166-1 (ISO 3166-1 alpha-2) or ISO 3166-2 code, the place, or the GeoShape for the geo-political region(s) for which the offer or delivery charge specification is not valid, e.g. a region where the transaction is not allowed. See also eligibleRegion.
        /// </summary>
        [JsonProperty("ineligibleRegion")]
        public Thing IneligibleRegion { get; set; }

        /// <summary>
        /// QuantitativeValue - The current approximate inventory level for the item or items.
        /// </summary>
        [JsonProperty("inventoryLevel")]
        public QuantitativeValue InventoryLevel { get; set; }

        /// <summary>
        /// OfferItemCondition - A predefined value from OfferItemCondition or a textual description of the condition of the product or service, or the products or services included in the offer.
        /// </summary>
        [JsonProperty("itemCondition")]
        public OfferItemCondition ItemCondition { get; set; }

        /// <summary>
        /// Product  or Service - The item being offered.
        /// </summary>
        [JsonProperty("itemOffered")]
        public Thing ItemOffered { get; set; }

        /// <summary>
        /// Text 	The Manufacturer Part Number (MPN) of the product, or the product to which the offer refers.
        /// </summary>
        [JsonProperty("mpn")]
        public Thing Mpn { get; set; }

        /// <summary>
        /// PriceSpecification 	One or more detailed price specifications, indicating the unit price and delivery or payment charges.
        /// seller	Person  or Text 	The serial number or any alphanumeric identifier of a particular product. When attached to an offer, it is a shortcut for the serial number of the product included in the offer.
        /// </summary>
        [JsonProperty("priceSpecification")]
        public Thing PriceSpecification { get; set; }

        /// <summary>
        ///Text - The Stock Keeping Unit (SKU), i.e. a merchant-specific identifier for a product or service, or the product to which the offer refers.
        /// </summary>
        [JsonProperty("sku")]
        public String Sku { get; set; }

        /// <summary>
        /// DateTime 	The date when the item becomes valid.
        /// </summary>
        [JsonProperty("validFrom")]
        public DateTime? ValidFrom { get; set; }

        /// <summary>
        /// WarrantyPromise - The warranty promise(s) included in the offer. Supersedes warrantyPromise.
        /// </summary>
        [JsonProperty("warranty")]
        public Thing Warranty { get; set; }
    }
}