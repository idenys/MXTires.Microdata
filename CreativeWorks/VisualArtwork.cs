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
    /// A work of art that is primarily visual in character.
    /// </summary>
    public class VisualArtwork : CreativeWork
    {
        /// <summary>
        /// Integer  or Text - The number of copies when multiple copies of a piece of artwork are produced - e.g.
        /// for a limited edition of 20 prints, 'artEdition' refers to the total number of copies (in this example "20").
        /// </summary>
        [JsonProperty("artEdition")]
        public String ArtEdition { get; set; }

        /// <summary>
        /// Text  or URL - The material used. (e.g. Oil, Watercolour, Acrylic, Linoprint, Marble, Cyanotype, Digital, Lithograph, DryPoint, Intaglio, Pastel, Woodcut, Pencil, Mixed Media, etc.) Supersedes material.
        /// </summary>
        [JsonProperty("artMedium")]
        public String ArtMedium { get; set; }

        /// <summary>
        /// Text  or URL - e.g. Painting, Drawing, Sculpture, Print, Photograph, Assemblage, Collage, etc.
        /// </summary>
        [JsonProperty("artform")]
        public String Artform { get; set; }

        /// <summary>
        /// Text  or URL - The supporting materials for the artwork, e.g. Canvas, Paper, Wood, Board, etc. Supersedes surface.
        /// </summary>
        [JsonProperty("artworkSurface")]
        public String ArtworkSurface { get; set; }

        /// <summary>
        /// Distance  or QuantitativeValue - The depth of the item.
        /// </summary>
        [JsonProperty("depth")]
        public Thing Depth { get; set; }

        /// <summary>
        /// Distance  or QuantitativeValue - The height of the item.
        /// </summary>
        [JsonProperty("height")]
        public Thing Height { get; set; }

        /// <summary>
        /// Distance  or QuantitativeValue - The width of the item.
        /// </summary>
        [JsonProperty("width")]
        public Thing Width { get; set; }
    }
}
