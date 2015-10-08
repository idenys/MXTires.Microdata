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

using MXTires.Microdata.Validators;
using Newtonsoft.Json;

namespace MXTires.Microdata.CreativeWorks
{
    /// <summary>
    /// A software application.
    /// </summary>
    public class SoftwareApplication : CreativeWork
    {
        /// <summary>
        /// URL  or Text - Type of software application, e.g. "Game, Multimedia".
        /// </summary>
        [JsonProperty("applicationCategory")]
        public string ApplicationCategory { get; set; }

        /// <summary>
        /// URL  or Text - Subcategory of the application, e.g. "Arcade Game".
        /// </summary>
        [JsonProperty("applicationSubCategory")]
        public string ApplicationSubCategory { get; set; }

        /// <summary>
        /// Text - The name of the application suite to which the application belongs (e.g. Excel belongs to Office).
        /// </summary>
        [JsonProperty("applicationSuite")]
        public string ApplicationSuite { get; set; }

        /// <summary>
        /// Text - Device required to run the application. Used in cases where a specific make/model is required to run the application. Supersedes device.
        /// </summary>
        [JsonProperty("availableOnDevice")]
        public string AvailableOnDevice { get; set; }

        /// <summary>
        /// Text - Countries for which the application is not supported. You can also provide the two-letter ISO 3166-1 alpha-2 country code.
        /// </summary>
        [JsonProperty("countriesNotSupported")]
        public string CountriesNotSupported { get; set; }

        /// <summary>
        /// Text - Countries for which the application is supported. You can also provide the two-letter ISO 3166-1 alpha-2 country code.
        /// </summary>
        [JsonProperty("countriesSupported")]
        public string CountriesSupported { get; set; }

        /// <summary>
        /// URL - If the file can be downloaded, URL to download the binary.
        /// </summary>
        [JsonProperty("downloadUrl")]
        public string DownloadUrl { get; set; }

        /// <summary>
        /// URL  or Text - Features or modules provided by this application (and possibly required by other applications).
        /// </summary>
        [JsonProperty("featureList")]
        public string FeatureList { get; set; }

        /// <summary>
        /// Text - MIME format of the binary (e.g. application/zip).
        /// </summary>
        [JsonProperty("fileFormat")]
        public string FileFormat { get; set; }

        /// <summary>
        /// Text - Size of the application / package (e.g. 18MB). In the absence of a unit (MB, KB etc.), KB will be assumed.
        /// </summary>
        [JsonProperty("fileSize")]
        public string FileSize { get; set; }

        /// <summary>
        /// URL - URL at which the app may be installed, if different from the URL of the item.
        /// </summary>
        [JsonProperty("installUrl")]
        public string InstallUrl { get; set; }

        /// <summary>
        /// URL  or Text - Minimum memory requirements.
        /// </summary>
        [JsonProperty("memoryRequirements")]
        public string MemoryRequirements { get; set; }

        /// <summary>
        /// Text - Operating systems supported (Windows 7, OSX 10.6, Android 1.6).
        /// </summary>
        [JsonProperty("operatingSystem")]
        public string OperatingSystem { get; set; }

        /// <summary>
        /// Text - Permission(s) required to run the app (for example, a mobile app may require full internet access or may run only on wifi).
        /// </summary>
        [JsonProperty("permissions")]
        public string Permissions { get; set; }

        /// <summary>
        /// Text - Processor architecture required to run the application (e.g. IA64).
        /// </summary>
        [JsonProperty("processorRequirements")]
        public string ProcessorRequirements { get; set; }

        /// <summary>
        /// URL  or Text - Description of what changed in this version.
        /// </summary>
        [JsonProperty("releaseNotes")]
        public string ReleaseNotes { get; set; }

        object screenshot; 
        /// <summary>
        /// URL  or ImageObject - A link to a screenshot image of the app.
        /// </summary>
        [JsonProperty("screenshot")]
        public object Screenshot
        {
            get { return screenshot; }
            set
            {
                var validator = new TypeValidator(typeof(string), typeof(ImageObject));
                validator.Validate(value);
                screenshot = value;
            }
        }

        /// <summary>
        /// SoftwareApplication - Additional content for a software application.
        /// </summary>
        [JsonProperty("softwareAddOn")]
        public SoftwareApplication SoftwareAddOn { get; set; }

        /// <summary>
        /// CreativeWork - Software application help.
        /// </summary>
        [JsonProperty("softwareHelp")]
        public CreativeWork SoftwareHelp { get; set; }

        /// <summary>
        /// URL  or Text  - Component dependency requirements for application. This includes runtime environments and shared libraries that are not included in the application distribution package, but required to run the application (Examples: DirectX, Java or .NET runtime). Supersedes requirements.
        /// </summary>
        [JsonProperty("softwareRequirements")]
        public string SoftwareRequirements { get; set; }

        /// <summary>
        /// Text - Version of the software instance.
        /// </summary>
        [JsonProperty("softwareVersion")]
        public string SoftwareVersion { get; set; }

        /// <summary>
        /// URL  or Text - Storage requirements (free space required).
        /// </summary>
        [JsonProperty("storageRequirements")]
        public string StorageRequirements { get; set; }
    }
}
