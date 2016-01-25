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

using MXTires.Microdata.CreativeWorks;
using MXTires.Microdata.Intangible;
using MXTires.Microdata.Intangible.Quantities;
using MXTires.Microdata.Validators;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MXTires.Microdata
{
    /// <summary>
    /// An image, video, or audio object embedded in a web page. Note that a creative work may have many media objects associated with it on the same web page. For example, a page about a single song (MusicRecording) may have a music video (VideoObject), and a high and low bandwidth audio stream (2 AudioObject's).
    /// </summary>
    public class MediaObject : CreativeWork
    {
        /// <summary>
        /// NewsArticle 	A NewsArticle associated with the Media Object.
        /// </summary>
        [JsonProperty("associatedArticle")]
        public NewsArticle AssociatedArticle { get; set; }

        /// <summary>
        /// Text 	The bitrate of the media object.
        /// </summary>
        [JsonProperty("bitrate")]
        public string Bitrate { get; set; }

        /// <summary>
        /// Text 	File size in (mega/kilo) bytes.
        /// </summary>
        [JsonProperty("contentSize")]
        public string ContentSize { get; set; }

        /// <summary>
        /// URL 	Actual bytes of the media object, for example the image file or video file.
        /// </summary>
        [JsonProperty("contentUrl")]
        public string ContentUrl { get; set; }

        /// <summary>
        /// Duration 	The duration of the item (movie, audio recording, event, etc.) in ISO 8601 date format.
        /// </summary>
        [JsonProperty("duration")]
        public Duration Duration { get; set; }

        /// <summary>
        /// URL 	A URL pointing to a player for a specific video. In general, this is the information in the src element of an embed tag and should not be the same as the content of the loc tag.
        /// </summary>
        [JsonProperty("embedUrl")]
        public string EmbedUrl { get; set; }

        /// <summary>
        /// CreativeWork 	The CreativeWork encoded by this media object.
        /// </summary>
        [JsonProperty("encodesCreativeWork")]
        public CreativeWork EncodesCreativeWork { get; set; }

        /// <summary>
        /// Text 	mp3, mpeg4, etc.
        /// </summary>
        [JsonProperty("encodingFormat")]
        public string EncodingFormat { get; set; }

        /// <summary>
        /// Date 	Date the content expires and is no longer useful or available. Useful for videos.
        /// </summary>
        [JsonProperty("expires")]
        public string Expires { get; set; }

        Thing height;

        /// <summary>
        /// QuantitativeValue  or  Distance - The height of the item.
        /// </summary>
        [JsonProperty("height")]
        public Thing Height
        {
            get { return height; }
            set
            {
                var validator = new TypeValidator(typeof(QuantitativeValue), typeof(Distance));
                validator.Validate(value);
                height = value;
            }
        }

        /// <summary>
        /// Text 	Player type required—for example, Flash or Silverlight.
        /// </summary>
        [JsonProperty("playerType")]
        public string PlayerType { get; set; }

        /// <summary>
        /// Organization 	The production company or studio responsible for the item e.g. series, video game, episode etc.
        /// </summary>
        [JsonProperty("productionCompany")]
        public Organization ProductionCompany { get; set; }

        /// <summary>
        /// Place 	The regions where the media is allowed. If not specified, then it's assumed to be allowed everywhere. Specify the countries in ISO 3166 format.
        /// </summary>
        [JsonProperty("regionsAllowed")]
        public Place RegionsAllowed { get; set; }

        /// <summary>
        /// Boolean - Indicates if use of the media require a subscription (either paid or free). Allowed values are true or false (note that an earlier version had 'yes', 'no').
        /// </summary>
        [JsonProperty("requiresSubscription")]
        public Boolean? RequiresSubscription { get; set; }

        /// <summary>
        /// Date - Date when this media object was uploaded to this site.
        /// </summary>
        [JsonProperty("uploadDate")]
        public string UploadDate { get; set; }

        Thing width;
        /// <summary>
        ///  QuantitativeValue  or Distance - The width of the item.
        /// </summary>
        [JsonProperty("width")]
        public Thing Width
        {
            get { return width; }
            set
            {
                var validator = new TypeValidator(typeof(QuantitativeValue), typeof(Distance));
                validator.Validate(value);
                width = value;
            }
        }
    }
}
