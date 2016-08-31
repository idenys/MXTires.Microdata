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
using MXTires.Microdata.Intangible.Quantities;
using Newtonsoft.Json;

namespace MXTires.Microdata.Intangible.StructuredValues
{
    /// <summary>
    /// Nutritional information about the recipe.
    /// </summary>
    public class NutritionInformation : StructuredValue
    {

        /// <summary>
        /// Energy - The number of calories.
        /// </summary>
        [JsonProperty("calories")]
        public Energy Calories { get; set; }

        /// <summary>
        /// Mass - The number of grams of carbohydrates.
        /// </summary>
        [JsonProperty("carbohydrateContent")]
        public Mass CarbohydrateContent { get; set; }

        /// <summary>
        /// Mass - The number of milligrams of cholesterol.
        /// </summary>
        [JsonProperty("cholesterolContent")]
        public Mass CholesterolContent { get; set; }

        /// <summary>
        /// Mass - The number of grams of fat.
        /// </summary>
        [JsonProperty("fatContent")]
        public Mass FatContent { get; set; }

        /// <summary>
        /// Mass - The number of grams of fiber.
        /// </summary>
        [JsonProperty("fiberContent")]
        public Mass FiberContent { get; set; }

        /// <summary>
        /// Mass - The number of grams of protein.
        /// </summary>
        [JsonProperty("proteinContent")]
        public Mass ProteinContent { get; set; }

        /// <summary>
        /// Mass - The number of grams of saturated fat.
        /// </summary>
        [JsonProperty("saturatedFatContent")]
        public Mass SaturatedFatContent { get; set; }

        /// <summary>
        /// Text - The serving size, in terms of the number of volume or mass.
        /// </summary>
        [JsonProperty("servingSize")]
        public String ServingSize { get; set; }

        /// <summary>
        /// Mass - The number of milligrams of sodium.
        /// </summary>
        [JsonProperty("sodiumContent")]
        public Mass SodiumContent { get; set; }

        /// <summary>
        /// Mass - The number of grams of sugar.
        /// </summary>
        [JsonProperty("occupancy")]
        public Mass SugarContent { get; set; }

        /// <summary>
        /// Mass - The number of grams of trans fat.
        /// </summary>
        [JsonProperty("transFatContent")]
        public Mass TransFatContent { get; set; }

        /// <summary>
        /// Mass - The number of grams of unsaturated fat.
        /// </summary>
        [JsonProperty("unsaturatedFatContent")]
        public Mass UnsaturatedFatContent { get; set; }
    }
}
