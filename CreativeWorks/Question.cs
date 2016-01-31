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
    /// Class Question.
    /// </summary>
    public class Question : CreativeWork
    {
        /// <summary>
        /// Answer 	The answer that has been accepted as best, typically on a Question/Answer site. Sites vary in their selection mechanisms, e.g. drawing on community opinion and/or the view of the Question author.
        /// </summary>
        /// <value>The accepted answer.</value>
        [JsonProperty("acceptedAnswer")]
        public Answer AcceptedAnswer { get; set; }

        /// <summary>
        /// Integer 	The number of answers this question has received.
        /// </summary>
        /// <value>The answer count.</value>
        [JsonProperty("answerCount")]
        public Int32? AnswerCount { get; set; }

        /// <summary>
        /// Integer 	The number of downvotes this question has received from the community.
        /// </summary>
        /// <value>The downvote count.</value>
        [JsonProperty("downvoteCount")]
        public Int32? DownvoteCount { get; set; }

        /// <summary>
        /// Answer 	An answer (possibly one of several, possibly incorrect) to a Question, e.g. on a Question/Answer site.
        /// </summary>
        /// <value>The suggested answer.</value>
        [JsonProperty("suggestedAnswer")]
        public Answer SuggestedAnswer { get; set; }

        /// <summary>
        /// Integer 	The number of upvotes this question has received from the community.
        /// </summary>
        /// <value>The upvote count.</value>
        [JsonProperty("upvoteCount")]
        public Int32? UpvoteCount { get; set; }
    }
}