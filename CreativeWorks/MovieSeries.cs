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

using System;
using System.Collections.Generic;
using MXTires.Microdata.Validators;
using Newtonsoft.Json;
using MXTires.Microdata.Organizations.PerformingGroups;

namespace MXTires.Microdata.CreativeWorks
{
	/// <summary>
	/// A series of movies. Included movies can be indicated with the hasPart property.
	/// </summary>
	/// <seealso cref="MXTires.Microdata.CreativeWorks.CreativeWorkSeries" />
	public class MovieSeries : CreativeWorkSeries
	{
		/// <summary>
		/// Person - An actor, e.g. in tv, radio, movie, video games etc. Actors can be associated with individual items or with a series, episode, clip. Supersedes <see cref="Actors"/>.
		/// </summary>
		[JsonProperty("actor")]
		public Person Actor
		{
			get; set;
		}

		/// <summary>
		/// Person - A director of e.g. tv, radio, movie, video games etc. content. Directors can be associated with individual items or with a series, episode, clip. Supersedes <see cref="Directors"/>.
		/// </summary>
		[JsonProperty("director")]
		public Person Director
		{
			get; set;
		}

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
		/// Organization - The production company or studio responsible for the item e.g. series, video game, episode etc.
		/// </summary>
		[JsonProperty("productionCompany")]
		public Organization ProductionCompany
		{
			get; set;
		}

		/// <summary>
		/// VideoObject - The trailer of a movie or tv/radio series, season, episode, etc.
		/// </summary>
		[JsonProperty("trailer")]
		public VideoObject Trailer
		{
			get; set;
		}
	}
}
