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
namespace MXTires.Microdata.Intangible
{
    /// <summary>
    /// A property, used to indicate attributes and relationships of some Thing; equivalent to rdf:Property.
    /// </summary>
    public class Property : Thing
    {
        /// <summary>
        /// Class - Relates a property to a class that is (one of) the type(s) the property is expected to be used on.
        /// </summary>
        [JsonProperty("domainIncludes")]
        public Class DomainIncludes { get; set; }

        /// <summary>
        /// Property - Relates a property to a property that is its inverse. Inverse properties relate the same pairs of items to each other, but in reversed direction. For example, the 'alumni' and 'alumniOf' properties are inverseOf each other. Some properties don't have explicit inverses; in these situations RDFa and JSON-LD syntax for reverse properties can be used.
        /// </summary>
        [JsonProperty("inverseOf")]
        public Property InverseOf { get; set; }

        /// <summary>
        /// Class - Relates a property to a class that constitutes (one of) the expected type(s) for values of the property.
        /// </summary>
        [JsonProperty("rangeIncludes")]
        public Class RangeIncludes { get; set; }

        /// <summary>
        /// Property 	Relates a property to one that supersedes it.
        /// </summary>
        [JsonProperty("supersededBy")]
        public Property SupersededBy { get; set; }
    }
}