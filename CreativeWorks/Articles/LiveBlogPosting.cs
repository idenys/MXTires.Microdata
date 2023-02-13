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

using Newtonsoft.Json;
using System;

namespace MXTires.Microdata.CreativeWorks.Articles
{
    public class LiveBlogPosting : BlogPosting
    {
        /// <summary>
        /// DateTime -The time when the live blog will stop covering the Event.Note that coverage may continue after the Event concludes.
        /// </summary>
        [JsonProperty("coverageEndTime")]
        public DateTime CoverageEndTime { get; set; }

        /// <summary>
        /// DateTime - The time when the live blog will begin covering the Event. Note that coverage may begin before the Event's start time. The LiveBlogPosting may also be created before coverage begins.
        /// </summary>
        [JsonProperty("coverageStartTime")]
        public DateTime CoverageStartTime { get; set; }

        /// <summary>
        /// BlogPosting An update to the LiveBlog.
        /// </summary>
        [JsonProperty("liveBlogUpdate")]
        public BlogPosting LiveBlogUpdate { get; set; }

    }
}
