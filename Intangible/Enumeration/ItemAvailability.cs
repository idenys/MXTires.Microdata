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
    /// A list of possible product availability options.
    /// </summary>
    [Flags]
    public enum ItemAvailability 
    {
        /// <summary>
        /// The discontinued
        /// </summary>
        [EnumMember(Value = "http://schema.org/Discontinued")]
        Discontinued = 1,

        /// <summary>
        /// The in stock
        /// </summary>
        [EnumMember(Value = "http://schema.org/InStock")]
        InStock = 2,

        /// <summary>
        /// The in store only
        /// </summary>
        [EnumMember(Value = "http://schema.org/InStoreOnly")]
        InStoreOnly = 4,

        /// <summary>
        /// The limited availability
        /// </summary>
        [EnumMember(Value = "http://schema.org/LimitedAvailability")]
        LimitedAvailability = 8,

        /// <summary>
        /// The online only
        /// </summary>
        [EnumMember(Value = "http://schema.org/OnlineOnly")]
        OnlineOnly = 16,

        /// <summary>
        /// The out of stock
        /// </summary>
        [EnumMember(Value = "http://schema.org/OutOfStock")]
        OutOfStock = 32,

        /// <summary>
        /// The pre order
        /// </summary>
        [EnumMember(Value = "http://schema.org/PreOrder")]
        PreOrder = 64,

        /// <summary>
        /// The sold out
        /// </summary>
        [EnumMember(Value = "http://schema.org/SoldOut")]
        SoldOut = 128,

        /// <summary>
        /// The pre-sale
        /// </summary>
        [EnumMember(Value = "http://schema.org/PreSale")]
        PreSale = 256,
    }
}
