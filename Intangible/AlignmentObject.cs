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

using Newtonsoft.Json;

namespace MXTires.Microdata.Intangible
{
    /// <summary>
    /// An intangible item that describes an alignment between a learning resource and a node in an educational framework.
    /// </summary>
    public class AlignmentObject : Thing
    {
        /// <summary>
        /// Text - A category of alignment between the learning resource and the framework node. 
        /// Recommended values include: 'assesses', 'teaches', 'requires', 'textComplexity', 'readingLevel', 
        /// 'educationalSubject', and 'educationLevel'.
        /// </summary>
        [JsonProperty("alignmentType")]
        public string AlignmentType { get; set; }

        /// <summary>
        /// Text 	The framework to which the resource being described is aligned.
        /// </summary>
        [JsonProperty("educationalFramework")]
        public string EducationalFramework { get; set; }
        /// <summary>
        /// Text 	The description of a node in an established educational framework.
        /// </summary>
        [JsonProperty("targetDescription")]
        public string TargetDescription { get; set; }
        /// <summary>
        /// Text - The name of a node in an established educational framework.
        /// </summary>
        [JsonProperty("targetName")]
        public string TargetName { get; set; }
        /// <summary>
        /// URL - The URL of a node in an established educational framework.
        /// </summary>
        [JsonProperty("targetUrl")]
        public string TargetUrl { get; set; }
    }
}
