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
namespace MXTires.Microdata.Intangible.Services
{
    /// <summary>
    /// A delivery service through which content is provided via broadcast over the air or online.
    /// </summary>
    public class BroadcastService : Service
    {
        /// <summary>
        /// Place -	The area within which users can expect to reach the broadcast service.
        /// </summary>
        [JsonProperty("area")]
        public Place Area { get; set; }

        /// <summary>
        /// Organization - The organization owning or operating the broadcast service.
        /// </summary>
        [JsonProperty("broadcaster")]
        public Organization Broadcaster { get; set; }

        /// <summary>
        /// Organization - The media network(s) whose content is broadcast on this station.
        /// </summary>
        [JsonProperty("broadcastAffiliateOf")]
        public Organization BroadcastAffiliateOf { get; set; }

        /// <summary>
        /// Text - The name displayed in the channel guide, e.g. "Cable 9".
        /// </summary>
        [JsonProperty("broadcastDisplayName")]
        public string BroadcastDisplayName { get; set; }

        /// <summary>
        /// BroadcastFrequencySpecification or Text - The frequency used for over-the-air broadcasts. Numeric values or simple ranges e.g. 87-99. In addition a shortcut idiom is supported for frequencies of AM and FM radio channels, e.g. "87 FM".
        /// </summary>
        [JsonProperty("broadcastFrequency")]
        public string BroadcastFrequency { get; set; }

        /// <summary>
        /// Text - The timezone in ISO 8601 format for which the service bases its broadcasts.
        /// </summary>
        [JsonProperty("broadcastTimezone")]
        public string BroadcastTimezone { get; set; }

        /// <summary>
        /// Text - A callsign, as used in broadcasting and radio communications to identify people, radio and TV stations, or vehicles.
        /// </summary>
        [JsonProperty("callSign")]
        public string CallSign { get; set; }

        /// <summary>
        /// BroadcastChannel - A broadcast channel of a broadcast service.
        /// </summary>
        [JsonProperty("hasBroadcastChannel")]
        public BroadcastChannel HasBroadcastChannel { get; set; }

        /// <summary>
        /// Language or Text - The language of the content or performance or used in an action.
        /// </summary>
        [JsonProperty("inLanguage")]
        public string InLanguage { get; set; }

        /// <summary>
        /// BroadcastService - A broadcast service to which the broadcast service may belong to such as regional variations of a national channel.
        /// </summary>
        [JsonProperty("parentService")]
        public BroadcastService ParentService { get; set; }

        /// <summary>
        /// Text - The type of screening or video broadcast used (e.g. IMAX, 3D, SD, HD, etc.).
        /// </summary>
        [JsonProperty("videoFormat")]
        public string VideoFormat { get; set; }
    }
}