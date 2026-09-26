using System;
using System.Collections.Generic;
using System.Linq;
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

using System.Text;
using System.Threading.Tasks;

using System.Runtime.Serialization;

namespace MXTires.Microdata.Intangible.Enumeration
{
    /// <summary>
    /// Enum BookFormatType
    /// </summary>
    public enum BookFormatType
    {
        /// <summary>
        /// The e book
        /// </summary>
        [EnumMember(Value = "https://schema.org/EBook")]
        EBook,
        /// <summary>
        /// The hardcover
        /// </summary>
        [EnumMember(Value = "https://schema.org/Hardcover")]
        Hardcover,
        /// <summary>
        /// The paperback
        /// </summary>
        [EnumMember(Value = "https://schema.org/Paperback")]
        Paperback,
        /// <summary>
        /// Defined in the bib.schema.org extension. (This is an initial exploratory release.)
        /// Canonical URL: http://schema.org/GraphicNovel
        /// </summary>
        [EnumMember(Value = "https://schema.org/GraphicNovel")]
        GraphicNovel,
        /// <summary>
        /// Book format: Audiobook.
        /// </summary>
        [EnumMember(Value = "https://schema.org/AudiobookFormat")]
        AudiobookFormat,
        /// <summary>
        /// Book format: Pamphlet.
        /// </summary>
        [EnumMember(Value = "https://schema.org/Pamphlet")]
        Pamphlet
    }
}
