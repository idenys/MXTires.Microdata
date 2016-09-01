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
using MXTires.Microdata.Intangible.StructuredValues;
using MXTires.Microdata.Validators;
using Newtonsoft.Json;
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

        /// <summary>
        /// Organization - A relationship between an organization and a department of that organization, 
        /// also described as an organization (allowing different urls, logos, opening hours). 
        /// For example: a store with a pharmacy, or a bakery with a cafe.
        /// </summary>
        [JsonProperty("department")]
        public Organization Department { get; set; }

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
    }
}