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

using MXTires.Microdata.CreativeWorks;
using MXTires.Microdata.Intangible.Enumeration.Medical;
using MXTires.Microdata.Intangible.StructuredValues;
using MXTires.Microdata.Validators;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using static System.Net.Mime.MediaTypeNames;

namespace MXTires.Microdata.Intangible
{
    /// <summary>
    /// Class Service.
    /// </summary>
    public class Service : Thing
    {
        /// <summary>
        /// The overall rating, based on a collection of reviews or ratings, of the item.
        /// </summary>
        [JsonProperty("aggregateRating")]
        public AggregateRating AggregateRating { get; set; }

        /// <summary>
        /// AdministrativeArea - The geographic area where the service is provided. Supersedes <see cref="ServiceArea"/>.
        /// </summary>
        /// <value>The service area.</value>
        [JsonProperty("areaServed")]
        public object AreaServed { get; set; }

        /// <summary>
        /// Audience - An intended audience, i.e. a group for whom something was created. Supersedes <see cref="ServiceAudience"/>.
        /// </summary>
        /// <value>The service audience.</value>
        [JsonProperty("audience")]
        public Audience Audience { get; set; }

        /// <summary>
        /// ServiceChannel - A means of accessing the service (e.g. a phone bank, a web site, a location, etc.).
        /// </summary>
        /// <value>The available channel.</value>
        [JsonProperty("availableChannel")]
        public ServiceChannel AvailableChannel { get; set; }

        /// <summary>
        ///  Text - An award won by or for this item. Supersedes  <see cref="Awards"/>.
        /// </summary>
        [JsonProperty("award")]
        public string Award { get; set; }

        /// <summary>
        ///  Collection of texts - Awards won by or for this item. Superseded by  <see cref="Award"/>.
        /// </summary>
        [JsonProperty("awards")]
        public List<string> Awards { get; set; }

        private List<Thing> brand;
        /// <summary>
        /// Brand or Organization - The brand(s) associated with a product or service, or the brand(s) maintained by an organization or business person.
        /// </summary>
        [JsonProperty("brand")]
        public List<Thing> Brand
        {
            get { return brand; }
            set
            {
                var validator = new TypeValidator(typeof(Organization), typeof(Brand));
                foreach (var item in value)
                {
                    validator.Validate(item);
                }
                brand = value;
            }
        }

        Thing broker;
        /// <summary>
        /// Person  or Organization - An entity that arranges for an exchange between a buyer and a seller. In most cases a broker never acquires or releases ownership of a product or service involved in an exchange. If it is not clear whether an entity is a broker, seller, or buyer, the latter two terms are preferred. Supersedes bookingAgent.
        /// </summary>
        [JsonProperty("broker")]
        public Thing Broker
        {
            get { return broker; }
            set
            {
                var validator = new TypeValidator(typeof(Organization), typeof(Person));
                validator.Validate(value);
                broker = value;
            }
        }

        object category;
        /// <summary>
        /// Text  or PhysicalActivityCategory  or Thing - A category for the item. 
        /// Greater signs or slashes can be used to informally indicate a category hierarchy.
        /// </summary>
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
        /// OfferCatalog - Indicates an OfferCatalog listing for this Organization, Person, or Service. 
        /// </summary>
        [JsonProperty("hasOfferCatalog")]
        public OfferCatalog HasOfferCatalog { get; set; }

        /// <summary>
        /// OpeningHoursSpecification - The hours during which this service or contact is available.
        /// </summary>
        [JsonProperty("hoursAvailable")]
        public OpeningHoursSpecification HoursAvailable { get; set; }

        object isRelatedTo;
        /// <summary>
        /// Product or Service - A pointer to another, somehow related product (or multiple products).
        /// </summary>
        /// <value>The is related to.</value>
        [JsonProperty("isRelatedTo")]
        public object IsRelatedTo
        {
            get { return isRelatedTo; }
            set
            {
                var validator = new TypeValidator(new List<Type>(new Type[] { typeof(Product), typeof(Service), typeof(IList<Product>), typeof(IList<Service>) }));
                validator.Validate(value);
                isRelatedTo = value;
            }
        }

