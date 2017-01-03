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
using System.Linq;
using System.Text;
using MXTires.Microdata.Intangible;
using MXTires.Microdata.Intangible.Quantities;
using MXTires.Microdata.Intangible.StructuredValues;
using MXTires.Microdata.Places.AdministrativeAreas;
using MXTires.Microdata.Validators;
using Newtonsoft.Json;

namespace MXTires.Microdata
{
    /// <summary>
    /// Class Person.
    /// </summary>
    public class Person: Thing
    {
        /// <summary>
        /// Gets or sets the job title.
        /// </summary>
        /// <value>The position.</value>
        [JsonProperty("jobTitle")]
        public  string JobTitle { get; set; }

        /// <summary>
        /// Gets or sets the award.
        /// </summary>
        /// <value>The award.</value>
        [JsonProperty("award")]
        public  string Award { get; set; }

        /// <summary>
        /// Gets or sets the telephone.
        /// </summary>
        /// <value>The telephone.</value>
        [JsonProperty("telephone")]
        public  string Telephone { get; set; }

        /// <summary>
        /// Gets or sets the given name.
        /// </summary>
        /// <value>The given name.</value>
        [JsonProperty("givenName")]
        public  string GivenName { get; set; }

        /// <summary>
        /// Gets or sets the additional name.
        /// </summary>
        /// <value>The additional name.</value>
        [JsonProperty("additionalName")]
        public  string AdditionalName { get; set; }

        /// <summary>
        /// Gets or sets the family name.
        /// </summary>
        /// <value>The family name.</value>
        [JsonProperty("familyName")]
        public  string FamilyName { get; set; }

        /// <summary>
        /// Gets or sets the honorific prefix.
        /// </summary>
        /// <value>The honorific prefix.</value>
        [JsonProperty("honorificPrefix")]
        public  string HonorificPrefix { get; set; }

        /// <summary>
        /// Gets or sets the honorific suffix.
        /// </summary>
        /// <value>The honorific suffix.</value>
        [JsonProperty("honorificSuffix")]
        public  string HonorificSuffix { get; set; }

        /// <summary>
        /// Gets or sets the gender.
        /// </summary>
        /// <value>The gender.</value>
        [JsonProperty("gender")]
        public string Gender { get; set; }

        /// <summary>
        /// Gets or sets the email.
        /// </summary>
        /// <value>The email.</value>
        [JsonProperty("email")]
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets the birth date.
        /// </summary>
        /// <value>The birth date.</value>
        [JsonProperty("birthDate")]
        public DateTime? BirthDate { get; set; }

        /// <summary>
        /// Gets or sets the birth place.
        /// </summary>
        /// <value>The birth place.</value>
        [JsonProperty("birthPlace")]
        public Place BirthPlace { get; set; }

        /// <summary>
        /// Gets or sets the biography.
        /// </summary>
        /// <value>The biography.</value>
        [JsonProperty("biography")]
        public  string Biography { get; set; }

        /// <summary>
        /// Gets or sets the organization.
        /// </summary>
        /// <value>The organization.</value>
        [JsonProperty("worksFor")]
        public Organization WorksFor { get; set; }

        /// <summary>
        /// Gets or sets the affiliation.
        /// </summary>
        /// <value>The affiliation.</value>
        [JsonProperty("affiliation")]
        public Organization Affiliation { get; set; }

        /// <summary>
        /// Gets or sets the alumni of.
        /// </summary>
        /// <value>The alumni of.</value>
        [JsonProperty("alumniOf")]
        public Organization AlumniOf { get; set; }

        /// <summary>
        /// Gets or sets the address.
        /// </summary>
        /// <value>The address.</value>
        [JsonProperty("address")]
        public Organization Address { get; set; }

        /// <summary>
        /// Text - The fax number.
        /// </summary>
        [JsonProperty("faxNumber")]
        public string FaxNumber { get; set; }

        /// <summary>
        /// Person - The most generic uni-directional social relation.
        /// </summary>
        [JsonProperty("follows")]
        public Person Follows { get; set; }

        Thing funder;
        /// <summary>
        /// Organization  or Person - A person or organization that supports (sponsors) something through some kind of financial contribution.
        /// </summary>
        [JsonProperty("funder")]
        public Thing Funder	{
            get { return this.funder; }
            set
            {
                TypeValidator validator = new TypeValidator(typeof(Organization), typeof(Brand));
                validator.Validate(value);
                this.funder = value;
            }
        }


        /// <summary>
        /// The brand
        /// </summary>
        private Thing brand;

