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

using System.Collections.Generic;
using Newtonsoft.Json;

namespace MXTires.Microdata.Intangible
{
    /// <summary>
    /// A MemberProgram defines a loyalty (or membership) program that provides its members with certain benefits,
    /// for example better pricing, free shipping or returns, or the ability to earn loyalty points.
    /// </summary>
    public class MemberProgram : Thing
    {
        /// <summary>
        /// Organization - The Organization (airline, travelers' club, retailer, etc.) the membership is made with or which offers the MemberProgram.
        /// </summary>
        [JsonProperty("hostingOrganization")]
        public Organization HostingOrganization { get; set; }

        /// <summary>
        /// MemberProgramTier - The tiers of a member program.
        /// </summary>
        [JsonProperty("hasTiers")]
        public IList<MemberProgramTier> HasTiers { get; set; }
    }
}
