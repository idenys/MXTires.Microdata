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

namespace MXTires.Microdata.CreativeWorks
{
    using System;
    using System.Collections.Generic;
    using MXTires.Microdata.Intangible;
    using MXTires.Microdata.Intangible.ListItems;
    using MXTires.Microdata.Intangible.Quantities;
    using MXTires.Microdata.Intangible.StructuredValues;
    using MXTires.Microdata.Validators;
    using Newtonsoft.Json;

    /// <summary>
    /// Instructions that explain how to achieve a result by performing a sequence of steps.
    /// </summary>
    public class HowTo : CreativeWork
    {
        private object estimatedCost;
        /// <summary>
        /// MonetaryAmount  or Text - The estimated cost of the supply or supplies consumed when performing instructions.
        /// </summary>
        [JsonProperty("estimatedCost")]
        public object EstimatedCost
        {
            get { return this.estimatedCost; }
            set
            {
                TypeValidator validator = new TypeValidator(typeof(MonetaryAmount), typeof(string));
                validator.Validate(value);
                this.estimatedCost = value;
            }
        }

        /// <summary>
        /// Duration - The length of time it takes to perform instructions or a direction (not including time to prepare the supplies), in ISO 8601 duration format.
        /// </summary>
        [JsonProperty("performTime")]
        public Duration PerformTime { get; set; }

        /// <summary>
        /// Duration - The length of time it takes to prepare the items to be used in instructions or a direction, in ISO 8601 duration format.
        /// </summary>
        [JsonProperty("prepTime")]
        public Duration PrepTime { get; set; }

        private object steps;
        /// <summary>
        /// CreativeWork  or ItemList  or Text - The steps in the form of a single item (text, document, video, etc.) 
        /// or an ordered list with HowToStep and/or HowToSection items.
        /// </summary>
        [JsonProperty("steps")]
        public object Steps
        {
            get { return this.steps; }
            set
            {
                TypeValidator validator = new TypeValidator(new List<Type>(new Type[] { typeof(CreativeWork), typeof(ItemList), typeof(string)}));
                validator.Validate(value);
                this.steps = value;
            }
        }

        private object supply;
        /// <summary>
        /// HowToSupply  or Text - A sub-property of instrument. A supply consumed when performing instructions or a direction.
        /// </summary>
        [JsonProperty("supply")]
        public object Supply
        {
            get { return this.supply; }
            set
            {
                TypeValidator validator = new TypeValidator(typeof(HowToSupply), typeof(string));
                validator.Validate(value);
                this.supply = value;
            }
        }

        private object tool;
        /// <summary>
        /// HowToTool  or Text 	A sub property of instrument. An object used (but not consumed) when performing instructions or a direction.
        /// </summary>
        [JsonProperty("tool")]
        public object Tool
        {
            get { return this.tool; }
            set
            {
                TypeValidator validator = new TypeValidator(typeof(HowToTool), typeof(string));
                validator.Validate(value);
                this.tool = value;
            }
        }

        /// <summary>
        /// Duration - The total time required to perform instructions or a direction (including time to prepare the supplies), in ISO 8601 duration format.
        /// </summary>
        [JsonProperty("totalTime")]
        public Duration TotalTime { get; set; }

        private object yield;
        /// <summary>
        /// QuantitativeValue  or Text - The quantity that results by performing instructions. For example, a paper airplane, 10 personalized candles.
        /// </summary>
        [JsonProperty("yield")]
        public object Yield
        {
            get { return this.yield; }
            set
            {
                TypeValidator validator = new TypeValidator(typeof(QuantitativeValue), typeof(string));
                validator.Validate(value);
                this.yield = value;
            }
        }
    }
}
