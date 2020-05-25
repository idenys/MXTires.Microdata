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
using MXTires.Microdata.Intangible.Quantities;
using MXTires.Microdata.Validators;
using Newtonsoft.Json;

namespace MXTires.Microdata.CreativeWorks.MusicPlaylists
{
    /// <summary>
    /// A MusicRelease is a specific release of a music album.
    /// </summary>
    public class MusicRelease : MusicPlaylist
    {
        /// <summary>
        /// Text    The catalog number for the release.
        /// </summary>
        [JsonProperty("catalogNumber")]
        public string catalogNumber { get; set; }

        Thing creditedTo;
        /// <summary>
        /// Organization or Person The group the release is credited to if different than the byArtist. For example, Red and Blue is credited to "Stefani Germanotta Band", but by Lady Gaga.
        /// </summary>
        [JsonProperty("creditedTo")]
        public Thing CreditedTo
        {
            get { return creditedTo; }
            set
            {
                var validator = new TypeValidator(typeof(Organization), typeof(Person));
                validator.Validate(value);
                creditedTo = value;
            }
        }

        /// <summary>
        /// Duration    The duration of the item (movie, audio recording, event, etc.) in ISO 8601 date format.
        /// </summary>
        [JsonProperty("duration")]
        public Duration Duration { get; set; }

        /// <summary>
        /// MusicReleaseFormatType - Format of this release (the type of recording media used, ie.compact disc, digital media, LP, etc.).
        /// </summary>
        [JsonProperty("musicReleaseFormat")]
        public MusicReleaseFormatType MusicReleaseFormatType { get; set; }

        /// <summary>
        ///  Organization  - The label that issued the release.
        /// </summary>
        [JsonProperty("recordLabel")]
        public Organization recordLabel { get; set; }

        /// <summary>
        ///  MusicAlbum - The album this is a release of. Inverse property: albumRelease.
        /// </summary>
        [JsonProperty("releaseOf")]
        public MusicAlbum releaseOf { get; set; }
       
    }
}
