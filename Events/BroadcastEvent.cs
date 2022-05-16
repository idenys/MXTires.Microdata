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

using Newtonsoft.Json;

namespace MXTires.Microdata.Events
{
    /// <summary>
    /// An over the air or online broadcast event.
    /// </summary>
    public class BroadcastEvent : PublicationEvent
    {
        /// <summary>
        /// The event being broadcast such as a sporting event or awards ceremony.
        /// </summary>
        [JsonProperty("broadcastOfEvent")]
        public Event BroadcastOfEvent { get; set; }

        /// <summary>
        /// True if the broadcast is of a live event.
        /// </summary>
        [JsonProperty("isLiveBroadcast")]
        public bool IsLiveBroadcast { get; set; }

        /// <summary>
        /// Language or Text Languages in which subtitles/captions are available, in IETF BCP 47 standard format.
        /// </summary>
        [JsonProperty("subtitleLanguage")]
        public object SubtitleLanguage { get; set; }

        /// <summary>
        /// Text The type of screening or video broadcast used (e.g.IMAX, 3D, SD, HD, etc.).
        /// </summary>
        [JsonProperty("videoFormat")]
        public string VideoFormat { get; set; }
    }
}