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
using System.Collections.Generic;
using MXTires.Microdata.CreativeWorks;
using MXTires.Microdata.Intangible;
using MXTires.Microdata.Validators;
using MXTires.Microdata.Intangible.StructuredValues;
using Newtonsoft.Json;

namespace MXTires.Microdata
{
    /// <summary>
    /// The most generic type of item.
    /// </summary>
    public class Thing
    {
        private static readonly JsonSerializerSettings SerializerSettings = new JsonSerializerSettings
        {
            NullValueHandling = NullValueHandling.Ignore
        };

        private static readonly TypeValidator ImageValidator =
            new TypeValidator(new List<Type> { typeof(string), typeof(ImageObject), typeof(string[]), typeof(ImageObject[]) });

        private static readonly TypeValidator MainEntityOfPageValidator =
            new TypeValidator("MXTires.Microdata.CreativeWorks", null, new List<Type> { typeof(string), typeof(WebSite) });

        private static readonly TypeValidator IdentifierValidator =
            new TypeValidator("MXTires.Microdata.Intangible", null, new List<Type> { typeof(string), typeof(PropertyValue), typeof(List<PropertyValue>), typeof(IList<PropertyValue>) });

        private static readonly TypeValidator SubjectOfValidator =
            new TypeValidator("MXTires.Microdata.CreativeWorks", null, new List<Type> { typeof(CreativeWork) });

        private object context = "http://schema.org";
        private object identifier;
        private object image;
        private object mainEntityOfPage;
        private object subjectOf;

        /// <summary>
        /// Context
        /// </summary>
        [JsonProperty("@context", Order = 1)]
        public virtual object Context
        {
            get { return context; }
            set { context = value; }
        }

        /// <summary>
        /// Property for External Extensions
        /// </summary>
        internal IList<Property> ExternalExtensions { get; set; }

        /// <summary>
        /// Type tag
        /// </summary>
        [JsonProperty("@type", Order = 2)]
        public virtual string Type { get { return GetType().Name; } }

