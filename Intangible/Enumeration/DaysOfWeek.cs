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
    /// The day of the week, e.g. used to specify to which day the opening hours of an OpeningHoursSpecification refer. 
    /// Commonly used values:
    /// http://purl.org/goodrelations/v1#Monday 
    /// http://purl.org/goodrelations/v1#Tuesday 
    /// http://purl.org/goodrelations/v1#Wednesday 
    /// http://purl.org/goodrelations/v1#Thursday 
    /// http://purl.org/goodrelations/v1#Friday 
    /// http://purl.org/goodrelations/v1#Saturday 
    /// http://purl.org/goodrelations/v1#Sunday 
    /// http://purl.org/goodrelations/v1#PublicHolidays 
    /// </summary>
    [Flags]
    public enum DaysOfWeek
    {
        /// <summary>
        /// Monday
        /// </summary>
        [EnumMember(Value = "http://purl.org/goodrelations/v1#Monday")]
        Mo = 1 << 0,
        /// <summary>
        /// Tuesday
        /// </summary>
        [EnumMember(Value = "http://purl.org/goodrelations/v1#Tuesday ")]
        Tu = 1 << 1,
        /// <summary>
        /// Wednesday
        /// </summary>
        [EnumMember(Value = "http://purl.org/goodrelations/v1#Wednesday")]
        We = 1 << 2,
        /// <summary>
        /// Thursday
        /// </summary>
        [EnumMember(Value = "http://purl.org/goodrelations/v1#Thursday")]
        Th = 1 << 3,
        /// <summary>
        /// Friday
        /// </summary>
        [EnumMember(Value = "http://purl.org/goodrelations/v1#Friday")]
        Fr = 1 << 4,
        /// <summary>
        /// Saturday
        /// </summary>
        [EnumMember(Value = "http://purl.org/goodrelations/v1#Saturday")]
        Sa = 1 << 5,
        /// <summary>
        /// Sunday
        /// </summary>
        [EnumMember(Value = "http://purl.org/goodrelations/v1#Sunday")]
        Su = 1 << 6,
        /// <summary>
        /// Sunday
        /// </summary>
        [EnumMember(Value = "http://purl.org/goodrelations/v1#PublicHolidays")]
        PublicHolidays = 1 << 7,
    }
}
