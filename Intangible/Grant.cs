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
using MXTires.Microdata.Validators;
using Newtonsoft.Json;

namespace MXTires.Microdata.Intangible
{
    /// <summary>
    /// A grant, typically financial, made to support a project, person, or organization.
    /// </summary>
    public class Grant : Thing
    {
        /// <summary>
        /// Thing - Indicates something directly or indirectly funded or sponsored through a Grant.
        /// </summary>
        [JsonProperty("fundedItem")]
        public Thing FundedItem { get; set; }

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
    }
}
