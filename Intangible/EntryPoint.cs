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
using MXTires.Microdata.CreativeWorks;
using Newtonsoft.Json;

namespace MXTires.Microdata.Intangible
{
    /// <summary>
    /// Class EntryPoint.
    /// </summary>
    public class EntryPoint : Thing
    {
        /// <summary>
        /// SoftwareApplication - An application that can complete the request. Supersedes application.
        /// </summary>
        [JsonProperty("actionApplication")]
        public SoftwareApplication ActionApplication { get; set; }

        /// <summary>
        /// Text  or URL -The high level platform(s) where the Action can be performed for the given URL. To specify a specific application or operating system instance, use actionApplication.
        /// </summary>
        /// <value>Action Platform</value>
        [JsonProperty("actionPlatform")]
        public string ActionPlatform { get; set; }

        /// <summary>
        /// Text - The supported content type(s) for an EntryPoint response.
        /// </summary>
        [JsonProperty("contentType")]
        public string ContentType { get; set; }

        /// <summary>
        /// Text - The supported encoding type(s) for an EntryPoint request.
        /// </summary>
        [JsonProperty("encodingType")]
        public string EncodingType { get; set; }

        /// <summary>
        /// Text - An HTTP method that specifies the appropriate HTTP method for a request to an HTTP EntryPoint. Values are capitalized strings as used in HTTP.
        /// </summary>
        /// <value>An HTTP Method.</value>
        [JsonProperty("httpMethod")]
        public string HttpMethod { get; set; }

        /// <summary>
        /// Text - An url template (RFC6570) that will be used to construct the target of the execution of the action.
        /// </summary>
        /// <value>The URL template.</value>
        [JsonProperty("urlTemplate")]
        public string UrlTemplate { get; set; }
    }
}
