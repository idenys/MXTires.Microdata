﻿#region License
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


namespace MXTires.Microdata.Intangible.Enumeration
{
    /// <summary>
    /// Enumerates several kinds of product return refund types.
    /// </summary>
    [Flags]
    public enum RefundTypeEnumeration
    {
        /// <summary>
        /// Specifies that a refund can be done as an exchange for the same product.
        /// </summary>
        ExchangeRefund = 1 << 0,
        /// <summary>
        /// Specifies that a refund can be done in the full amount the customer paid for the product.
        /// </summary>
        FullRefund = 1 << 1,
        /// <summary>
        /// Specifies that the customer receives a store credit as refund when returning a product.
        /// </summary>
        StoreCreditRefund = 1 << 2,
    }
}
