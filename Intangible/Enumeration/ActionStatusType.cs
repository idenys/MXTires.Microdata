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
    /// The status of an Action.
    /// </summary>
    [Flags]
    public enum ActionStatusType
    {
        /// <summary>
        /// An in-progress action (e.g, while watching the movie, or driving to a location).
        /// </summary>
        [EnumMember(Value = "https://schema.org/ActiveActionStatus")]
        ActiveActionStatus = 1 << 0,

        /// <summary>
        /// An action that has already taken place.
        /// </summary>
        [EnumMember(Value = "https://schema.org/CompletedActionStatus")]
        CompletedActionStatus = 1 << 1,

        /// <summary>
        /// An action that failed to complete. 
        /// The action's error property and the HTTP return code contain more information about the failure.
        /// </summary>
        [EnumMember(Value = "https://schema.org/FailedActionStatus")]
        FailedActionStatus = 1 << 2,

        /// <summary>
        /// A description of an action that is supported.
        /// </summary>
        [EnumMember(Value = "https://schema.org/PotentialActionStatus")]
        PotentialActionStatus = 1 << 3
    }
}
