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

using System.Collections.Generic;
using MXTires.Microdata.Validators;
using Newtonsoft.Json;

namespace MXTires.Microdata.Intangible.Enumeration
{
    /// <summary>
    /// Enumerated status values for Reservation.
    /// </summary>
    public enum ReservationStatusType
    {
        /// <summary>
        /// The status for a previously confirmed reservation that is now cancelled.
        /// </summary>
        ReservationCancelled,
        /// <summary>
        /// The status of a confirmed reservation.
        /// </summary>
        ReservationConfirmed,
        /// <summary>
        /// The status of a reservation on hold pending an update like credit card number or flight changes.
        /// </summary>
        ReservationHold,
        /// <summary>
        /// The status of a reservation when a request has been sent, but not confirmed.
        /// </summary>
        ReservationPending,
    }
}
