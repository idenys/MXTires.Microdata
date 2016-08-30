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

using System.Collections.Generic;
using MXTires.Microdata.CreativeWorks;
using MXTires.Microdata.Organizations.PerformingGroups;
using MXTires.Microdata.Validators;
using Newtonsoft.Json;
namespace MXTires.Microdata
{
	/// <summary>
	/// Class VideoObject.
	/// </summary>
	public class VideoObject : MediaObject
	{
		/// <summary>
		/// Person - An actor, e.g. in tv, radio, movie, video games etc. Actors can be associated with individual items or with a series, episode, clip. Supersedes <see cref="Actors"/>.
		/// </summary>
		[JsonProperty("actor")]
        public Person Actor { get; set; }

        /// <summary>
        /// An actor, e.g. in tv, radio, movie, video games etc. Actors can be associated with individual items or with a series, episode, clip. Supersedes by <see cref="Actor"/>.
        /// </summary>
        [JsonProperty("actors")]
        public IList<Person> Actors { get; set; }

		/// <summary>
		/// Text - The caption for this object.
		/// </summary>
		[JsonProperty("caption")]
        public string Caption { get; set; }

		/// <summary>
		/// Person - A director of e.g. tv, radio, movie, video games etc. content. Directors can be associated with individual items or with a series, episode, clip. Supersedes <see cref="Directors"/>.
		/// </summary>
		[JsonProperty("director")]
        public Person Director { get; set; }

        /// <summary>
        /// A director of e.g. tv, radio, movie, video games etc. content. Directors can be associated with individual items or with a series, episode, clip. Supersedes by <see cref="Actor"/>.
        /// </summary>
        [JsonProperty("directors")]
        public IList<Person> Directors { get; set; }

		Thing musicBy;
		/// <summary>
		/// MusicGroup  or Person - The composer of the soundtrack.
		/// </summary>
		/// <value>MusicGroup  or Person - The composer of the soundtrack.</value>
		[JsonProperty("musicBy")]
		public Thing MusicBy
		{
			get
			{
				return musicBy;
			}
			set
			{
				var validator = new TypeValidator(typeof(MusicGroup), typeof(Person));
				validator.Validate(value);
				musicBy = value;
			}
		}

		/// <summary>
		/// ImageObject -Thumbnail image for an image or video.
		/// </summary>
		[JsonProperty("thumbnail")]
		public ImageObject Thumbnail
		{
			get; set;
		}

		/// <summary>
		/// Text - If this MediaObject is an AudioObject or VideoObject, the transcript of that object.
		/// </summary>
		[JsonProperty("transcript")]
		public string Transcript
		{
			get; set;
		}

		/// <summary>
		/// Text - The frame size of the video.
		/// </summary>
		[JsonProperty("videoFrameSize")]
		public string VideoFrameSize
		{
			get; set;
		}

		/// <summary>
		/// Text - The quality of the video.
		/// </summary>
		[JsonProperty("videoQuality")]
		public string VideoQuality
		{
			get; set;
		}
	}
}
