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
using MXTires.Microdata.Intangible.Enumeration;
using MXTires.Microdata.Intangible.StructuredValues;
using MXTires.Microdata.Validators;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
namespace MXTires.Microdata
{
    /// <summary>
    /// An organization such as a school, NGO, corporation, club, etc.
    /// </summary>
    public class Organization : Thing
    {
        /// <summary>
        /// PostalAddress - Physical address of the item.
        /// </summary>
        public PostalAddress Address
        {
            set
            {
                Addresses = Addresses ?? new List<PostalAddress>();
                Addresses.Add(value);
            }
        }

        /// <summary>
        /// PostalAddress - Physical addresses of the item.
        /// </summary>
        [JsonProperty("address")]
        public List<PostalAddress> Addresses { get; set; }

        /// <summary>
        /// The locations of the event, organization or action.
        /// </summary>
        [JsonProperty("location")]
        public Place Location { get; set; }

        /// <summary>
        /// The telephone number.
        /// </summary>
        [JsonProperty("telephone")]
        public string Telephone { get; set; }

        /// <summary>
        /// A review of the item. Supersedes reviews.
        /// </summary>
        [JsonProperty("review")]
        public Review Review { get; set; }

        /// <summary>
        /// Review collection
        /// </summary>
        [JsonProperty("reviews")]
        public List<Review> Reviews { get; set; }

        /// <summary>
        /// Offer - A pointer to products or services offered by the organization or person.
        /// </summary>
        [JsonProperty("makesOffer")]
        public List<Offer> MakesOffer { get; set; }

        /// <summary>
        /// Text - The official name of the organization, e.g. the registered company name.
        /// </summary>
        [JsonProperty("legalName")]
        public string LegalName { get; set; }

        /// <summary>
        /// AggregateRating - The overall rating, based on a collection of reviews or ratings, of the item.
        /// </summary>
        [JsonProperty("aggregateRating")]
        public AggregateRating AggregateRating { get; set; }

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
        /// ContactPoint - A contact point for a person or organization. Supersedes contactPoints.
        /// </summary>
        [JsonProperty("contactPoint")]
        public ContactPoint ContactPoint { get; set; }

        object department { get; set; }
        /// <summary>
        /// Organization or IList<Organization> - A relationship between an organization and a department of that organization, 
        /// also described as an organization (allowing different urls, logos, opening hours). 
        /// For example: a store with a pharmacy, or a bakery with a cafe.
        /// </summary>
        /// <remarks>Can have multiple departments</remarks>
        [JsonProperty("department")]
        public object Department
        {
            get { return department; }
            set
            {
                var validator = new TypeValidator(typeof(Organization), typeof(IList<Organization>));
                validator.Validate(value);
                department = value;
            }
        }
        
        /// <summary>
        /// Date - The date that this organization was dissolved.
        /// </summary>
        [JsonProperty("dissolutionDate")]
        public DateTime? DissolutionDate { get; set; }

        /// <summary>
        /// Text - The Dun and Bradstreet DUNS number for identifying an organization or business person.
        /// </summary>
        [JsonProperty("duns")]
        public string Duns { get; set; }

        /// <summary>
        /// Text - Email address.
        /// </summary>
        [JsonProperty("email")]
        public string Email { get; set; }

        /// <summary>
        /// Person - Someone working for this organization. Supersedes <see cref="Employees"/>.
        /// </summary>
        [JsonProperty("employee")]
        public Person Employee { get; set; }

        /// <summary>
        /// Person - Someone working for this organization. Superseded by <see cref="Employees"/>.
        /// </summary>
        [JsonProperty("employees")]
        public List<Person> Employees { get; set; }

        /// <summary>
        /// Upcoming or past event associated with this place, organization, or action. Supersedes <see cref="Events"/>.
        /// </summary>
        [JsonProperty("event")]
        public Event Event { get; set; }

        /// <summary>
        /// Collection of upcoming or past event associated with this place, organization, or action. Superseded by <see cref="Event"/>.
        /// </summary>
        [JsonProperty("events")]
        public List<Event> Events { get; set; }

