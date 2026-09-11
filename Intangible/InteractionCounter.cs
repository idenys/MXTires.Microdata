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
using Newtonsoft.Json;

namespace MXTires.Microdata.Intangible
{
    /// <summary>
    /// A summary of how users have interacted with this CreativeWork. In most cases, authors will use a subtype to specify the
    /// specific type of interaction.
    /// </summary>
    public class InteractionCounter : StructuredValue
    {
        /// <summary>
        /// Action - The Action representing the type of interaction. For up votes, +1s, etc. use LikeAction. For down votes use DislikeAction.
        /// </summary>
        [JsonProperty("interactionType")]
        public MXTires.Microdata.Action InteractionType { get; set; }

        /// <summary>
        /// Integer - The number of interactions for the CreativeWork using the WebSite or SoftwareApplication.
        /// </summary>
        [JsonProperty("userInteractionCount")]
        public Int32? UserInteractionCount { get; set; }

        /// <summary>
        /// DateTime - The startTime of the interaction period.
        /// </summary>
        [JsonProperty("startTime")]
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// DateTime - The endTime of the interaction period.
        /// </summary>
        [JsonProperty("endTime")]
        public DateTime? EndTime { get; set; }
    }
}
