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
using Newtonsoft.Json;
namespace MXTires.Microdata
{
    /// <summary>
    /// A comment on an item - for example, a comment on a blog post. The comment's content is expressed via the "text" property, and its topic via "about", properties shared with all CreativeWorks.
    /// </summary>
    public class Comment : CreativeWork
    {
        /// <summary>
        /// Integer - The number of downvotes this question has received from the community.
        /// </summary>
        [JsonProperty("downvoteCount")]
        public Int32? DownvoteCount { get; set; }
        
        /// <summary>
        ///	Question - The parent of a question, answer or item in general.
        /// </summary>
        [JsonProperty("parentItem")]
        public Question ParentItem { get; set; }

        /// <summary>
        /// Integer - The number of upvotes this question has received from the community.
        /// </summary>
        [JsonProperty("upvoteCount")]
        public Int32? UpvoteCount { get; set; }
    }
}