        /// <summary>
        /// Text - The fax number.
        /// </summary>
        [JsonProperty("faxNumber")]
        public string FaxNumber { get; set; }

        /// <summary>
        /// A person who founded this organization. Supersedes <see cref="Founders"/>.
        /// </summary>
        [JsonProperty("founder")]
        public Person Founder { get; set; }

        /// <summary>
        /// Collection of people who founded this organization. Superseded by <see cref="Founder"/>
        /// </summary>
        [JsonProperty("founders")]
        public List<Person> Founders { get; set; }

        /// <summary>
        /// Date - The date that this organization was founded.
        /// </summary>
        [JsonProperty("foundingDate")]
        public DateTime? FoundingDate { get; set; }

        /// <summary>
        /// Place - The place where the Organization was founded.
        /// </summary>
        [JsonProperty("foundingLocation")]
        public Place FoundingLocation { get; set; }

        /// <summary>
        /// Text - The Global Location Number (GLN, sometimes also referred to as International Location Number or ILN) 
        /// of the respective organization, person, or place. The GLN is a 13-digit number used to identify parties and 
        /// physical locations.
        /// </summary>
        [JsonProperty("globalLocationNumber")]
        public string GlobalLocationNumber { get; set; }

        /// <summary>
        /// Place -	Points-of-Sales operated by the organization or person.
        /// </summary>
        [JsonProperty("hasPOS")]
        public Place HasPOS { get; set; }

        /// <summary>
        /// Text - A count of a specific user interactions with this item—for example, 20 UserLikes, 5 UserComments, 
        /// or 300 UserDownloads. The user interaction type should be one of the sub types of UserInteraction.
        /// </summary>
        [JsonProperty("interactionCount")]
        public string InteractionCount { get; set; }

        /// <summary>
        /// Text - The International Standard of Industrial Classification of All Economic Activities (ISIC), 
        /// Revision 4 code for a particular organization, business person, or place.
        /// </summary>
        [JsonProperty("isicV4")]
        public string IsicV4 { get; set; }

        private Thing member;

        /// <summary>
        /// Person  or Organization - A member of an Organization or a ProgramMembership. 
        /// Organizations can be members of organizations; ProgramMembership is typically for individuals. 
        /// Supersedes members, musicGroupMember.Inverse property: <code>memberOf</code>.
        /// </summary>
        [JsonProperty("member")]
        public Thing Member
        {
            get { return member; }
            set
            {
                var validator = new TypeValidator(typeof(Organization), typeof(Person));
                validator.Validate(value);
                member = value;
            }
        }

        Thing memberOf;
        /// <summary>
        /// ProgramMembership  or Organization - An Organization (or ProgramMembership) to which this 
        /// Person or Organization belongs. Inverse property: <code>member</code>.
        /// </summary>
        [JsonProperty("memberOf")]
        public Thing MemberOf
        {
            get { return memberOf; }
            set
            {
                var validator = new TypeValidator(typeof(Organization), typeof(ProgramMembership));
                validator.Validate(value);
                memberOf = value;
            }
        }

        /// <summary>
        /// The North American Industry Classification System (NAICS) code for a particular organization or business person.
        /// </summary>
        [JsonProperty("naics")]
        public string Naics { get; set; }

        /// <summary>
        /// NonprofitType - nonprofit Status indicates the legal status of a non-profit organization in its primary place of business.
        /// </summary>
        [JsonProperty("nonprofitStatus")]
        public NonprofitType? NonprofitStatus { get; set; }

        List<Thing> owns;

        /// <summary>
        /// Product  or OwnershipInfo - Products owned by the organization or person.
        /// </summary>
        [JsonProperty("owns")]
        public List<Thing> Owns
        {
            get { return owns; }
            set
            {
                var validator = new TypeValidator(typeof(Product), typeof(OwnershipInfo));
                foreach (var item in value)
                {
                    validator.Validate(item);
                }
                owns = value;
            }
        }

