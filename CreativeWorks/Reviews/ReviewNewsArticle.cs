#region License
// Copyright (c) 2023 1010Tires.com
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
using MXTires.Microdata.Intangible;
using MXTires.Microdata.Validators;
using Newtonsoft.Json;
using MXTires.Microdata.CreativeWorks;
using MXTires.Microdata.CreativeWorks.Articles;

namespace MXTires.Microdata.CreativeWorks.Reviews
{
    /// <summary>
    /// A NewsArticle and CriticReview providing a professional critic's assessment of a service, product, performance, or artistic or literary work.
    /// Canonical URL: https://schema.org/ReviewNewsArticle
    /// </summary>
    public class ReviewNewsArticle : Review, INewsArticle
    {
        #region Properties from NewsArticle
        /// <summary>
        /// Text 	The location where the NewsArticle was produced.
        /// </summary>
        [JsonProperty("dateline")]
        public String Dateline { get; set; }

        /// <summary>
        /// Text 	The number of the column in which the NewsArticle appears in the print edition.
        /// </summary>
        [JsonProperty("printColumn")]
        public String PrintColumn { get; set; }

        /// <summary>
        /// Text 	The edition of the print product in which the NewsArticle appears.
        /// </summary>
        [JsonProperty("printEdition")]
        public String PrintEdition { get; set; }

        /// <summary>
        /// Text 	If this NewsArticle appears in print, this field indicates the name of the page on which the article is found. Please note that this field is intended for the exact page name (e.g. A5, B18).
        /// </summary>
        [JsonProperty("printPage")]
        public String PrintPage { get; set; }

        /// <summary>
        /// Text 	If this NewsArticle appears in print, this field indicates the print section in which the article appeared.
        /// </summary>
        [JsonProperty("printSection")]
        public String PrintSection { get; set; }

        #endregion
    }
}
