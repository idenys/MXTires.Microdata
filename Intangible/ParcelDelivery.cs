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
using System.Collections.Generic;
using MXTires.Microdata.Events;
using MXTires.Microdata.Intangible.Enumeration;
using MXTires.Microdata.Validators;
using Newtonsoft.Json;

namespace MXTires.Microdata.Intangible
{
    /// <summary>
    /// The delivery of a parcel either via the postal service or a commercial service.
    /// </summary>
    public class ParcelDelivery : Thing
    {
        /// <summary>
        /// PostalAddress - Destination address.
        /// </summary>
        [JsonProperty("deliveryAddress")]
        public PostalAddress DeliveryAddress { get; set; }

        /// <summary>
        /// DeliveryEvent - New entry added as the package passes through each leg of its journey (from shipment to final delivery).
        /// </summary>
        [JsonProperty("deliveryStatus")]
        public DeliveryEvent DeliveryStatus { get; set; }

        /// <summary>
        /// DateTime - The earliest date the package may arrive.
        /// </summary>
        [JsonProperty("expectedArrivalFrom")]
        public DateTime? ExpectedArrivalFrom { get; set; }

        /// <summary>
        /// DateTime - The latest date the package may arrive.
        /// </summary>
        [JsonProperty("expectedArrivalUntil")]
        public DateTime? ExpectedArrivalUntil { get; set; }

        /// <summary>
        /// DeliveryMethod 	Method used for delivery or shipping.
        /// </summary>
        [JsonProperty("hasDeliveryMethod")]
        public DeliveryMethod HasDeliveryMethod { get; set; }

        /// <summary>
        /// Product - Item(s) being shipped.
        /// </summary>
        [JsonProperty("itemShipped")]
        public Product ItemShipped { get; set; }

        /// <summary>
        /// PostalAddress - Shipper's address.
        /// </summary>
        [JsonProperty("originAddress")]
        public PostalAddress OriginAddress { get; set; }

        /// <summary>
        /// Order - The overall order the items in this delivery were included in.
        /// </summary>
        [JsonProperty("partOfOrder")]
        public Order PartOfOrder { get; set; }

        Thing provider;
        /// <summary>
        /// The service provider, service operator, or service performer; the goods producer. Another party (a seller) may offer those services or goods on behalf of the provider. A provider may also serve as the seller. Supersedes carrier.
        /// </summary>
        [JsonProperty("provider")]
        public Thing Provider
        {
            get { return provider; }
            set
            {
                var validator = new TypeValidator(typeof(Organization), typeof(Person));
                validator.Validate(value);
                provider = value;
            }
        }

        /// <summary>
        /// Text - Shipper tracking number.
        /// </summary>
        [JsonProperty("trackingNumber")]
        public String TrackingNumber { get; set; }

        /// <summary>
        /// URL - Tracking url for the parcel delivery.
        /// </summary>
        [JsonProperty("trackingUrl")]
        public String TrackingUrl { get; set; }
    }
}