        /// <summary>
        /// The Tax / Fiscal ID of the organization or person, e.g. the TIN in the US or the CIF/NIF in Spain.
        /// </summary>
        [JsonProperty("taxID")]
        public string TaxID { get; set; }

        /// <summary>
        /// Demand 	A pointer to products or services sought by the organization or person (demand).
        /// </summary>
        [JsonProperty("seeks")]
        public Demand Seeks { get; set; }

        /// <summary>
        /// Organization - A relationship between two organizations where the first includes the second, e.g., as a subsidiary. 
        /// See also: the more specific 'department' property.
        /// </summary>
        [JsonProperty("subOrganization")]
        public Organization SubOrganization { get; set; }

        /// <summary>
        /// Text - The Value-added Tax ID of the organization or person.
        /// </summary>
        [JsonProperty("vatID")]
        public string VatID { get; set; }

        /// <summary>
        /// MerchantReturnPolicy - Specifies a MerchantReturnPolicy that may be applicable. Supersedes <see cref="HasProductReturnPolicy"/>.
        /// </summary>
        [JsonProperty("hasMerchantReturnPolicy")]
        public MerchantReturnPolicy HasMerchantReturnPolicy { get; set; }

        /// <summary>
        /// LoanOrCredit, PaymentMethod, or Text - The payment method(s) that are accepted in general by an organization, or for some specific demand or offer.
        /// </summary>
        [JsonProperty("acceptedPaymentMethod")]
        [JsonConverter(typeof(StringEnumConverter))]
        public PaymentMethod? AcceptedPaymentMethod { get; set; }

        private object actionableFeedbackPolicy;
        /// <summary>
        /// CreativeWork or URL - A policy on the kind of feedback the organization accepts, and the kind of transparency for feedback given, e.g. a code of conduct that respects the anonymity of reviewers.
        /// </summary>
        [JsonProperty("actionableFeedbackPolicy")]
        public object ActionableFeedbackPolicy
        {
            get { return actionableFeedbackPolicy; }
            set
            {
                var validator = new TypeValidator(typeof(CreativeWork), typeof(string));
                validator.Validate(value);
                actionableFeedbackPolicy = value;
            }
        }

        /// <summary>
        /// InteractionCounter - The number of completed interactions for this entity, in a particular role (the 'agent'), in a particular action (indicated in the statistic), and in a particular context (i.e. interactionService).
        /// </summary>
        [JsonProperty("agentInteractionStatistic")]
        public InteractionCounter AgentInteractionStatistic { get; set; }

        /// <summary>
        /// Person - Alumni of an organization.
        /// </summary>
        [JsonProperty("alumni")]
        public Person Alumni { get; set; }

        private object areaServed;
        /// <summary>
        /// AdministrativeArea, GeoShape, Place, or Text - The geographic area where a service or offered item is provided.
        /// </summary>
        [JsonProperty("areaServed")]
        public object AreaServed
        {
            get { return areaServed; }
            set
            {
                var validator = new TypeValidator(new List<Type> { typeof(AdministrativeArea), typeof(GeoShape), typeof(Place), typeof(string) });
                validator.Validate(value);
                areaServed = value;
            }
        }

        /// <summary>
        /// Text - An award won by or for this organization.
        /// </summary>
        [JsonProperty("award")]
        public string Award { get; set; }

        /// <summary>
        /// Certification - Certification information about a product, organization, service, place, or person.
        /// </summary>
        [JsonProperty("companyRegistration")]
        public Certification CompanyRegistration { get; set; }

        private object correctionsPolicy;
        /// <summary>
        /// CreativeWork or URL - For an Organization (e.g. NewsMediaOrganization), a statement describing (in news media, the newsroom's) disclosure and correction policy for errors.
        /// </summary>
        [JsonProperty("correctionsPolicy")]
        public object CorrectionsPolicy
        {
            get { return correctionsPolicy; }
            set
            {
                var validator = new TypeValidator(typeof(CreativeWork), typeof(string));
                validator.Validate(value);
                correctionsPolicy = value;
            }
        }

