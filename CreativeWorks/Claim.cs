#region License
// Copyright (c) 2022 1010Tires.com
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
using System;
using System.Collections.Generic;

namespace MXTires.Microdata.CreativeWorks
{
    /// <summary>
    /// A Claim in Schema.org represents a specific, factually-oriented claim that could be the itemReviewed in a ClaimReview. The content of a claim can be summarized with the text property. Variations on well known claims can have their common identity indicated via sameAs links, and summarized with a name. Ideally, a Claim description includes enough contextual information to minimize the risk of ambiguity or inclarity. In practice, many claims are better understood in the context in which they appear or the interpretations provided by claim reviews.
    /// Beyond ClaimReview, the Claim type can be associated with related creative works - for example a ScholarlyArticle or Question might be about some Claim.
    /// At this time, Schema.org does not define any types of relationship between claims. This is a natural area for future exploration.
    /// </summary>
    public class Claim : CreativeWork
    {
        /// <summary>
        /// CreativeWork - Indicates an occurence of a Claim in some CreativeWork.
        /// </summary>
        [JsonProperty("appearance")]
        public CreativeWork Appearance { get; set; }

        object claimInterpreter;
        /// <summary>
        /// Organization or Person - For a Claim interpreted from MediaObject content sed to indicate a claim contained, 
        /// implied or refined from the content of a MediaObject.
        /// </summary>
        [JsonProperty("claimInterpreter")]
        public object ClaimInterpreter
        {
            get { return claimInterpreter; }
            set
            {
                var validator = new TypeValidator(new List<Type>() { typeof(Organization), typeof(Person) });
                validator.Validate(value);
                claimInterpreter = value;
            }
        }

        /// <summary>
        /// CreativeWork - Indicates the first known occurence of a Claim in some CreativeWork.
        /// </summary>
        [JsonProperty("firstAppearance")] public CreativeWork FirstAppearance { get; set; }
    }
}
