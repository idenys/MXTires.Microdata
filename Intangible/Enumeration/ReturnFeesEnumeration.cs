#region License
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
    /// Enumerates several kinds of policies for product return fees.
    /// </summary>
    [Flags]
    public enum ReturnFeesEnumeration
    {
        /// <summary>
        /// Specifies that product returns are free of charge for the customer.
        /// </summary>
        FreeReturn = 1 << 0,
        /// <summary>
        /// Specifies that the customer must pay the original shipping costs when returning a product.
        /// </summary>
        OriginalShippingFees = 1 << 1,
        /// <summary>
        /// Specifies that the customer must pay a restocking fee when returning a product.
        /// </summary>
        RestockingFees = 1 << 2,
        /// <summary>
        /// Specifies that product returns must be paid for, and are the responsibility of, the customer.
        /// </summary>
        ReturnFeesCustomerResponsibility = 1 << 3,
        /// <summary>
        /// Specifies that the customer must pay the return shipping costs when returning a product.
        /// </summary>
        ReturnShippingFees = 1 << 4,
    }
}
