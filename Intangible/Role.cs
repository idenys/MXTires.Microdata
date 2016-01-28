#region License
// Copyright (c) 2016 1010Tires.com
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
using Newtonsoft.Json;

namespace MXTires.Microdata.Intangible
{
    /// <summary>
    /// Represents additional information about a relationship or property. 
    /// For example a Role can be used to say that a 'member' role linking some SportsTeam to a player occurred during a particular time period. 
    /// Or that a Person's 'actor' role in a Movie was for some particular characterName. 
    /// Such properties can be attached to a Role entity, which is then associated with the main entities using ordinary properties like 'member' or 'actor'. 
    /// </summary>
    public class Role : Thing
    {
        /// <summary>
        /// Date  - The end date and time of the item (in ISO 8601 date format).
        /// </summary>
        [JsonProperty("endDate")]
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// URL  or Text - A role played, performed or filled by a person or organization. 
        /// For example, the team of creators for a comic book might fill the roles named 'inker', 'penciller', and 'letterer'; 
        /// or an athlete in a SportsTeam might play in the position named 'Quarterback'. 
        /// Supersedes namedPosition.
        /// </summary>
        [JsonProperty("roleName")]
        public String RoleName { get; set; }

        /// <summary>
        /// Date - The start date and time of the item (in ISO 8601 date format).
        /// </summary>
        [JsonProperty("startDate")]
        public DateTime? StartDate { get; set; }
    }
}
