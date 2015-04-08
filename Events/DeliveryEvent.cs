#region License
// Copyright (c) 2015 1010Tires.com
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

using MXTires.Microdata.Intangible.Enumeration;
using Newtonsoft.Json;
namespace MXTires.Microdata.Events
{
    /// <summary>
    /// Event type: Delivery event.
    /// An event involving the delivery of an item.
    /// </summary>
    public class DeliveryEvent : Event
    {
        /// <summary>
        /// Text - Password, PIN, or access code needed for delivery (e.g. from a locker).
        /// </summary>
        [JsonProperty("accessCode")]
        public string AccessCode { get; set; }

        /// <summary>
        /// DateTime - When the item is available for pickup from the store, locker, etc.
        /// </summary>
        [JsonProperty("availableFrom")]
        public string AvailableFrom { get; set; }

        /// <summary>
        /// DateTime - After this date, the item will no longer be available for pickup.
        /// </summary>
        [JsonProperty("availableThrough")]
        public string AvailableThrough { get; set; }

        /// <summary>
        /// DeliveryMethod - Method used for delivery or shipping.
        /// </summary>
        [JsonProperty("hasDeliveryMethod")]
        public DeliveryMethod? HasDeliveryMethod { get; set; }
    }
}