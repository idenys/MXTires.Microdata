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
    /// A credit or debit card type as a standardized procedure for transferring the monetary amount for a purchase. 
    /// 
    /// Commonly used values:
    /// http://purl.org/goodrelations/v1#AmericanExpress 
    /// http://purl.org/goodrelations/v1#DinersClub 
    /// http://purl.org/goodrelations/v1#Discover 
    /// http://purl.org/goodrelations/v1#JCB 
    /// http://purl.org/goodrelations/v1#MasterCard 
    /// http://purl.org/goodrelations/v1#VISA 
    /// </summary>
    [Flags]
    public enum CreditCard
    {
        /// <summary>
        /// Default enum value
        /// </summary>
        [EnumMember(Value = "http://schema.1010tires.com/NoCredit")]
        NoCredit = 0,

        /// <summary>
        /// AmericanExpress
        /// </summary>
        [EnumMember(Value = "http://purl.org/goodrelations/v1#AmericanExpress")]
        AmericanExpress = 1 << 0,

        /// <summary>
        /// DinersClub 
        /// </summary>
        [EnumMember(Value = "http://purl.org/goodrelations/v1#DinersClub")]
        DinersClub = 1 << 2,

        /// <summary>
        /// Discover 
        /// </summary>
        [EnumMember(Value = "http://purl.org/goodrelations/v1#Discover")]
        Discover = 1 << 3,
        /// <summary>
        /// JCB 
        /// </summary>
        [EnumMember(Value = "http://purl.org/goodrelations/v1#JCB")]
        Jcb = 1 << 4,

        /// <summary>
        /// MasterCard 
        /// </summary>
        [EnumMember(Value = "http://purl.org/goodrelations/v1#MasterCard")]
        MasterCard = 1 << 5,

        /// <summary>
        /// Visa
        /// </summary>
        [EnumMember(Value = "http://purl.org/goodrelations/v1#VISA")]
        Visa = 1 << 6,
    }
}