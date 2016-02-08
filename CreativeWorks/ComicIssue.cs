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

namespace MXTires.Microdata.CreativeWorks
{
    /// <summary>
    /// Defined in the bib.schema.org extension. (This is an initial exploratory release.)
    /// Canonical URL: http://schema.org/ComicIssue
    /// Individual comic issues are serially published as part of a larger series. For the sake of consistency, even one-shot issues belong to a series comprised of a single issue. All comic issues can be uniquely identified by: the combination of the name and volume number of the series to which the issue belongs; the issue number; and the variant description of the issue (if any).
    /// </summary>
    public class ComicIssue : PublicationIssue
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

        /// <summary>
        /// Text - A description of the variant cover for the issue, if the issue is a variant printing. For example, "Bryan Hitch Variant Cover" or "2nd Printing Variant".
        /// </summary>
        [JsonProperty("variantCover")]
        public String VariantCover { get; set; }
    }
}
