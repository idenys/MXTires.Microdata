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

using System.Collections.Generic;
using MXTires.Microdata.Intangible.Quantities;
using MXTires.Microdata.Organizations.PerformingGroups;
using MXTires.Microdata.Places.AdministrativeAreas;
using MXTires.Microdata.Validators;
using Newtonsoft.Json;

namespace MXTires.Microdata.CreativeWorks
{
    /// <summary>
    /// A class, also often called a 'Type'; equivalent to rdfs:Movie.
    /// </summary>
    public class Movie : Thing
    {
        /// <summary>
        /// Person - An actor, e.g. in tv, radio, movie, video games etc. Actors can be associated with individual items or with a series, episode, clip. Supersedes <see cref="actors"/>.
        /// </summary>
        [JsonProperty("actor")]
        public Person Actor { get; set; }

        /// <summary>
        /// /// <summary>
        /// The actors, e.g. in tv, radio, movie, video games etc. Actors can be associated with individual items or with a series, episode, clip. Superseded by <see cref="actor"/>.
        /// </summary>
        /// </summary>
        [JsonProperty("actors")]
        public IList<Person> Actors { get; set; }

        /// <summary>
        /// Country - The country of the principal offices of the production company or individual responsible for the movie or program.
        /// </summary>
        [JsonProperty("countryOfOrigin")]
        public Country CountryOfOrigin { get; set; }

        /// <summary>
        /// Person - A director of e.g. tv, radio, movie, video games etc. content. Directors can be associated with individual items or with a series, episode, clip. Supersedes <see cref="directors"/>.
        /// </summary>
        [JsonProperty("director")]
        public Person Director { get; set; }

        /// <summary>
        /// /// <summary>
        /// The directors of e.g. tv, radio, movie, video games etc. content. Directors can be associated with individual items or with a series, episode, clip. Superseded by <see cref="directors"/>.
        /// </summary>
        /// </summary>
        [JsonProperty("directors")]
        public IList<Person> Directors { get; set; }

        /// <summary>
        /// Duration - The duration of the item (movie, audio recording, event, etc.) in ISO 8601 date format.
        /// </summary>
        [JsonProperty("duration")]
        public Duration Duration { get; set; }

        Thing musicBy;
        /// <summary>
        /// MusicGroup  or Person - The composer of the soundtrack.
        /// </summary>
        /// <value>MusicGroup  or Person - The composer of the soundtrack.</value>
        [JsonProperty("musicBy")]
        public Thing MusicBy
        {
            get { return musicBy; }
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
        public Organization ProductionCompany { get; set; }

        object subtitleLanguage;
        /// <summary>
        /// Text  or Language - Languages in which subtitles/captions are available, in IETF BCP 47 standard format.
        /// </summary>
        [JsonProperty("subtitleLanguage")]
        public object SubtitleLanguage
        {
            get { return subtitleLanguage; }
            set
            {
                var validator = new TypeValidator(typeof(string), typeof(Language));
                validator.Validate(value);
                subtitleLanguage = value;
            }
        }

        /// <summary>
        /// VideoObject - The trailer of a movie or tv/radio series, season, episode, etc.
        /// </summary>
        [JsonProperty("trailer")]
        public VideoObject Trailer { get; set; }
    }
}