        /// <summary>
        /// ID
        /// </summary>
        [JsonProperty("@id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// URL 	An additional type for the item, typically used for adding more specific types from external vocabularies in microdata syntax. 
        /// This is a relationship between something and a class that the thing is in. In RDFa syntax, it is better to use the native RDFa syntax - the 
        /// 'typeof' attribute - for multiple types. Schema.org tools may have only weaker understanding of extra types, in particular those 
        /// defined externally.
        /// </summary>
        [JsonProperty("additionalType", NullValueHandling = NullValueHandling.Ignore)]
        public string AdditionalType { get; set; }

        /// <summary>
        /// Text 	An alias for the item.
        /// </summary>
        [JsonProperty("alternateName", NullValueHandling = NullValueHandling.Ignore)]
        public string AlternateName { get; set; }

        /// <summary>
        /// Text 	A short description of the item.
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// Text - A sub property of description. A short description of the item used to disambiguate from other, similar items.
        /// </summary>
        [JsonProperty("disambiguatingDescription", NullValueHandling = NullValueHandling.Ignore)]
        public string DisambiguatingDescription { get; set; }

        /// <summary>
        /// The identifier property represents any kind of identifier for any kind of Thing, such as ISBNs, GTIN codes, UUIDs etc.
        /// Schema.org: PropertyValue | Text | URL
        /// </summary>
        [JsonProperty("identifier", NullValueHandling = NullValueHandling.Ignore)]
        public object Identifier
        {
            get { return identifier; }
            set
            {
                IdentifierValidator.Validate(value);
                identifier = value;
            }
        }

        /// <summary>
        /// URL to an image of the item. This can be a URL or a fully described ImageObject.
        /// </summary>
        [JsonProperty("image", NullValueHandling = NullValueHandling.Ignore)]
        public object Image
        {
            get { return image; }
            set
            {
                ImageValidator.Validate(value);
                image = value;
            }
        }

        /// <summary>
        /// Text 	The name of the item.
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }
        /// <summary>
        /// Action - Indicates a potential Action, which describes an idealized action in which this thing would play an 'object' role.
        /// </summary>

        [JsonProperty("potentialAction", NullValueHandling = NullValueHandling.Ignore)]
        public Microdata.Action PotentialAction { get; set; }

        /// <summary>
        ///	URL of a reference Web page that unambiguously indicates the item's identity. E.g. the URL of the item's Wikipedia page, Freebase page, or official website.
        /// </summary>
        [JsonProperty("sameAs", NullValueHandling = NullValueHandling.Ignore)]
        public IList<string> SameAs { get; set; }

        /// <summary>
        /// URL of the item.
        /// </summary>
        [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
        public string Url { get; set; }

        /// <summary>
        /// URL  or CreativeWork - Indicates a page (or other CreativeWork) for which this thing is the main entity being described.
        /// Many (but not all) pages have a fairly clear primary topic, some entity or thing that the page describes. For example a restaurant's home page might be primarily about that Restaurant, or an event listing page might represent a single event. The mainEntity and mainEntityOfPage properties allow you to explicitly express the relationship between the page and the primary entity. 
        /// Related properties include sameAs, about, and url. 
        /// The sameAs and url properties are both similar to mainEntityOfPage. The url property should be reserved to refer to more official or authoritative web pages, such as the item’s official website. The sameAs property also relates a thing to a page that indirectly identifies it. Whereas sameAs emphasises well known pages, the mainEntityOfPage property serves more to clarify which of several entities is the main one for that page. 
        /// mainEntityOfPage can be used for any page, including those not recognized as authoritative for that entity. For example, for a product, sameAs might refer to a page on the manufacturer’s official site with specs for the product, while mainEntityOfPage might be used on pages within various retailers’ sites giving details for the same product. 
        /// about is similar to mainEntity, with two key differences. First, about can refer to multiple entities/topics, while mainEntity should be used for only the primary one. Second, some pages have a primary entity that itself describes some other entity. For example, one web page may display a news article about a particular person. Another page may display a product review for a particular product. In these cases, mainEntity for the pages should refer to the news article or review, respectively, while about would more properly refer to the person or product. 
        /// Inverse property: mainEntity.
        /// </summary>
        [JsonProperty("mainEntityOfPage", NullValueHandling = NullValueHandling.Ignore)]
        public object MainEntityOfPage
        {
            get { return mainEntityOfPage; }
            set
            {
                MainEntityOfPageValidator.Validate(value);
                mainEntityOfPage = value;
            }
        }

        /// <summary>
        /// A CreativeWork or Event about this Thing.
        /// Schema.org: CreativeWork | Event
        /// </summary>
        [JsonProperty("subjectOf", NullValueHandling = NullValueHandling.Ignore)]
        public object SubjectOf
        {
            get { return subjectOf; }
            set
            {
                SubjectOfValidator.Validate(value);
                subjectOf = value;
            }
        }

        /// <summary>
        /// Returns Json string that  represents current object.
        /// JSON written by the serializer with an option of Formatting.None and NullValueHandling.Ignore. It makes the JSON result small, skipping all unnecessary 
        /// spaces and line breaks to produce the most compact and efficient JSON possible.
        /// </summary>
        /// <returns></returns>
        public string ToJson()
        {
            return Serialize(Formatting.None, wrapInScriptTag: true);
        }

        /// <summary>
        /// Returns Json string that  represents current object.
        /// JSON written by the serializer with an option of Formatting.Indented produces nicely formatted, easy to read JSON – great when you are developing. 
        /// </summary>
        /// <returns></returns>
        public string ToIndentedJson()
        {
            return Serialize(Formatting.Indented, wrapInScriptTag: true);
        }
        /// <summary>
        /// Returns Json string that  represents current object.
        /// JSON written by the serializer with an option of Formatting.None and NullValueHandling.Ignore. It makes the JSON result small, skipping all unnecessary 
        /// spaces and line breaks to produce the most compact and efficient JSON possible.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Serialize(Formatting.None, wrapInScriptTag: false);
        }

        private string Serialize(Formatting formatting, bool wrapInScriptTag)
        {
            var json = JsonConvert.SerializeObject(this, formatting, SerializerSettings);

            if (!wrapInScriptTag)
            {
                return json;
            }

            return "<script type=\"application/ld+json\">" + json + "</script>";
        }
    }
}