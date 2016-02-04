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

using Newtonsoft.Json;

namespace MXTires.Microdata.CreativeWorks
{
    /// <summary>
    /// Defined in the bib.schema.org extension. (This is an initial exploratory release.)
    /// Canonical URL: http://schema.org/ComicStory
    /// The term "story" is any indivisible, re-printable unit of a comic, including the interior stories, covers, and backmatter. Most comics have at least two stories: a cover (ComicCoverArt) and an interior story.
    /// </summary>
    public class ComicStory : CreativeWork
    {
        /// <summary>
        /// Person - The primary artist for a work in a medium other than pencils or digital line art--for example, if the primary artwork is done in watercolors or digital paints.
        /// </summary>
        [JsonProperty("artist")]
        public Person Artist { get; set; }

        /// <summary>
        /// Person - The individual who adds color to inked drawings.
        /// </summary>
        [JsonProperty("colorist")]
        public Person Colorist { get; set; }

        /// <summary>
        /// Person - The individual who traces over the pencil drawings in ink after pencils are complete.
        /// </summary>
        [JsonProperty("inker")]
        public Person Inker { get; set; }

        /// <summary>
        /// Person - The individual who adds lettering, including speech balloons and sound effects, to artwork.
        /// </summary>
        [JsonProperty("letterer")]
        public Person Letterer { get; set; }

        /// <summary>
        /// Person - The individual who draws the primary narrative artwork.
        /// </summary>
        [JsonProperty("penciler")]
        public Person Penciler { get; set; }
    }
}
