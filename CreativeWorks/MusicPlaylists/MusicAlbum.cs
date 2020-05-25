#region License
// Copyright (c) 2020 1010Tires.com
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

using MXTires.Microdata.Intangible.Enumeration;
using MXTires.Microdata.Organizations.PerformingGroups;
using MXTires.Microdata.Validators;
using Newtonsoft.Json;

namespace MXTires.Microdata.CreativeWorks.MusicPlaylists
{
    /// <summary>
    /// A collection of music tracks.
    /// </summary>
    public class MusicAlbum: MusicPlaylist
    {
        /// <summary>
        /// MusicAlbumProductionType - Classification of the album by it's type of content: soundtrack, live album, studio album, etc.
        /// </summary>
        [JsonProperty("albumProductionType")]
        public MusicAlbumProductionType AlbumProductionType { get; set; }

        /// <summary>
        ///  MusicRelease - A release of this album. Inverse property: releaseOf.
        /// </summary>
        [JsonProperty("albumRelease")]
        public MusicRelease AlbumRelease { get; set; }

        /// <summary>
        /// MusicAlbumReleaseType - The kind of release which this album is: single, EP or album.
        /// </summary>
        [JsonProperty("albumReleaseType")]
        public MusicAlbumReleaseType AlbumReleaseType { get; set; }

        Thing byArtist;
        /// <summary>
        /// MusicGroup  or  Person - The artist that performed this album or recording.
        /// </summary>
        [JsonProperty("byArtist")]
        public Thing ByArtist
        {
            get { return byArtist; }
            set
            {
                var validator = new TypeValidator(typeof(MusicGroup), typeof(Person));
                validator.Validate(value);
                byArtist = value;
            }
        }

    }
}