        object isSimilarTo;
        /// <summary>
        /// Product or Service - A pointer to another, functionally similar product (or multiple products).
        /// </summary>
        /// <value>The is related to.</value>
        [JsonProperty("isSimilarTo")]
        public object IsSimilarTo
        {
            get { return isSimilarTo; }
            set
            {
                var validator = new TypeValidator(new List<Type>(new Type[] { typeof(Product), typeof(Service), typeof(IList<Product>), typeof(IList<Service>) }));
                validator.Validate(value);
                isSimilarTo = value;
            }
        }

        object logo;
        /// <summary>
        /// An associated logo.
        /// </summary>
        [JsonProperty("logo")]
        public object Logo
        {
            get { return logo; }
            set
            {
                var validator = new TypeValidator(typeof(ImageObject), typeof(String));
                validator.Validate(value);
                logo = value;
            }
        }

        /// <summary>
        /// Demand or Offer - An offer to provide this item—for example, an offer to sell a product, rent the DVD of a movie, perform a service, 
        /// or give away tickets to an event. Use businessFunction to indicate the kind of transaction offered, i.e. sell, lease, etc. 
        /// This property can also be used to describe a Demand. While this property is listed as expected on a number of common types, it can be used in others. 
        /// In that case, using a second type, such as Product or a subtype of Product, can clarify the nature of the offer. 
        /// Inverse property: <see cref="ItemOffered"/> 
        /// </summary>
        [JsonProperty("offers")]
        public IList<Thing> Offers { get; set; }

        /// <summary>
        /// Thing - The tangible thing generated by the service, e.g. a passport, permit, etc. Superceeded by <see cref="ServiceOutput"/>
        /// </summary>
        /// <value>The produces.</value>
        [JsonProperty("produces")]
        [Obsolete("This term has been superseded. Use ServiceOutput instead.")]
        public Thing Produces { get; set; }

        /// <summary>
        /// The provider
        /// </summary>
        Thing provider;
        /// <summary>
        /// Person  or Organization - The service provider, service operator, or service performer; the goods producer. Another party (a seller) may offer those services or goods on behalf of the provider. A provider may also serve as the seller. Supersedes carrier.
        /// </summary>
        /// <value>The provider.</value>
        [JsonProperty("provider")]
        public Thing Provider
        {
            get { return provider; }
            set
            {
                var validator = new TypeValidator(typeof(Organization), typeof(Person));
                validator.Validate(value);
                provider = value;
            }
        }

        /// <summary>
        /// Text - Indicates the mobility of a provided service(e.g. 'static', 'dynamic').
        /// </summary>
        [JsonProperty("providerMobility")] 
        public string ProviderMobility { get; set; }

        /// <summary>
        /// Review - A review of the item. Supersedes <see cref="Reviews"/>.
        /// </summary>
        [JsonProperty("review")]
        public Review Review { get; set; }

        /// <summary>
        /// Review of the item. Superseded by <see cref="Review"/>.
        /// </summary>
        [JsonProperty("reviews")]
        public IList<Review> Reviews { get; set; }

        /// <summary>
        /// Thing - The tangible thing generated by the service, e.g.a passport, permit, etc. Supersedes <see cref="Produces"/>.
        /// </summary>
        [JsonProperty("serviceOutput")]
        public Thing ServiceOutput { get; set; } 

        /// <summary>
        /// AdministrativeArea - The geographic area where the service is provided. Superseded by <see cref="AreaServed"/>
        /// </summary>
        /// <value>The service area.</value>
        [JsonProperty("serviceArea")]
        public AdministrativeArea ServiceArea { get; set; }

        /// <summary>
        /// Audience - The audience eligible for this service. Superseded by<see cref="Audience"/>.
        /// </summary>
        /// <value>The service audience.</value>
        [JsonProperty("serviceAudience")]
        public Audience ServiceAudience { get; set; }

        /// <summary>
        /// Text or GovernmentBenefitsType - The type of service being offered, e.g. veterans' benefits, emergency relief, etc.
        /// </summary>
        /// <value>The type of the service.</value>
        [JsonProperty("serviceType")]
        public object ServiceType { get; set; }

        /// <summary>
        /// Text - A slogan or motto associated with the item.
        /// </summary>
        [JsonProperty("slogan")]
        public string Slogan { get; set; }

        /// <summary>
        /// Text or URL - Human-readable terms of service documentation.
        /// </summary>
        [JsonProperty("termsOfService")]
        public string TermsOfService { get; set; }
    }
}