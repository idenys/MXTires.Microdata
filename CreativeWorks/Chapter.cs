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
using System.Collections.Generic;
using MXTires.Microdata.Validators;
using Newtonsoft.Json;

namespace MXTires.Microdata.CreativeWorks
{
    /// <summary>
    /// Defined in the bib.schema.org extension. (This is an initial exploratory release.)
    /// Canonical URL: http://schema.org/Chapter
    /// One of the sections into which a book is divided. A chapter usually has a section number or a name.
    /// </summary>
    public class Chapter : CreativeWork
    {
        /// <summary>
        /// Integer  or Text - The page on which the work ends; for example "138" or "xvi".
        /// </summary>
        [JsonProperty("pageEnd")]
        public String PageEnd { get; set; }

        /// <summary>
        /// Integer  or Text - The page on which the work starts; for example "135" or "xiii".
        /// </summary>
        [JsonProperty("pageStart")]
        public String PageStart { get; set; }

        /// <summary>
        /// Text - Any description of pages that is not separated into pageStart and pageEnd; for example, "1-6, 9, 55" or "10-12, 46-49".
        /// </summary>
        [JsonProperty("pagination")]
        public String Pagination { get; set; }
    }
}
