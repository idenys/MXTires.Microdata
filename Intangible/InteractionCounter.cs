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
using MXTires.Microdata.Validators;
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

        private object interactionService;
        /// <summary>
        /// SoftwareApplication or WebSite - The WebSite or SoftwareApplication where the interactions took place.
        /// </summary>
        [JsonProperty("interactionService")]
        public object InteractionService
        {
            get { return interactionService; }
            set
            {
                var validator = new TypeValidator(typeof(SoftwareApplication), typeof(WebSite));
                validator.Validate(value);
                interactionService = value;
            }
        }

        private object location;
        /// <summary>
        /// Place, PostalAddress, Text, or VirtualLocation - The location of, for example, where an event is happening, where an organization is located, or where an action takes place.
        /// </summary>
        [JsonProperty("location")]
        public object Location
        {
            get { return location; }
            set
            {
                var validator = new TypeValidator(new List<Type> { typeof(Place), typeof(PostalAddress), typeof(string), typeof(VirtualLocation) });
                validator.Validate(value);
                location = value;
            }
        }

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
