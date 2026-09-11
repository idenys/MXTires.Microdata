#region License
// Copyright (c) 2015 1010Tires.com
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
using MXTires.Microdata.Intangible.Quantities;
using Newtonsoft.Json;

namespace MXTires.Microdata.CreativeWorks
{
    /// <summary>
    /// A credential awarded to an individual or organization, such as a degree, certificate, or badge.
    /// </summary>
    public class Credential : CreativeWork
    {
        /// <summary>
        /// Text - The type or category of credential being described, for example "degree", "certificate", "badge".
        /// </summary>
        [JsonProperty("credentialCategory")]
        public string CredentialCategory { get; set; }

        /// <summary>
        /// Organization - An organization that acknowledges the validity, value or utility of a credential.
        /// </summary>
        [JsonProperty("recognizedBy")]
        public Organization RecognizedBy { get; set; }

        /// <summary>
        /// Duration - The duration of validity of a permit or similar thing.
        /// </summary>
        [JsonProperty("validFor")]
        public Duration ValidFor { get; set; }

        /// <summary>
        /// AdministrativeArea - The geographic area where the item is valid.
        /// </summary>
        [JsonProperty("validIn")]
        public AdministrativeArea ValidIn { get; set; }
    }
}
