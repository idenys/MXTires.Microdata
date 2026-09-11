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
using MXTires.Microdata.CreativeWorks;
using MXTires.Microdata.Intangible.Enumeration;
using MXTires.Microdata.Intangible.StructuredValues;
using MXTires.Microdata.Validators;
using Newtonsoft.Json;

namespace MXTires.Microdata.Intangible
{
    /// <summary>
    /// A food or drink item listed in a menu or menu section.
    /// </summary>
    public class MenuItem : Thing
    {
        private object menuAddOn;
        /// <summary>
        /// MenuItem or MenuSection - Additional menu item(s) such as a side dish of salad or side order of fries that can be added to this menu item. Additionally it can be a menu section containing allowed add-on menu items for this menu item.
        /// </summary>
        [JsonProperty("menuAddOn")]
        public object MenuAddOn
        {
            get { return menuAddOn; }
            set
            {
                var validator = new TypeValidator(typeof(MenuItem), typeof(MenuSection));
                validator.Validate(value);
                menuAddOn = value;
            }
        }

        /// <summary>
        /// NutritionInformation - Nutrition information about the recipe or menu item.
        /// </summary>
        [JsonProperty("nutrition")]
        public NutritionInformation Nutrition { get; set; }

        /// <summary>
        /// Offer - An offer to provide this item—for example, an offer to sell a product, rent the DVD of a movie, perform a service, or give away tickets to an event.
        /// </summary>
        [JsonProperty("offers")]
        public object Offers { get; set; }

        /// <summary>
        /// RestrictedDiet - Indicates a dietary restriction or guideline for which this recipe or menu item is suitable, e.g. diabetic, halal etc.
        /// </summary>
        [JsonProperty("suitableForDiet")]
        public RestrictedDiet SuitableForDiet { get; set; }

    }
}
