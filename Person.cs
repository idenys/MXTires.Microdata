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
        public  string Email { get; set; }

        /// <summary>
        /// Gets or sets the birth date.
        /// </summary>
        /// <value>The birth date.</value>
        [JsonProperty("birthDate")]
        public  DateTime BirthDate { get; set; }

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
        [JsonProperty("email")]
        public  string Biography { get; set; }

        /// <summary>
        /// Gets or sets the organization.
        /// </summary>
        /// <value>The organization.</value>
        [JsonProperty("worksFor")]
        public Organization Organization { get; set; }

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
        /// <value>The brand.</value>
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
        /// The home location
        /// </summary>
        private Thing homeLocation;

        /// <summary>
        /// A contact location for a person's residence.
        /// </summary>
        /// <value>The brand.</value>
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
    }
}
