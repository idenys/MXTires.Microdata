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

using MXTires.Microdata.Intangible;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MXTires.Microdata
{
    /// <summary>
    /// A review of an item - for example, of a restaurant, movie, or store.
    /// </summary>
    public class Review : CreativeWork
    {
        /// <summary>
        /// Thing 	The item that is being reviewed/rated.
        /// </summary>
        [JsonProperty("itemReviewed")]
        public Thing ItemReviewed { get; set; }

        /// <summary>
        /// Text - The actual body of the review.
        /// </summary>
        [JsonProperty("reviewBody")]
        public string ReviewBody { get; set; }

        /// <summary>
        /// Rating 	The rating given in this review. Note that reviews can themselves be rated. 
        /// The reviewRating applies to rating given by the review. The aggregateRating property applies to the review itself, as a creative work.
        /// </summary>
        [JsonProperty("reviewRating")]
        public Rating ReviewRating { get; set; }
    }
}
