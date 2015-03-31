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

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MXTires.Microdata.Intangible;
using MXTires.Microdata.Intangible.Enumeration;
using Newtonsoft.Json.Converters;

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
        public string Colour { get; set; }

        /// <summary>
        ///  QuantitativeValue.	The depth of the product.
        /// </summary>
        [JsonProperty("depth")]
        public QuantitativeValue Depth { get; set; }
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
        /// Distance  or QuantitativeValue 	The height of the item or person.
        /// </summary>
        [JsonProperty("height")]
        public QuantitativeValue Height { get; set; }
        /// <summary>
        /// A pointer to another product (or multiple products) for which this product is an accessory or spare part.
        /// </summary>
        [JsonProperty("isAccessoryOrSparePartFor")]
        public Product IsAccessoryOrSparePartFor { get; set; }
        /// <summary>
        /// A pointer to another product (or multiple products) for which this product is a consumable.
        /// </summary>
        [JsonProperty("isConsumableFor")]
        public Product IsConsumableFor { get; set; }
        /// <summary>
        /// A pointer to another, somehow related product (or multiple products).
        /// </summary>
        [JsonProperty("isRelatedTo")]
        public Product IsRelatedTo { get; set; }
        /// <summary>
        /// A pointer to another, functionally similar product (or multiple products).
        /// </summary>
        [JsonProperty("isSimilarTo")]
        public Product IsSimilarTo { get; set; }

        /// <summary>
        /// OfferItemCondition 	A predefined value from OfferItemCondition or a textual description of the condition of the product or service, or the products or services included in the offer.
        /// </summary>
        [JsonProperty("itemCondition")]
        [JsonConverter(typeof(StringEnumConverter))]
        public OfferItemCondition? ItemCondition { get; set; }
        /// <summary>
        /// ImageObject  or URL 	An associated logo.
        /// </summary>
        [JsonProperty("logo")]
        public string Logo { get; set; }
        /// <summary>
        /// Organization - The manufacturer of the product.
        /// </summary>
        [JsonProperty("manufacturer")]
        public Organization Manufacturer { get; set; }
        /// <summary>
        ///   ProductModel  or Text 	The model of the product. Use with the URL of a ProductModel or a textual representation of the model identifier. The URL of the ProductModel can be from an external source. It is recommended to additionally provide strong product identifiers via the gtin8/gtin13/gtin14 and mpn properties.
        /// </summary>
        [JsonProperty("model")]
        public ProductModel Model { get; set; }
        /// <summary>
        /// The Manufacturer Part Number (MPN) of the product, or the product to which the offer refers.
        /// </summary>
        [JsonProperty("mpn")]
        public string Mpn { get; set; }
        /// <summary>
        ///   	An offer to provide this item—for example, an offer to sell a product, rent the DVD of a movie, or give away tickets to an event.
        /// </summary>
        [JsonProperty("offers")]
        public IList<Offer> Offers { get; set; }
        /// <summary>
        /// The product identifier, such as ISBN. For example: <meta itemprop='productID' content='isbn:123-456-789'/>.
        /// </summary>
        [JsonProperty("productID")]
        public string ProductId { get; set; }
        /// <summary>
        /// Date.The release date of a product or product model. This can be used to distinguish the exact variant of a product.
        /// </summary>
        [JsonProperty("releaseDate")]
        public string ReleaseDate { get; set; }
        /// <summary>
        /// Review 	A review of the item. Supersedes reviews.
        /// </summary>
        [JsonProperty("review")]
        public Review Review { get; set; }
        /// <summary>
        /// The Stock Keeping Unit (SKU), i.e. a merchant-specific identifier for a product or service, or the product to which the offer refers.
        /// </summary>
        [JsonProperty("sku")]
        public string Sku { get; set; }
        /// <summary>
        /// QuantitativeValue 	The weight of the product or person.
        /// </summary>
        [JsonProperty("weight")]
        public QuantitativeValue Weight { get; set; }
        /// <summary>
        /// Distance  or QuantitativeValue 	The width of the item.
        /// </summary>
        [JsonProperty("width")]
        public QuantitativeValue Width { get; set; }
    }
}