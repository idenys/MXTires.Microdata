﻿#region License
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
using MXTires.Microdata.Intangible.Enumeration.Medical;
using MXTires.Microdata.Intangible.StructuredValues;
using MXTires.Microdata.Validators;

namespace MXTires.Microdata
{
    /// <summary>
    /// Class Product.
    /// </summary>
    public class Product : Thing
    {
        /// <summary>
        /// The overall rating, based on a collection of reviews or ratings, of the item.
        /// </summary>
        /// <value>The aggregate rating.</value>
        [JsonProperty("aggregateRating")]
        public AggregateRating AggregateRating { get; set; }

        /// <summary>
        /// The intended audience of the item, i.e. the group for whom the item was created.
        /// </summary>
        /// <value>The audience.</value>
        [JsonProperty("audience")]
        public Audience Audience { get; set; }

        /// <summary>
        /// Text - An award won by or for this item. Supersedes <see cref="Awards"/>.
        /// </summary>
        /// <value>The award.</value>
        [JsonProperty("award")]
        public String Award { get; set; }

        /// <summary>
        /// Awards won by or for this item. Superseded by <see cref="Award"/>
        /// </summary>
        [JsonProperty("awards")]
        public IList<String> Awards { get; set; }

        Thing brand;
        /// <summary>
        /// Organization  or Brand - The brand(s) associated with a product or service, or the brand(s) maintained by an organization or business person.
        /// </summary>
        /// <value>The brand.</value>
        [JsonProperty("brand")]
        public Thing Brand
        {
            get { return brand; }
            set
            {
                var validator = new TypeValidator(typeof(Organization), typeof(Brand));
                validator.Validate(value);
                brand = value;
            }
        }

        object category;
        /// <summary>
        /// Text  or <see cref="PhysicalActivityCategory" />  or <see cref="Thing" /> - A category for the item. Greater signs or slashes can be used to informally indicate a category hierarchy.
        /// </summary>
        /// <value>The category.</value>
        [JsonProperty("category")]
        public object Category
        {
            get { return category; }
            set
            {
                var validator = new TypeValidator(new List<Type>() { typeof(PhysicalActivityCategory), typeof(Thing), typeof(String) });
                validator.Validate(value);
                category = value;
            }
        }

        /// <summary>
        /// The colour of the product.
        /// </summary>
        /// <value>The colour.</value>
        [JsonProperty("color")]
        public string Colour { get; set; }

        /// <summary>
        /// QuantitativeValue.	The depth of the product.
        /// </summary>
        /// <value>The depth.</value>
        [JsonProperty("depth")]
        public QuantitativeValue Depth { get; set; }

        /// <summary>
        /// Text - The GTIN-12 code of the product, or the product to which the offer refers.The GTIN-12 is the 12-digit GS1 Identification Key composed of a U.P.C.Company Prefix, Item Reference, and Check Digit used to identify trade items. See GS1 GTIN Summary for more details.
        /// </summary>
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
        /// Distance  or QuantitativeValue - The height of the item or person.
        /// </summary>
        /// <value>The height.</value>
        [JsonProperty("height")]
        public Thing Height { get; set; }

        /// <summary>
        /// A pointer to another product (or multiple products) for which this product is an accessory or spare part.
        /// </summary>
        /// <value>The is accessory or spare part for.</value>
        [JsonProperty("isAccessoryOrSparePartFor")]
        public object IsAccessoryOrSparePartFor { get; set; }

        /// <summary>
        /// A pointer to another product (or multiple products) for which this product is a consumable.
        /// </summary>
        /// <value>The is consumable for.</value>
        [JsonProperty("isConsumableFor")]
        public object IsConsumableFor { get; set; }

        /// <summary>
        /// A pointer to another, somehow related product (or multiple products).
        /// </summary>
        /// <value>The is related to.</value>
        [JsonProperty("isRelatedTo")]
        public object IsRelatedTo { get; set; }

        /// <summary>
        /// A pointer to another, functionally similar product (or multiple products).
        /// </summary>
        /// <value>The is similar to.</value>
        [JsonProperty("isSimilarTo")]
        public object IsSimilarTo { get; set; }

        /// <summary>
        /// OfferItemCondition 	A predefined value from OfferItemCondition or a textual description of the condition of the product or service, or the products or services included in the offer.
        /// </summary>
        /// <value>The item condition.</value>
        [JsonProperty("itemCondition")]
        [JsonConverter(typeof(StringEnumConverter))]
        public OfferItemCondition? ItemCondition { get; set; }

        /// <summary>
        /// ImageObject  or URL - An associated logo.
        /// </summary>
        /// <value>The logo.</value>
        [JsonProperty("logo")]
        public object Logo { get; set; }

