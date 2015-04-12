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
using Newtonsoft.Json;

namespace MXTires.Microdata.Intangible
{
    /// <summary>
    /// A means for accessing a service, e.g. a government office location, web site, or phone number.
    /// </summary>
    public class ServiceChannel : Thing
    {
        /// <summary>
        /// Language - A language someone may use with the item.
        /// </summary>
        [JsonProperty("availableLanguage")]
        public Language AvailableLanguage { get; set; }

        /// <summary>
        /// Duration - Estimated processing time for the service using this channel.
        /// </summary>
        [JsonProperty("processingTime")]
        public Duration ProcessingTime { get; set; }

        /// <summary>
        /// Service - The service provided by this channel.
        /// </summary>
        [JsonProperty("providesService")]
        public Service ProvidesService { get; set; }

        /// <summary>
        /// Place - The location (e.g. civic structure, local business, etc.) where a person can go to access the service.
        /// </summary>
        [JsonProperty("serviceLocation")]
        public Place ServiceLocation { get; set; }

        /// <summary>
        /// ContactPoint - The phone number to use to access the service.
        /// </summary>
        [JsonProperty("servicePhone")]
        public ContactPoint ServicePhone { get; set; }

        /// <summary>
        /// PostalAddress - The address for accessing the service by mail.
        /// </summary>
        [JsonProperty("servicePostalAddress")]
        public PostalAddress ServicePostalAddress { get; set; }

        /// <summary>
        /// ContactPoint - The number to access the service by text message.
        /// </summary>
        [JsonProperty("serviceSmsNumber")]
        public ContactPoint ServiceSmsNumber { get; set; }

        /// <summary>
        /// URL - The website to access the service.
        /// </summary>
        [JsonProperty("serviceUrl")]
        public string ServiceUrl { get; set; }
    }
}
