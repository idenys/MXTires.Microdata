#region License
// Copyright (c) 2020 1010Tires.com
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

namespace MXTires.Microdata.Actions.CreateActions
{
    using MXTires.Microdata.Intangible;
    using Newtonsoft.Json;

    /// <summary>
    /// A food-related business.
    /// </summary>
    public class FoodEstablishment : LocalBusiness 
    {
        /// <summary>
        /// Boolean  or Text or URL Indicates whether a FoodEstablishment accepts reservations.
        /// Values can be Boolean, an URL at which reservations can be made or(for backwards compatibility) the strings Yes or No.
        /// </summary>
        [JsonProperty("acceptsReservations")]
        public object AcceptsReservations { get; set; }

        /// <summary>
        ///  Menu  or Text or URL - Either the actual menu as a structured representation, as text, or a URL of the menu. Supersedes <see cref="menu"/>.
        /// </summary>
        [JsonProperty("hasMenu")]
        public object HasMenu { get; set; }

        /// <summary>
        ///  Text - The cuisine of the restaurant.
        /// </summary>
        [JsonProperty("servesCuisine")]
        public string ServesCuisine { get; set; }

        /// <summary>
        /// Rating  An official rating for a lodging business or food establishment, e.g.from national associations or standards bodies. 
        /// Use the author property to indicate the rating organization, e.g. as an Organization with name such as (e.g.HOTREC, DEHOGA, WHR, or Hotelstars).
        /// </summary>
        [JsonProperty("starRating")]
        public Rating StarRating { get; set; }
    
    }
}
