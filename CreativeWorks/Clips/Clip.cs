#region License
// Copyright (c) 2023 1010Tires.com
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
using Newtonsoft.Json;

namespace MXTires.Microdata.CreativeWorks.Clips
{
    /// <summary>
    /// A short TV or radio program or a segment/part of a program.
    /// </summary>
    public class Clip : CreativeWork
    {
        /// <summary>
        /// Person  An actor, e.g. in TV, radio, movie, video games etc., or in an event. Actors can be associated with individual items or with a series, episode, clip. Supersedes actors.
        /// </summary>
        [JsonProperty("actor")]
        public Person Actor { get; set; }

        /// <summary>
        /// Integer or Text Position of the clip within an ordered group of clips.
        /// </summary>
        [JsonProperty("clipNumber")]
        public object ClipNumber { get; set; }

        /// <summary>
        /// Person - A director of e.g. TV, radio, movie, video gaming etc. content, or of an event. Directors can be associated with individual items or with a series, episode, clip. Supersedes directors.
        /// </summary>
        [JsonProperty("director")]
        public Person Director { get; set; }

        /// <summary>
        /// HyperTocEntry or Number - The end time of the clip expressed as the number of seconds from the beginning of the work.
        /// </summary>
        [JsonProperty("endOffset")]
        public object EndOffset { get; set; }

        /// <summary>
        ///  MusicGroup or Person - The composer of the soundtrack.
        /// </summary>
        [JsonProperty("musicBy")]
        public object MusicBy { get; set; }

        /// <summary>
        ///  Episode - The episode to which this clip belongs.
        /// </summary>
        [JsonProperty("partOfEpisode")]
        public Episode PartOfEpisode { get; set; }

        /// <summary>
        /// CreativeWorkSeason - The season to which this episode belongs.
        /// </summary>
        [JsonProperty("partOfSeason")]
        public CreativeWorkSeason PartOfSeason { get; set; }

        /// <summary>
        /// CreativeWorkSeries - The series to which this episode or season belongs. Supersedes partOfTVSeries.
        /// </summary>
        [JsonProperty("partOfSeries")]
        public CreativeWorkSeries PartOfSeries { get; set; }

        /// <summary>
        /// HyperTocEntry or Number - The start time of the clip expressed as the number of seconds from the beginning of the work.
        /// </summary>
        [JsonProperty("startOffset")]
        public object StartOffset { get; set; }
    }
}
