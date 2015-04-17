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

using MXTires.Microdata.Events;
using MXTires.Microdata.Validators;
using Newtonsoft.Json;
using MXTires.Microdata.Actions.CreateActions;

namespace MXTires.Microdata
{
    /// <summary>
    /// The act of producing/preparing food.
    /// </summary>
    public class CookAction : CreateAction
    {
        Thing foodEstablishment;

        /// <summary>
        /// FoodEstablishment  or Place - A sub property of location. The specific food establishment where the action occurred.
        /// </summary>
        [JsonProperty("foodEstablishment")]
        public Thing FoodEstablishment
        {
            get { return foodEstablishment; }
            set
            {
                var validator = new TypeValidator(typeof(FoodEstablishment), typeof(Place));
                validator.Validate(value);
                foodEstablishment = value;
            }
        }

        /// <summary>
        /// FoodEvent - A sub property of location. The specific food event where the action occurred.
        /// </summary>
        [JsonProperty("foodEvent")]
        public FoodEvent FoodEvent { get; set; }

        /// <summary>
        /// Recipe - A sub property of instrument. The recipe/instructions used to perform the action.
        /// </summary>
        [JsonProperty("recipe")]
        public Recipe Recipe { get; set; }
    }
}