        private object diversityPolicy;
        /// <summary>
        /// CreativeWork or URL - Statement on diversity policy by an Organization e.g. a NewsMediaOrganization.
        /// </summary>
        [JsonProperty("diversityPolicy")]
        public object DiversityPolicy
        {
            get { return diversityPolicy; }
            set
            {
                var validator = new TypeValidator(typeof(CreativeWork), typeof(string));
                validator.Validate(value);
                diversityPolicy = value;
            }
        }

        private object diversityStaffingReport;
        /// <summary>
        /// Article or URL - For an Organization (often but not necessarily a NewsMediaOrganization), a report on staffing diversity.
        /// </summary>
        [JsonProperty("diversityStaffingReport")]
        public object DiversityStaffingReport
        {
            get { return diversityStaffingReport; }
            set
            {
                var validator = new TypeValidator(typeof(Article), typeof(string));
                validator.Validate(value);
                diversityStaffingReport = value;
            }
        }

        private object ethicsPolicy;
        /// <summary>
        /// CreativeWork or URL - Statement about ethics policy, e.g. of a NewsMediaOrganization regarding journalistic and publishing practices, or of a Restaurant, a page describing food source policies.
        /// </summary>
        [JsonProperty("ethicsPolicy")]
        public object EthicsPolicy
        {
            get { return ethicsPolicy; }
            set
            {
                var validator = new TypeValidator(typeof(CreativeWork), typeof(string));
                validator.Validate(value);
                ethicsPolicy = value;
            }
        }

        private Thing funder;
        /// <summary>
        /// Organization or Person - A person or organization that supports (sponsors) something through some kind of financial contribution.
        /// </summary>
        [JsonProperty("funder")]
        public Thing Funder
        {
            get { return funder; }
            set
            {
                var validator = new TypeValidator(typeof(Organization), typeof(Person));
                validator.Validate(value);
                funder = value;
            }
        }

        /// <summary>
        /// Grant - A Grant that directly or indirectly provided funding or sponsorship for this organization.
        /// </summary>
        [JsonProperty("funding")]
        public Grant Funding { get; set; }

        /// <summary>
        /// Certification - Certification information about a product, organization, service, place, or person.
        /// </summary>
        [JsonProperty("hasCertification")]
        public Certification HasCertification { get; set; }

        /// <summary>
        /// Credential - A credential awarded to the Person or Organization.
        /// </summary>
        [JsonProperty("hasCredential")]
        public Credential HasCredential { get; set; }

        /// <summary>
        /// URL - The <a href="https://www.gs1.org/standards/gs1-digital-link">GS1 digital link</a> associated with the object.
        /// </summary>
        [JsonProperty("hasGS1DigitalLink")]
        public string HasGS1DigitalLink { get; set; }

        /// <summary>
        /// MemberProgram - MemberProgram offered by an Organization, for example an eCommerce merchant or an airline.
        /// </summary>
        [JsonProperty("hasMemberProgram")]
        public MemberProgram HasMemberProgram { get; set; }

        /// <summary>
        /// OfferCatalog - Indicates an OfferCatalog listing for this Organization, Person, or Service.
        /// </summary>
        [JsonProperty("hasOfferCatalog")]
        public OfferCatalog HasOfferCatalog { get; set; }

        /// <summary>
        /// ShippingService - Indicates a ShippingService offered by the Organization or Person.
        /// </summary>
        [JsonProperty("hasShippingService")]
        public ShippingService HasShippingService { get; set; }

        /// <summary>
        /// InteractionCounter - The number of interactions for the CreativeWork using the WebSite or SoftwareApplication.
        /// </summary>
        [JsonProperty("interactionStatistic")]
        public InteractionCounter InteractionStatistic { get; set; }

        /// <summary>
        /// Text - The International Organization for Standardization (ISO) 6523 code for a particular organization, person, or place.
        /// </summary>
        [JsonProperty("iso6523Code")]
        public string Iso6523Code { get; set; }