        /// <summary>
        /// Gets or sets the brand.
        /// </summary>
        /// <value>The brand.</value>
        [JsonProperty("brand")]
        public Thing Brand
        {
            get { return this.brand; }
            set
            {
                TypeValidator validator = new TypeValidator(typeof(Organization), typeof(Brand));
                validator.Validate(value);
                this.brand = value;
            }
        }

        /// <summary>
        /// Person - Someone working for this organization. Supersedes <code>employees</code>.
        /// </summary>
        /// <value>The colleague.</value>
        [JsonProperty("colleague")]
        public Person Colleague { get; set; }

        /// <summary>
        /// Person - Someone working for this organization. Supersedes employees.
        /// </summary>
        /// <value>The colleagues.</value>
        [JsonProperty("colleagues")]
        public List<Person> Colleagues { get; set; }

        /// <summary>
        /// ContactPoint - A contact point for a person or organization. Supersedes <see cref="contactPoints"/>.
        /// </summary>
        [JsonProperty("contactPoint")]
        public ContactPoint ContactPoint { get; set; }

        /// <summary>
        /// Collection of contact points for a person or organization. Superseded by <see cref="ContactPoint"/> contactPoints.
        /// </summary>
        [JsonProperty("contactPoints")]
        public IList<ContactPoint> ContactPoints { get; set; }

        /// <summary>
        /// Date - Date of death.
        /// </summary>
        [JsonProperty("deathDate")]
        public DateTime? DeathDate { get; set; }


        /// <summary>
        /// Place - The place where the person died.
        /// </summary>
        [JsonProperty("deathPlace")]
        public Place DeathPlace { get; set; }

        /// <summary>
        /// Text - The Dun and Bradstreet DUNS number for identifying an organization or business person.
        /// </summary>
        /// <value>The duns.</value>
        [JsonProperty("duns")]
        public string Duns { get; set; }

        /// <summary>
        /// Text - The Global Location Number (GLN, sometimes also referred to as International Location Number or ILN) of the respective organization, person, or place. The GLN is a 13-digit number used to identify parties and physical locations.
        /// </summary>
        /// <value>The global location number.</value>
        [JsonProperty("globalLocationNumber")]
        public string GlobalLocationNumber { get; set; }

        /// <summary>
        /// Text - The International Standard of Industrial Classification of All Economic Activities (ISIC),
        /// Revision 4 code for a particular organization, business person, or place.
        /// </summary>
        /// <value>The isic v4.</value>
        [JsonProperty("isicV4")]
        public string IsicV4 { get; set; }

        /// <summary>
        /// Place -	Points-of-Sales operated by the organization or person.
        /// </summary>
        /// <value>The has position.</value>
        [JsonProperty("hasPOS")]
        public Place HasPOS { get; set; }

        /// <summary>
        /// Person - The most generic bi-directional social/work relation.
        /// </summary>
        [JsonProperty("knows")]
        public Person Knows { get; set; }

        /// <summary>
        /// Offer 	A pointer to products or services offered by the organization or person. Inverse property: <see cref="OfferedBy"/>.
        /// </summary>
        [JsonProperty("makesOffer")]
        public Offer MakesOffer { get; set; }

        /// <summary>
        /// The member of
        /// </summary>
        Thing memberOf;
        /// <summary>
        /// ProgramMembership  or Organization - An Organization (or ProgramMembership) to which this
        /// Person or Organization belongs. Inverse property: <code>member</code>.
        /// </summary>
        /// <value>The member of.</value>
        [JsonProperty("memberOf")]
        public Thing MemberOf
        {
            get { return this.memberOf; }
            set
            {
                TypeValidator validator = new TypeValidator(typeof(Organization), typeof(ProgramMembership));
                validator.Validate(value);
                this.memberOf = value;
            }
        }

        /// <summary>
        /// The work location
        /// </summary>
        private Thing workLocation;

        /// <summary>
        /// A contact location for a person's place of work.
        /// </summary>
        [JsonProperty("workLocation")]
        public Thing WorkLocation
        {
            get { return this.workLocation; }
            set
            {
                TypeValidator validator = new TypeValidator(typeof(Place), typeof(ContactPoint));
                validator.Validate(value);
                this.workLocation = value;
            }
        }


        /// <summary>
        /// OfferCatalog - Indicates an OfferCatalog listing for this Organization, Person, or Service. 
        /// </summary>
        [JsonProperty("hasOfferCatalog")]
        public OfferCatalog HasOfferCatalog { get; set; }

        Thing height;

