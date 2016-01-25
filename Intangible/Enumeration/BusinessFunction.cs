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
    /// The business function specifies the type of activity or access (i.e., the bundle of rights) offered by the
    /// organization or business person through the offer. Typical are sell, rental or lease, maintenance or
    /// repair, manufacture / produce, recycle / dispose, engineering / construction, or installation.
    /// Proprietary specifications of access rights are also instances of this class.
    /// Commonly used values:
    /// http://purl.org/goodrelations/v1#ConstructionInstallation
    /// http://purl.org/goodrelations/v1#Dispose
    /// http://purl.org/goodrelations/v1#LeaseOut
    /// http://purl.org/goodrelations/v1#Maintain
    /// http://purl.org/goodrelations/v1#ProvideService
    /// http://purl.org/goodrelations/v1#Repair
    /// http://purl.org/goodrelations/v1#Sell
    /// http://purl.org/goodrelations/v1#Buy
    /// </summary>
    [Flags]
    public enum BusinessFunction
    {
        /// <summary>
        /// The construction installation
        /// </summary>
        [EnumMember(Value = "http://purl.org/goodrelations/v1#ConstructionInstallation")]
        ConstructionInstallation = 1 << 0,
        /// <summary>
        /// The dispose
        /// </summary>
        [EnumMember(Value = "http://purl.org/goodrelations/v1#Dispose")]
        Dispose = 1 << 1,
        /// <summary>
        /// The lease out
        /// </summary>
        [EnumMember(Value = "http://purl.org/goodrelations/v1#LeaseOut")]
        LeaseOut = 1 << 2,
        /// <summary>
        /// The maintain
        /// </summary>
        [EnumMember(Value = "http://purl.org/goodrelations/v1#Maintain")]
        Maintain = 1 << 3,
        /// <summary>
        /// The provide service
        /// </summary>
        [EnumMember(Value = "http://purl.org/goodrelations/v1#ProvideService")]
        ProvideService = 1 << 4,
        /// <summary>
        /// The repair
        /// </summary>
        [EnumMember(Value = "http://purl.org/goodrelations/v1#Repair")]
        Repair = 1 << 5,
        /// <summary>
        /// The sell
        /// </summary>
        [EnumMember(Value = "http://purl.org/goodrelations/v1#Sell")]
        Sell = 1 << 6,
        /// <summary>
        /// The buy
        /// </summary>
        [EnumMember(Value = "http://purl.org/goodrelations/v1#Buy")]
        Buy = 1 << 7
    }
}
