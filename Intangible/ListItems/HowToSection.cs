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

namespace MXTires.Microdata.Intangible.ListItems
{
    using System;
    using System.Collections.Generic;
    using MXTires.Microdata.Validators;
    using Newtonsoft.Json;

    /// <summary>
    /// A sub-grouping of steps in the instructions for how to achieve a result (e.g. steps for making a pie crust within a pie recipe).
    /// </summary>
    public class HowToSection : ItemList 
    {
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
                TypeValidator validator = new TypeValidator(new List<Type>(new Type[] { typeof(CreativeWork), typeof(ItemList), typeof(string) }));
                validator.Validate(value);
                this.steps = value;
            }
        }
    }
}
