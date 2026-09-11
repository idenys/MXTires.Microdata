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

using MXTires.Microdata.Validators;
using Newtonsoft.Json;
using System;
using MXTires.Microdata.Intangible.StructuredValues;

namespace MXTires.Microdata.CreativeWorks
{
    /// <summary>
    /// Class ImageObject.
    /// </summary>
    public class ImageObject : MediaObject
    {
        /// <summary>
        /// Text - The caption for this object.
        /// </summary>
        [JsonProperty("caption")]
        public string Caption { get; set; }

        object exifData;
        /// <summary>
        /// Text  or PropertyValue exif data for this object.
        /// </summary>
        [JsonProperty("exifData")]
        public object ExifData
        {
            get { return exifData; }
            set
            {
                var validator = new TypeValidator(typeof(String), typeof(PropertyValue));
                validator.Validate(value);
                exifData = value;
            }
        }

        /// <summary>
        /// Boolean - Indicates whether this image is representative of the content of the page.
        /// </summary>
        [JsonProperty("representativeOfPage")]
        public bool? RepresentativeOfPage { get; set; }

        /// <summary>
        /// Text - Represents textual captioning from a MediaObject, e.g. text of a 'meme'.
        /// </summary>
        [JsonProperty("embeddedTextCaption")]
        public string EmbeddedTextCaption { get; set; }
    }
}