        /// <summary>
        /// Organization - The manufacturer of the product.
        /// </summary>
        /// <value>The manufacturer.</value>
        [JsonProperty("manufacturer")]
        public Organization Manufacturer { get; set; }

        /// <summary>
        /// ProductModel  or Text- The model of the product. Use with the URL of a ProductModel or a textual representation of the model identifier. The URL of the ProductModel can be from an external source. It is recommended to additionally provide strong product identifiers via the gtin8/gtin13/gtin14 and mpn properties.
        /// </summary>
        /// <value>The model.</value>
        [JsonProperty("model")]
        public object Model { get; set; }

        /// <summary>
        /// The Manufacturer Part Number (MPN) of the product, or the product to which the offer refers.
        /// </summary>
        /// <value>The MPN.</value>
        [JsonProperty("mpn")]
        public string Mpn { get; set; }

        /// <summary>
        /// An offer to provide this item—for example, an offer to sell a product, rent the DVD of a movie, or give away tickets to an event.
        /// </summary>
        /// <value>The offers.</value>
        [JsonProperty("offers")]
        public IList<Offer> Offers { get; set; }

        /// <summary>
        /// The product identifier, such as ISBN. For example: <meta itemprop="productID" content="isbn:123-456-789" />.
        /// </summary>
        /// <value>The product identifier.</value>
        [JsonProperty("productID")]
        public string ProductId { get; set; }

        object productionDate;
        /// <summary>
        /// Date - The date of production of the item, e.g. vehicle.
        /// </summary>
        /// <value>The release date.</value>
        [JsonProperty("productionDate")]
        public object ProductionDate {
            get {
                return productionDate;

            }
            set
            {
                var validator = new TypeValidator(new List<Type>() { typeof(DateTime), typeof(String) });
                validator.Validate(value);
                productionDate = value;
            }
        }

        object purchaseDate;
        /// <summary>
        /// Date - The date the item e.g. vehicle was purchased by the current owner.
        /// </summary>
        /// <value>The release date.</value>
        [JsonProperty("purchaseDate")]
        public object PurchaseDate
        {
            get
            {
                return purchaseDate;

            }
            set
            {
                var validator = new TypeValidator(new List<Type>() { typeof(DateTime), typeof(String) });
                validator.Validate(value);
                purchaseDate = value;
            }
        }

        object releaseDate;
        /// <summary>
        /// Date - The release date of a product or product model. This can be used to distinguish the exact variant of a product.
        /// </summary>
        /// <value>The release date.</value>
        [JsonProperty("releaseDate")]
        public object ReleaseDate {
            get
            {
                return releaseDate;

            }
            set
            {
                var validator = new TypeValidator(new List<Type>() { typeof(DateTime), typeof(String) });
                validator.Validate(value);
                releaseDate = value;
            }
        }
        /// <summary>
        /// Review 	A review of the item. Supersedes reviews.
        /// </summary>
        /// <value>The review.</value>
        [JsonProperty("review")]
        public Review Review { get; set; }

        /// <summary>
        /// Collection of reviews.
        /// </summary>
        /// <value>The reviews.</value>
        [JsonProperty("reviews")]
        public List<Review> Reviews { get; set; }

        /// <summary>
        /// The Stock Keeping Unit (SKU), i.e. a merchant-specific identifier for a product or service, or the product to which the offer refers.
        /// </summary>
        /// <value>The sku.</value>
        [JsonProperty("sku")]
        public string Sku { get; set; }

        /// <summary>
        /// QuantitativeValue 	The weight of the product or person.
        /// </summary>
        /// <value>The weight.</value>
        [JsonProperty("weight")]
        public QuantitativeValue Weight { get; set; }

        /// <summary>
        /// Distance  or QuantitativeValue - The width of the item.
        /// </summary>
        /// <value>The width.</value>
        [JsonProperty("width")]
        public Thing Width { get; set; }

        object additionalProperty;
        /// <summary>
        /// A property-value pair representing an additional characteristics of the entitity, e.g. a product feature or another characteristic 
        /// for which there is no matching property in schema.org. 
        /// Note: Publishers should be aware that applications designed to use specific schema.org properties 
        /// (e.g. http://schema.org/width, http://schema.org/color, http://schema.org/gtin13, ...) 
        /// will typically expect such data to be provided using those properties, rather than using the generic property/value mechanism.
        /// </summary>
        /// <value>The additional property.</value>
        [JsonProperty("additionalProperty")]
        public object AdditionalProperty
        {
            get
            {
                return additionalProperty;
            }
            set
            {
                var validator = new TypeValidator(new List<Type>() { typeof(PropertyValue), typeof(IList<PropertyValue>), typeof(List<PropertyValue>) });
                validator.Validate(value);
                additionalProperty = value;
            }
        }

    }
}