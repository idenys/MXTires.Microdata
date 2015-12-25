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
using Newtonsoft.Json;

namespace MXTires.Microdata.LocalBusinesses.FoodEstablishments
{
    /// <summary>
    /// A food-related business.
    /// </summary>
    public class FoodEstablishment : LocalBusiness
    {
        /// <summary>
        /// Boolean  or Text  or URL - Indicates whether a FoodEstablishment accepts reservations. 
        /// Values can be Boolean, a URL at which reservations can be made or (for backwards compatibility) the strings Yes or No.
        /// </summary>
        [JsonProperty("acceptsReservations")]
        public string AcceptsReservations { get; set; }

        /// <summary>
        /// Text  or URL - Either the actual menu or a URL of the menu.
        /// </summary>
        [JsonProperty("menu")]
        public string Menu { get; set; }

        /// <summary>
        /// Text - The cuisine of the restaurant.
        /// </summary>
        [JsonProperty("servesCuisine")]
        public string ServesCuisine { get; set; }
    }
}
