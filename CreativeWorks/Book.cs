﻿#region License
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
using MXTires.Microdata.Intangible.Enumeration;
using MXTires.Microdata.Validators;
using Newtonsoft.Json;

namespace MXTires.Microdata.CreativeWorks
{
    /// <summary>
    /// A book.
    /// </summary>
    public class Book : CreativeWork, MXTires.Microdata.CreativeWorks.IBook
    {
        /// <summary>
        /// Text - The edition of the book.
        /// </summary>
        [JsonProperty("bookEdition")]
        public string BookEdition { get; set; }

        /// <summary>
        /// BookFormatType - The format of the book.
        /// </summary>
        [JsonProperty("bookFormat")]
        public BookFormatType BookFormat { get; set; }

        /// <summary>
        /// Person - The illustrator of the book.
        /// </summary>
        [JsonProperty("illustrator")]
        public Person Illustrator { get; set; }

        /// <summary>
        /// Text - The ISBN of the book.
        /// </summary>
        [JsonProperty("isbn")]
        public string Isbn { get; set; }

        /// <summary>
        /// Integer - The number of pages in the book.
        /// </summary>
        [JsonProperty("numberOfPages")]
        public Int32? NumberOfPages { get; set; }
    }
}
