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
    /// Originally, URLs from GoodRelations were used(for Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday plus a special entry for PublicHolidays); 
    /// these have now been integrated directly into schema.org.
    /// </summary>
    [Flags]
    public enum DayOfWeek
    {
        /// <summary>
        /// Monday
        /// </summary>
        [EnumMember(Value = "https://schema.org/Monday")]
        Monday = 1 << 0,
        /// <summary>
        /// Tuesday
        /// </summary>
        [EnumMember(Value = "https://schema.org/Tuesday ")]
        Tuesday = 1 << 1,
        /// <summary>
        /// Wednesday
        /// </summary>
        [EnumMember(Value = "https://schema.org/Wednesday")]
        Wednesday = 1 << 2,
        /// <summary>
        /// Thursday
        /// </summary>
        [EnumMember(Value = "https://schema.org/Thursday")]
        Thursday = 1 << 3,
        /// <summary>
        /// Friday
        /// </summary>
        [EnumMember(Value = "https://schema.org/Friday")]
        Friday = 1 << 4,
        /// <summary>
        /// Saturday
        /// </summary>
        [EnumMember(Value = "https://schema.org/Saturday")]
        Saturday = 1 << 5,
        /// <summary>
        /// Sunday
        /// </summary>
        [EnumMember(Value = "https://schema.org/Sunday")]
        Sunday = 1 << 6,
        /// <summary>
        /// Sunday
        /// </summary>
        [EnumMember(Value = "https://schema.org/PublicHolidays")]
        PublicHolidays = 1 << 7,
    }
}
