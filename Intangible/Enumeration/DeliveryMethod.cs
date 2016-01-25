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
    /// A delivery method is a standardized procedure for transferring the product or service to the destination of fulfillment
    /// chosen by the customer. Delivery methods are characterized by the means of transportation used, and by the
    /// organization or group that is the contracting party for the sending organization or person.
    /// Commonly used values: http://purl.org/goodrelations/v1#DeliveryModeDirectDownload
    /// http://purl.org/goodrelations/v1#DeliveryModeFreight
    /// http://purl.org/goodrelations/v1#DeliveryModeMail
    /// http://purl.org/goodrelations/v1#DeliveryModeOwnFleet
    /// http://purl.org/goodrelations/v1#DeliveryModePickUp
    /// http://purl.org/goodrelations/v1#DHL
    /// http://purl.org/goodrelations/v1#FederalExpress
    /// http://purl.org/goodrelations/v1#UPS
    /// </summary>
    [Flags]
    public enum DeliveryMethod
    {
        /// <summary>
        /// The on site pickup
        /// </summary>
        OnSitePickup = 1 << 0,

        /// <summary>
        /// A DeliveryMethod in which an item is made available via locker.
        /// </summary>
        LockerDelivery = 1 << 1,

        /// <summary>
        /// The delivery mode direct download
        /// </summary>
        [EnumMember(Value = "http://purl.org/goodrelations/v1#DeliveryModeDirectDownload")]
        DeliveryModeDirectDownload = 1 << 2,

        /// <summary>
        /// The delivery mode freight
        /// </summary>
        [EnumMember(Value = "http://purl.org/goodrelations/v1#DeliveryModeFreight")]
        DeliveryModeFreight = 1 << 3,

        /// <summary>
        /// The delivery mode mail
        /// </summary>
        [EnumMember(Value = "http://purl.org/goodrelations/v1#DeliveryModeMail")]
        DeliveryModeMail = 1 << 4,

        /// <summary>
        /// The delivery mode own fleet
        /// </summary>
        [EnumMember(Value = "http://purl.org/goodrelations/v1#DeliveryModeOwnFleet")]
        DeliveryModeOwnFleet = 1 << 5,

        /// <summary>
        /// The delivery mode pick up
        /// </summary>
        [EnumMember(Value = "http://purl.org/goodrelations/v1#DeliveryModePickUp ")]
        DeliveryModePickUp = 1 << 6,

        //A private parcel service as the delivery mode available for a certain offer.
        /// <summary>
        /// The DHL
        /// </summary>
        [EnumMember(Value = "http://purl.org/goodrelations/v1#DHL")]
        Dhl = 1 << 7,

        /// <summary>
        /// The federal express
        /// </summary>
        [EnumMember(Value = "http://purl.org/goodrelations/v1#FederalExpress")]
        FederalExpress = 1 << 8,

        /// <summary>
        /// The ups
        /// </summary>
        [EnumMember(Value = "http://purl.org/goodrelations/v1#UPS")]
        UPS = 1 << 9,

        /// <summary>
        /// The purolator
        /// </summary>
        Purolator = 1 << 10
    }
}
