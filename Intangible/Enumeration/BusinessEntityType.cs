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
using System.Runtime.Serialization;

namespace MXTires.Microdata.Intangible.Enumeration
{
    /// <summary>
    /// A business entity type is a conceptual entity representing the legal form, the size, the main line of business,
    /// the position in the value chain, or any combination thereof, of an organization or business person.
    /// Commonly used values:
    /// http://purl.org/goodrelations/v1#Business
    /// http://purl.org/goodrelations/v1#Enduser
    /// http://purl.org/goodrelations/v1#PublicInstitution
    /// http://purl.org/goodrelations/v1#Reseller
    /// </summary>
    [Flags]
    public enum BusinessEntityType
    {
        /// <summary>
        /// The business
        /// </summary>
        [EnumMember(Value = "http://purl.org/goodrelations/v1#Business")]
        Business = 1 << 0,

        /// <summary>
        /// The end user
        /// </summary>
        [EnumMember(Value = "http://purl.org/goodrelations/v1#Enduser")]
        Enduser = 1 << 1,

        /// <summary>
        /// The public institution
        /// </summary>
        [EnumMember(Value = "http://purl.org/goodrelations/v1#PublicInstitution")]
        PublicInstitution = 1 << 2,

        /// <summary>
        /// The reseller
        /// </summary>
        [EnumMember(Value = "http://purl.org/goodrelations/v1#Reseller")]
        Reseller = 1 << 3
    }
}
