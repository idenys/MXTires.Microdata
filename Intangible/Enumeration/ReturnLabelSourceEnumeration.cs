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
    /// Enumerates several types of return labels for product returns.
    /// </summary>
    [Flags]
    public enum ReturnLabelSourceEnumeration
    {
        /// <summary>
        /// Indicated that creating a return label is the responsibility of the customer.
        /// </summary>
        ReturnLabelCustomerResponsibility = 1 << 0,
        /// <summary>
        /// Indicated that a return label must be downloaded and printed by the customer.
        /// </summary>
        ReturnLabelDownloadAndPrint = 1 << 1,
        /// <summary>
        /// Specifies that a return label will be provided by the seller in the shipping box.
        /// </summary>
        ReturnLabelInBox = 1 << 2,
    }
}
