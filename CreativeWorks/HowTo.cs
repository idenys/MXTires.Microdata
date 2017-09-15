#region License
// Copyright (c) 2017 1010Tires.com
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
using MXTires.Microdata.Intangible.Quantities;
using Newtonsoft.Json;

namespace MXTires.Microdata.CreativeWorks
{
    /// <summary>
    /// Instructions that explain how to achieve a result by performing a sequence of steps.
    /// </summary>
    public class HowTo : CreativeWork
    {
        /// <summary>
        /// MonetaryAmount  or Text - The estimated cost of the supply or supplies consumed when performing instructions.
        /// </summary>
        [JsonProperty("estimatedCost")]
        public object EstimatedCost { get; set; }

        /// <summary>
        /// Duration - The length of time it takes to perform instructions or a direction (not including time to prepare the supplies), in ISO 8601 duration format.
        /// </summary>
        [JsonProperty("performTime")]
        public Duration PerformTime { get; set; }

        /// <summary>
        /// Duration 	The length of time it takes to prepare the items to be used in instructions or a direction, in ISO 8601 duration format.
        /// </summary>
        [JsonProperty("prepTime")]
        public Duration PrepTime { get; set; }

        /// <summary>
        /// CreativeWork  or ItemList  or Text -	The steps in the form of a single item (text, document, video, etc.) or an ordered list with HowToStep and/or HowToSection items.
        /// </summary>
        [JsonProperty("steps")]
        public object Steps { get; set; }

        /// <summary>
        /// HowToSupply  or Text - A sub-property of instrument. A supply consumed when performing instructions or a direction.
        /// </summary>
        [JsonProperty("supply")]
        public object Supply { get; set; }

        /// <summary>
        /// HowToTool  or Text 	A sub property of instrument. An object used (but not consumed) when performing instructions or a direction.
        /// </summary>
        [JsonProperty("tool")]
        public object Tool { get; set; }

        /// <summary>
        /// Duration - The total time required to perform instructions or a direction (including time to prepare the supplies), in ISO 8601 duration format.
        /// </summary>
        [JsonProperty("totalTime")]
        public Duration TotalTime { get; set; }

        /// <summary>
        /// QuantitativeValue  or Text - The quantity that results by performing instructions. For example, a paper airplane, 10 personalized candles.
        /// </summary>
        [JsonProperty("yield")]
        public object Yield { get; set; }
    }
}