        /// <summary>
        /// DefinedTerm, Text, or URL - Keywords or tags used to describe some item.
        /// </summary>
        [JsonProperty("keywords")]
        public string Keywords { get; set; }

        private object knowsAbout;
        /// <summary>
        /// Text, Thing, or URL - Of a Person, and less typically of an Organization, to indicate a topic that is known about - suggesting possible expertise but not implying it.
        /// </summary>
        [JsonProperty("knowsAbout")]
        public object KnowsAbout
        {
            get { return knowsAbout; }
            set
            {
                var validator = new TypeValidator(typeof(Thing), typeof(string));
                validator.Validate(value);
                knowsAbout = value;
            }
        }

        /// <summary>
        /// Language or Text - Of a Person, and less typically of an Organization, to indicate a known language.
        /// </summary>
        [JsonProperty("knowsLanguage")]
        public string KnowsLanguage { get; set; }

        /// <summary>
        /// PostalAddress - The official, legally-registered address of an Organization.
        /// </summary>
        [JsonProperty("legalAddress")]
        public PostalAddress LegalAddress { get; set; }

        /// <summary>
        /// Person - A person who represents an organization legally.
        /// </summary>
        [JsonProperty("legalRepresentative")]
        public Person LegalRepresentative { get; set; }

        /// <summary>
        /// Text - An organization identifier that uniquely identifies a legal entity as defined in ISO 17442.
        /// </summary>
        [JsonProperty("leiCode")]
        public string LeiCode { get; set; }

        /// <summary>
        /// QuantitativeValue - The number of employees in an organization, e.g. business.
        /// </summary>
        [JsonProperty("numberOfEmployees")]
        public QuantitativeValue NumberOfEmployees { get; set; }

        private object ownershipFundingInfo;
        /// <summary>
        /// CreativeWork or Text or URL - For an Organization (often but not necessarily a NewsMediaOrganization), a description of organizational ownership structure; funding and grants.
        /// </summary>
        [JsonProperty("ownershipFundingInfo")]
        public object OwnershipFundingInfo
        {
            get { return ownershipFundingInfo; }
            set
            {
                var validator = new TypeValidator(typeof(CreativeWork), typeof(string));
                validator.Validate(value);
                ownershipFundingInfo = value;
            }
        }

        /// <summary>
        /// Organization - The larger organization that this organization is a subOrganization of, if any.
        /// </summary>
        [JsonProperty("parentOrganization")]
        public Organization ParentOrganization { get; set; }

        /// <summary>
        /// URL - Link to page describing the editorial principles of the organization primarily responsible for the creation of the CreativeWork.
        /// </summary>
        [JsonProperty("publishingPrinciples")]
        public string PublishingPrinciples { get; set; }

        /// <summary>
        /// DefinedTerm or Text - A statement of knowledge, skill, ability, task or any other assertion expressing a competency that is desired or required.
        /// </summary>
        [JsonProperty("skills")]
        public string Skills { get; set; }

        /// <summary>
        /// Text - A slogan or motto associated with the item.
        /// </summary>
        [JsonProperty("slogan")]
        public string Slogan { get; set; }

        private Thing sponsor;
        /// <summary>
        /// Organization or Person - A person or organization that supports a thing through a pledge, promise, or financial contribution.
        /// </summary>
        [JsonProperty("sponsor")]
        public Thing Sponsor
        {
            get { return sponsor; }
            set
            {
                var validator = new TypeValidator(typeof(Organization), typeof(Person));
                validator.Validate(value);
                sponsor = value;
            }
        }

        private object unnamedSourcesPolicy;
        /// <summary>
        /// CreativeWork or URL - For an Organization (typically a NewsMediaOrganization), a statement about policy on use of unnamed sources.
        /// </summary>
        [JsonProperty("unnamedSourcesPolicy")]
        public object UnnamedSourcesPolicy
        {
            get { return unnamedSourcesPolicy; }
            set
            {
                var validator = new TypeValidator(typeof(CreativeWork), typeof(string));
                validator.Validate(value);
                unnamedSourcesPolicy = value;
            }
        }
    }
}
