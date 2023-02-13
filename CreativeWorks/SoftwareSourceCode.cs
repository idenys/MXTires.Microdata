#region License
// Copyright (c) 2023 1010Tires.com
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

namespace MXTires.Microdata.CreativeWorks
{
    /// <summary>
    /// Computer programming source code. Example: Full (compile ready) solutions, code snippet samples, scripts, templates.
    /// </summary>
    public class SoftwareSourceCode : CreativeWork
    {
        /// <summary>
        /// URL - Link to the repository where the un-compiled, human readable code and related code is located(SVN, GitHub, CodePlex).
        /// </summary>
        [JsonProperty("codeRepository")]
        public String CodeRepository { get; set; }

        /// <summary>
        /// Text - What type of code sample: full(compile ready) solution, code snippet, inline code, scripts, template.Supersedes sampleType.
        /// </summary>
        [JsonProperty("codeSampleType")]
        public String CodeSampleType { get; set; }

        /// <summary>
        /// ComputerLanguage or Text - The computer programming language.
        /// </summary>
        [JsonProperty("programmingLanguage")]
        public object ProgrammingLanguage { get; set; }

        /// <summary>
        /// Text - Runtime platform or script interpreter dependencies (example: Java v1, Python 2.3, .NET Framework 3.0). Supersedes runtime.
        /// </summary>
        [JsonProperty("runtimePlatform")]
        public String RuntimePlatform { get; set; }

        /// <summary>
        /// SoftwareApplication - Target Operating System / Product to which the code applies. If applies to several versions, just the product name can be used.
        /// </summary>
        [JsonProperty("targetProduct")]
        public SoftwareApplication TargetProduct { get; set; } 
    }
}
