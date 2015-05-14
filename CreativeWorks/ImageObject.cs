using MXTires.Microdata.Intangible.StructuredValue;
using MXTires.Microdata.Validators;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MXTires.Microdata.CreativeWorks
{
    public class ImageObject : MediaObject
    {
        /// <summary>
        /// Text - The caption for this object.
        /// </summary>
        [JsonProperty("caption")]
        public string Caption { get; set; }

        object exifData;
        /// <summary>
        /// Text  or PropertyValue 	exif data for this object.
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
        /// ImageObject -Thumbnail image for an image or video.
        /// </summary>
        [JsonProperty("thumbnail")]
        public ImageObject Thumbnail { get; set; }
    }
}
