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
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MXTires.Microdata.Validators;
using Newtonsoft.Json;

namespace MXTires.Microdata.Places
{
    /// <summary>
    /// A tourist attraction. In principle any Thing can be a TouristAttraction, from a Mountain and LandmarksOrHistoricalBuildings to a LocalBusiness. 
    /// This Type can be used on its own to describe a general TourstAttraction, or be used as an additionalType to add tourist attraction properties 
    /// to any other type.
    /// </summary>
    public class TouristAttraction : Place
    {
        object availableLanguage;
        /// <summary>
        /// Language  or Text - A language someone may use with or at the item, service or place. 
        /// Please use one of the language codes from the IETF BCP 47 standard. See also inLanguage
        /// </summary>
        [JsonProperty("availableLanguage")]
        public object AvailableLanguage
        {
            get { return availableLanguage; }
            set
            {
                var validator = new TypeValidator(typeof(Language), typeof(string));
                validator.Validate(value);
                availableLanguage = value;
            }
        }

        /// <summary>
        /// Audience  or Text - Attraction suitable for type(s) of tourist. eg. Children, visitors from a particular country, etc.
        /// </summary>
        [JsonProperty("touristType")]
        public object TouristType { get; set; }
    }
}
