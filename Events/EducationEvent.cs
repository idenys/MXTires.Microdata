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

using Newtonsoft.Json;

namespace MXTires.Microdata.Events
{
    /// <summary>
    /// Event type: Education event.
    /// </summary>
    public class EducationEvent : Event
    {
        /// <summary>
        /// DefinedTerm or Text - The item being described is intended to assess the competency or learning outcome defined by the referenced term.
        /// </summary>
        [JsonProperty("assesses")]
        public string Assesses { get; set; }

        /// <summary>
        /// DefinedTerm, Text, or URL - The level in terms of progression through an educational or training context.
        /// </summary>
        [JsonProperty("educationalLevel")]
        public string EducationalLevel { get; set; }

        /// <summary>
        /// DefinedTerm or Text - The item being described is intended to help a person learn the competency or learning outcome defined by the referenced term.
        /// </summary>
        [JsonProperty("teaches")]
        public string Teaches { get; set; }
    }
}