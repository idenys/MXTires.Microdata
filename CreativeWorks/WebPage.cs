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
using MXTires.Microdata.Intangible;
using MXTires.Microdata.Intangible.Enumeration;
using MXTires.Microdata.Validators;
using Newtonsoft.Json;

namespace MXTires.Microdata.CreativeWorks
{
    /// <summary>
    /// A web page. Every web page is implicitly assumed to be declared to be of type WebPage, so the various properties about that webpage, 
    /// such as breadcrumb may be used. We recommend explicit declaration if these properties are specified, but if they are found outside of an itemscope, 
    /// they will be assumed to be about the page.
    /// </summary>
    public class WebPage : CreativeWork
    {
        object breadcrumb;
        /// <summary>
        /// Text or BreadcrumbList - A set of links that can help a user understand and navigate a website hierarchy.
        /// </summary>
        [JsonProperty("breadcrumb")]
        public object Breadcrumb
        {
            get { return breadcrumb; }
            set
            {
                var validator = new TypeValidator(typeof(String), typeof(BreadcrumbList));
                validator.Validate(value);
                breadcrumb = value;
            }
        }
        /// <summary>
        /// Date - Date on which the content on this web page was last reviewed for accuracy and/or completeness.
        /// </summary>
        [JsonProperty("lastReviewed")]
        public DateTime? LastReviewed { get; set; }

        /// <summary>
        /// WebPageElement - Indicates if this web page element is the main subject of the page.
        /// </summary>
        [JsonProperty("mainContentOfPage")]
        public WebPageElement MainContentOfPage { get; set; }

        /// <summary>
        /// ImageObject - Indicates the main image on the page.
        /// </summary>
        [JsonProperty("primaryImageOfPage")]
        public ImageObject PrimaryImageOfPage { get; set; }

        /// <summary>
        /// URL - A link related to this web page, for example to other related web pages.
        /// </summary>
        [JsonProperty("relatedLink")]
        public string RelatedLink { get; set; }

        Thing reviewedBy;
        /// <summary>
        /// Person  or Organization - People or organizations that have reviewed the content on this web page for accuracy and/or completeness.
        /// </summary>
        [JsonProperty("reviewedBy")]
        public Thing ReviewedBy
        {
            get { return reviewedBy; }
            set
            {
                var validator = new TypeValidator(typeof(Person), typeof(Organization));
                validator.Validate(value);
                reviewedBy = value;
            }
        }

        /// <summary>
        /// URL - One of the more significant URLs on the page. Typically, these are the non-navigation links that are clicked on the most. Supersedes significantLinks.
        /// </summary>
        [JsonProperty("significantLink")]
        public string SignificantLink { get; set; }

        /// <summary>
        /// Collection of URL - Significant URLs on the page. Typically, these are the non-navigation links that are clicked on the most.
        /// </summary>
        [JsonProperty("significantLinks")]
        public List<string> SignificantLinks { get; set; }

        /// <summary>
        /// Specialty - One of the domain specialities to which this web page's content applies.
        /// </summary>
        [JsonProperty("specialty")]
        public Specialty? Specialty { get; set; }
    }
}