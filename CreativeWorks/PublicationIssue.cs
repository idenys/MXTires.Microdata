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

using Newtonsoft.Json;

namespace MXTires.Microdata.CreativeWorks
{
    /// <summary>
    /// A part of a successively published publication such as a periodical or publication volume, often numbered, usually containing a grouping of works such as articles. 
    /// </summary>
    public class PublicationIssue : Thing
    {
        /// <summary>
        /// Integer  or Text - Identifies the issue of publication; for example, "iii" or "2".
        /// </summary>
        [JsonProperty("issueNumber")]
        public string IssueNumber { get; set; }

        /// <summary>
        /// Text  or Integer - The page on which the work ends; for example "138" or "xvi".
        /// </summary>
        [JsonProperty("pageEnd")]
        public string PageEnd { get; set; }

        /// <summary>
        /// Text  or Integer - The page on which the work starts; for example "135" or "xiii".
        /// </summary>
        [JsonProperty("pageStart")]
        public string PageStart { get; set; }

        /// <summary>
        /// Text - Any description of pages that is not separated into pageStart and pageEnd; for example, "1-6, 9, 55" or "10-12, 46-49".
        /// </summary>
        [JsonProperty("pagination")]
        public string Pagination { get; set; }
    }
}
