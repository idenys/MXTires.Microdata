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

using MXTires.Microdata.CreativeWorks.MusicPlaylists;
using MXTires.Microdata.Intangible.Quantities;
using MXTires.Microdata.Organizations.PerformingGroups;
using MXTires.Microdata.Validators;
using Newtonsoft.Json;

namespace MXTires.Microdata.CreativeWorks
{
    /// <summary>
    /// A music recording (track), usually a single song.
    /// </summary>
    public class MusicRecording : CreativeWork
    {
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

        /// <summary>
        /// Duration - The duration of the item(movie, audio recording, event, etc.) in ISO 8601 date format.
        /// </summary>
        [JsonProperty("duration")]
        public Duration Duration { get; set; }

        /// <summary>
        ///  MusicAlbum - The album to which this recording belongs.
        /// </summary>
        [JsonProperty("inAlbum")]
        public MusicAlbum InAlbum { get; set; }

        /// <summary>
        /// MusicPlaylist -The playlist to which this recording belongs.
        /// </summary>
        [JsonProperty("inPlaylist")]
        public MusicPlaylist InPlaylist { get; set; }

        /// <summary>
        /// Text - The International Standard Recording Code for the recording.
        /// </summary>
        [JsonProperty("isrcCode")]
        public string IsrcCode { get; set; }

        /// <summary>
        /// MusicComposition - The composition this track is a recording of. Inverse property: recordedAs.
        /// </summary>
        [JsonProperty("recordingOf")]
        public MusicComposition RecordingOf { get; set; }
    }
}
