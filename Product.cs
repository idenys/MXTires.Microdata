using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MXTires.Microdata
{
    public class Product : Thing
    {
        /// <summary>
        /// The overall rating, based on a collection of reviews or ratings, of the item.
        /// </summary>
        [JsonProperty("aggregateRating")]
        public AggregateRating AggregateRating { get; set; }

        /// <summary>
        ///  The intended audience of the item, i.e. the group for whom the item was created.
        /// </summary>
        [JsonProperty("audience")]
        public Audience Audience { get; set; }
        /// <summary>
        /// Organization  or 
        /// Brand 	The brand(s) associated with a product or service, or the brand(s) maintained by an organization or business person.
        /// </summary>
        [JsonProperty("brand")]
        public Brand Brand { get; set; }

        /// <summary>
        /// The colour of the product.
        /// </summary>
        [JsonProperty("color")]
        public string Color { get; set; }

        /// <summary>
        ///  QuantitativeValue.	The depth of the product.
        /// </summary>
        [JsonProperty("depth")]
        public QuantitativeValue Depth { get; set; }
        /// <summary>
        /// The GTIN-13 code of the product, or the product to which the offer refers. This is equivalent to 13-digit ISBN codes and EAN UCC-13. Former 12-digit UPC codes can be converted into a GTIN-13 code by simply adding a preceeding zero. See GS1 GTIN Summary for more details.
        /// </summary>
        public string gtin13 { get; set; }
        /// <summary>
        /// The GTIN-14 code of the product, or the product to which the offer refers. See GS1 GTIN Summary for more details.
        /// </summary>
        public string gtin14 { get; set; }
        /// <summary>
        /// The GTIN-8 code of the product, or the product to which the offer refers. This code is also known as EAN/UCC-8 or 8-digit EAN. See GS1 GTIN Summary for more details.
        /// </summary>
        public string gtin8 { get; set; }
        /// <summary>
        /// Distance  or QuantitativeValue 	The height of the item or person.
        /// </summary>
        public string height { get; set; }
        /// <summary>
        /// A pointer to another product (or multiple products) for which this product is an accessory or spare part.
        /// </summary>
        public Product isAccessoryOrSparePartFor { get; set; }
        /// <summary>
        /// A pointer to another product (or multiple products) for which this product is a consumable.
        /// </summary>
        public Product isConsumableFor { get; set; }
        /// <summary>
        /// A pointer to another, somehow related product (or multiple products).
        /// </summary>
        public Product isRelatedTo { get; set; }
        /// <summary>
        /// A pointer to another, functionally similar product (or multiple products).
        /// </summary>
        public Product isSimilarTo { get; set; }

        /// <summary>
        /// OfferItemCondition 	A predefined value from OfferItemCondition or a textual description of the condition of the product or service, or the products or services included in the offer.
        /// </summary>
        public string itemCondition { get; set; }
        /// <summary>
        /// ImageObject  or URL 	An associated logo.
        /// </summary>
        public string logo { get; set; }
        /// <summary>
        /// Organization 	The manufacturer of the product.
        /// </summary>
        public string manufacturer { get; set; }
        /// <summary>
        ///   ProductModel  or Text 	The model of the product. Use with the URL of a ProductModel or a textual representation of the model identifier. The URL of the ProductModel can be from an external source. It is recommended to additionally provide strong product identifiers via the gtin8/gtin13/gtin14 and mpn properties.
        /// </summary>
        public ProductModel model { get; set; }
        /// <summary>
        /// The Manufacturer Part Number (MPN) of the product, or the product to which the offer refers.
        /// </summary>
        public string mpn { get; set; }
        /// <summary>
        ///   	An offer to provide this item—for example, an offer to sell a product, rent the DVD of a movie, or give away tickets to an event.
        /// </summary>
        [JsonProperty("offers")]
        public IList<Offer> Offers { get; set; }
        /// <summary>
        /// The product identifier, such as ISBN. For example: <meta itemprop='productID' content='isbn:123-456-789'/>.
        /// </summary>
        public string productID { get; set; }
        /// <summary>
        /// Date.The release date of a product or product model. This can be used to distinguish the exact variant of a product.
        /// </summary>
        public string releaseDate { get; set; }
        /// <summary>
        /// Review 	A review of the item. Supersedes reviews.
        /// </summary>
        public string review { get; set; }
        /// <summary>
        /// The Stock Keeping Unit (SKU), i.e. a merchant-specific identifier for a product or service, or the product to which the offer refers.
        /// </summary>
        public string Sku { get; set; }
        /// <summary>
        /// QuantitativeValue 	The weight of the product or person.
        /// </summary>
        public string weight { get; set; }
        /// <summary>
        /// Distance  or QuantitativeValue 	The width of the item.
        /// </summary>
        public string width { get; set; }
    }
}