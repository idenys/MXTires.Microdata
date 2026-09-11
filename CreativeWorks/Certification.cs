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
using MXTires.Microdata.Intangible;
using MXTires.Microdata.Validators;
using Newtonsoft.Json;

namespace MXTires.Microdata.CreativeWorks
{
    /// <summary>
    /// A Certification is an official and authoritative statement about a subject, for example a product, service, person,
    /// or organization, typically issued by an indendent certification body, e.g. a professional organization, an industry
    /// federation, a government agency, etc.
    /// </summary>
    public class Certification : CreativeWork
    {
        /// <summary>
        /// Date or DateTime - Date when a certification was last audited.
        /// </summary>
        [JsonProperty("auditDate")]
        public DateTime? AuditDate { get; set; }

        /// <summary>
        /// DefinedTerm or Text - Identifier of a certification instance (as registered with an independent certification body). Typically this identifier links to the certificate itself.
        /// </summary>
        [JsonProperty("certificationIdentification")]
        public string CertificationIdentification { get; set; }

        /// <summary>
        /// Rating - Rating of a certification instance (as defined by an independent rating body) that is not part of the certification itself.
        /// </summary>
        [JsonProperty("certificationRating")]
        public Rating CertificationRating { get; set; }

        /// <summary>
        /// QuantitativeValue - A measurement of an item, For example, the inseam of pants, the wheel size of a bicycle, or the gauge of a screw.
        /// </summary>
        [JsonProperty("hasMeasurement")]
        public QuantitativeValue HasMeasurement { get; set; }

        /// <summary>
        /// Organization - The organization issuing the certification, for example a professional organization, an industry federation, a government agency.
        /// </summary>
        [JsonProperty("issuedBy")]
        public Organization IssuedBy { get; set; }

        /// <summary>
        /// CertificationStatusEnumeration - Indicates the current status of a certification: active or inactive.
        /// </summary>
        [JsonProperty("certificationStatus")]
        public string CertificationStatus { get; set; }

        private object logo;
        /// <summary>
        /// ImageObject or URL - An associated logo.
        /// </summary>
        [JsonProperty("logo")]
        public object Logo
        {
            get { return logo; }
            set
            {
                var validator = new TypeValidator(typeof(ImageObject), typeof(string));
                validator.Validate(value);
                logo = value;
            }
        }

        /// <summary>
        /// AdministrativeArea - The geographic area where the item is valid.
        /// </summary>
        [JsonProperty("validIn")]
        public AdministrativeArea ValidIn { get; set; }

        /// <summary>
        /// Date or DateTime - Date when a certification was issued.
        /// </summary>
        [JsonProperty("validFrom")]
        public DateTime? ValidFrom { get; set; }
    }
}
