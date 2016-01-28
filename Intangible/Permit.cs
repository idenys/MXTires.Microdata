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
using System.Collections.Generic;
using MXTires.Microdata.Intangible.Quantities;
using MXTires.Microdata.Validators;
using Newtonsoft.Json;

namespace MXTires.Microdata.Intangible
{
    /// <summary>
    /// A permit issued by an organization, e.g. a parking pass.
    /// </summary>
    public class Permit : Thing
    {
        /// <summary>
        /// Organization - The organization issuing the ticket or permit.
        /// </summary>
        [JsonProperty("issuedBy")]
        public Organization IssuedBy { get; set; }

        /// <summary>
        /// Service - The service through with the permit was granted.
        /// </summary>
        [JsonProperty("issuedThrough")]
        public Service IssuedThrough { get; set; }

        /// <summary>
        /// Audience - The target audience for this permit.
        /// </summary>
        [JsonProperty("permitAudience")]
        public Audience PermitAudience { get; set; }

        /// <summary>
        /// Duration - The time validity of the permit.
        /// </summary>
        [JsonProperty("validFor")]
        public Duration ValidFor { get; set; }

        /// <summary>
        /// DateTime - The date when the item becomes valid.
        /// </summary>
        [JsonProperty("validFrom")]
        public DateTime? ValidFrom { get; set; }

        /// <summary>
        /// AdministrativeArea - The geographic area where the permit is valid.
        /// </summary>
        [JsonProperty("validIn")]
        public AdministrativeArea ValidIn { get; set; }

        /// <summary>
        /// Date - The date when the item is no longer valid.
        /// </summary>
        [JsonProperty("validUntil")]
        public DateTime? ValidUntil { get; set; }
    }
}