        /// <summary>
        /// Distance  or QuantitativeValue - The height of the person.
        /// </summary>
       [JsonProperty("height")]
        public Thing  Height {
            get { return this.workLocation; }
            set
            {
                TypeValidator validator = new TypeValidator(typeof(Distance), typeof(QuantitativeValue));
                validator.Validate(value);
                this.height = value;
            }
        }	

        /// <summary>
        /// The home location
        /// </summary>
        private Thing homeLocation;

        /// <summary>
        /// A contact location for a person's residence.
        /// </summary>
        [JsonProperty("homeLocation")]
        public Thing HomeLocation
        {
            get { return this.homeLocation; }
            set
            {
                TypeValidator validator = new TypeValidator(typeof(Place), typeof(ContactPoint));
                validator.Validate(value);
                this.homeLocation = value;
            }
        }

        /// <summary>
        /// The North American Industry Classification System (NAICS) code for a particular organization or business person.
        /// </summary>
        [JsonProperty("naics")]
        public String Naics { get; set; }

        /// <summary>
        /// Country - Nationality of the person.
        /// </summary>
        [JsonProperty("nationality")]
        public Country Nationality { get; set; }

        private Thing netWorth;

        /// <summary>
        /// MonetaryAmount  or PriceSpecification - The total financial value of the person as calculated by subtracting assets from liabilities.
        /// </summary>
        [JsonProperty("netWorth")]
        public Thing NetWorth
        {
            get { return this.netWorth; }
            set
            {
                TypeValidator validator = new TypeValidator(typeof(MonetaryAmount), typeof(PriceSpecification));
                validator.Validate(value);
                this.netWorth = value;
            }
        }

        private Thing owns;

        /// <summary>
        /// OwnershipInfo  or Product - Products owned by the organization or person.
        /// </summary>
        [JsonProperty("owns")]
        public Thing Owns
        {
            get { return this.owns; }
            set
            {
                TypeValidator validator = new TypeValidator(typeof(OwnershipInfo), typeof(Product));
                validator.Validate(value);
                this.owns = value;
            }
        }

        /// <summary>
        /// Person - A parent of this person. Supersedes <see cref="Parents"/>.
        /// </summary>
        [JsonProperty("parent")]
        public Person Parent { get; set; }

        /// <summary>
        /// Parents of the person. Superseded by <see cref="Parent"/>.
        /// </summary>
        [JsonProperty("parents")]
        public IList<Person> Parents { get; set; }

        /// <summary>
        /// Event - Event that this person is a performer or participant in.
        /// </summary>
        [JsonProperty("performerIn")]
        public Event performerIn { get; set; }

        /// <summary>
        /// Person - The most generic familial relation.
        /// </summary>
        [JsonProperty("relatedTo")]
        public Person RelatedTo { get; set; }

        /// <summary>
        /// Demand - A pointer to products or services sought by the organization or person (demand).
        /// </summary>
        [JsonProperty("seeks")]
        public Demand Seeks { get; set; }

        /// <summary>
        /// Person - A sibling of the person. Supersedes <see cref="Siblings"/>.
        /// </summary>
        [JsonProperty("sibling")]
        public Person Sibling { get; set; }

        /// <summary>
        /// Sibling of the person. Superseded by <see cref="Sibling"/>.
        /// </summary>
        [JsonProperty("siblings")]
        public IList<Person> Siblings { get; set; }

        Thing sponsor;
             
        /// <summary>
        /// Organization  or Person  - A person or organization that supports a thing through a pledge, promise, or financial contribution. e.g. a sponsor of a Medical Study or a corporate sponsor of an event.
        /// </summary>
        [JsonProperty("sponsor")]
        public Thing Sponsor
        {
            get { return this.homeLocation; }
            set
            {
                TypeValidator validator = new TypeValidator(typeof(Organization), typeof(Person));
                validator.Validate(value);
                this.homeLocation = value;
            }
        }

        /// <summary>
        /// Person - The person's spouse.
        /// </summary>
        [JsonProperty("spouse")]
        public Person Spouse { get; set; }

        /// <summary>
        /// Text - The Tax / Fiscal ID of the organization or person, e.g. the TIN in the US or the CIF/NIF in Spain.
        /// </summary>
        [JsonProperty("taxID")]
        public String taxId { get; set; }

        /// <summary>
        /// Text - The Value-added Tax ID of the organization or person.
        /// </summary>
        [JsonProperty("vatID")]
        public String VatId { get; set; }

        /// <summary>
        /// QuantitativeValue - The weight of the product or person.
        /// </summary>
        [JsonProperty("weight")]
        public QuantitativeValue Weight { get; set; }


    }
}
