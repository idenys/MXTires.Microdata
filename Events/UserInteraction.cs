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

using MXTires.Microdata.Validators;
using Newtonsoft.Json;
namespace MXTires.Microdata.Events
{
    /// <summary>
    /// A user interacting with a page.
    /// </summary>
    public class UserInteraction : Event
    {
    }

    /// <summary>
    /// Class UserBlocks.
    /// </summary>
    public class UserBlocks : UserInteraction
    {
    }
    /// <summary>
    /// Class UserCheckins.
    /// </summary>
    public class UserCheckins : UserInteraction
    {
    }

    /// <summary>
    /// The UserInteraction event in which a user comments on an item.
    /// </summary>
    public class UserComments : UserInteraction
    {
        /// <summary>
        /// Text - The text of the UserComment.
        /// </summary>
        [JsonProperty("commentText")]
        public string CommentText { get; set; }

        /// <summary>
        /// Date - The time at which the UserComment was made.
        /// </summary>
        [JsonProperty("commentTime")]
        public string CommentTime { get; set; }

        Thing creator;
        /// <summary>
        /// Person  or Organization - The creator/author of this CreativeWork or UserComments. This is the same as the Author property for CreativeWork.
        /// </summary>
        [JsonProperty("creator")]
        public Thing Creator
        {
            get { return creator; }
            set
            {
                var validator = new TypeValidator(typeof(Organization), typeof(Person));
                validator.Validate(value);
                creator = value;
            }
        }

        /// <summary>
        /// CreativeWork - Specifies the CreativeWork associated with the UserComment.
        /// </summary>
        [JsonProperty("discusses")]
        public CreativeWork Discusses { get; set; }

        /// <summary>
        /// URL - The URL at which a reply may be posted to the specified UserComment.
        /// </summary>
        [JsonProperty("replyToUrl")]
        public string ReplyToUrl { get; set; }
    }

    /// <summary>
    /// Class UserDownloads.
    /// </summary>
    public class UserDownloads : UserInteraction
    {
    }
    /// <summary>
    /// Class UserLikes.
    /// </summary>
    public class UserLikes : UserInteraction
    {
    }
    /// <summary>
    /// Class UserPageVisits.
    /// </summary>
    public class UserPageVisits : UserInteraction
    {
    }
    /// <summary>
    /// Class UserPlays.
    /// </summary>
    public class UserPlays : UserInteraction
    {
    }
    /// <summary>
    /// Class UserPlusOnes.
    /// </summary>
    public class UserPlusOnes : UserInteraction
    {
    }
    /// <summary>
    /// Class UserTweets.
    /// </summary>
    public class UserTweets : UserInteraction
    {
    }
}