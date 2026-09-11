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
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MXTires.Microdata.CreativeWorks;
using MXTires.Microdata.CreativeWorks.MusicPlaylists;
using MXTires.Microdata.Intangible;
using MXTires.Microdata.Validators;
using Newtonsoft.Json;

namespace MXTires.Microdata.Organizations.PerformingGroups
{
    /// <summary>
    /// A musical group, such as a band, an orchestra, or a choir. Can also be a solo musician.
    /// </summary>
    public class MusicGroup : PerformingGroup
    {
        /// <summary>
        /// MusicAlbum - A music album.
        /// </summary>
        [JsonProperty("album")]
        public MusicAlbum Album { get; set; }

        /// <summary>
        /// MusicAlbum - A collection of music albums.
        /// </summary>
        [JsonProperty("albums")]
        public IList<MusicAlbum> Albums { get; set; }

        /// <summary>
        /// DefinedTerm, Text, or URL - Genre of the creative work, broadcast channel or group.
        /// </summary>
        [JsonProperty("genre")]
        public string Genre { get; set; }

        /// <summary>
        /// Person - A member of a music group—for example, John, Paul, George, or Ringo.
        /// </summary>
        [JsonProperty("musicGroupMember")]
        public Person MusicGroupMember { get; set; }

        private object track;
        /// <summary>
        /// ItemList or MusicRecording - A music recording (track)—usually a single song. Supersedes tracks.
        /// </summary>
        [JsonProperty("track")]
        public object Track
        {
            get { return track; }
            set
            {
                var validator = new TypeValidator(typeof(ItemList), typeof(MusicRecording));
                validator.Validate(value);
                track = value;
            }
        }

        /// <summary>
        /// MusicRecording - A music recording (track)—usually a single song. Superseded by track.
        /// </summary>
        [JsonProperty("tracks")]
        public IList<MusicRecording> Tracks { get; set; }
    }
}
