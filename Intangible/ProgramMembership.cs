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

using MXTires.Microdata.Validators;
using Newtonsoft.Json;
using System.Collections.Generic;
namespace MXTires.Microdata.Intangible
{
    /// <summary>
    /// Used to describe membership in a loyalty programs (e.g. "StarAliance"), traveler clubs (e.g. "AAA"), purchase clubs ("Safeway Club"), etc.
    /// </summary>
    public class ProgramMembership : Thing
    {
        /// <summary>
        /// Organization - The organization (airline, travelers' club, etc.) the membership is made with.
        /// </summary>
        /// <value>The hosting organization.</value>
        [JsonProperty("hostingOrganization")]
        public Organization HostingOrganization { get; set; }

        /// <summary>
        /// The member
        /// </summary>
        Thing member;
        /// <summary>
        /// Organization  or Person - A member of an Organization or a ProgramMembership.
        /// Organizations can be members of organizations; ProgramMembership is typically for individuals. 
        /// Supersedes <see cref="Members"/>, musicGroupMember.
        /// Inverse property: <see cref="MemberOf"/> .
        /// </summary>
        /// <value>The member.</value>
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

        /// <summary>
        /// The members
        /// </summary>
        List<Thing> members;
        /// <summary>
        /// Gets or sets the members.
        /// </summary>
        /// <value>The members.</value>
        [JsonProperty("members")]
        public List<Thing> Members
        {
            get { return members; }
            set
            {
                var validator = new TypeValidator(typeof(Organization), typeof(Person));
                foreach (var item in value)
                {
                    validator.Validate(item);
                }
                members = value;
            }
        }

        /// <summary>
        /// Text - A unique identifier for the membership.
        /// </summary>
        /// <value>The membership number.</value>
        [JsonProperty("membershipNumber")]
        public string MembershipNumber { get; set; }

        /// <summary>
        /// Text - The program providing the membership.
        /// </summary>
        /// <value>The name of the program.</value>
        [JsonProperty("programName")]
        public Organization ProgramName { get; set; }
    }
}