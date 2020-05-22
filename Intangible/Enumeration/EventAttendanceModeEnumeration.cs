#region License
// Copyright (c) 2020 1010Tires.com
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

namespace MXTires.Microdata.Intangible.Enumeration
{
    /// <summary>
    /// An EventAttendanceModeEnumeration value is one of potentially several modes of organising an event, relating to whether it is online or offline.
    /// </summary>
    public enum EventAttendanceModeEnumeration
    {
        /// <summary>
        /// An event that is conducted as a combination of both offline and online modes.
        /// </summary>
        MixedEventAttendanceMode,
        /// <summary>
        /// An event that is primarily conducted offline.
        /// </summary>
        OfflineEventAttendanceMode,

        /// <summary>
        /// An event that is primarily conducted online
        /// </summary>
        OnlineEventAttendanceMode,
    }
}
