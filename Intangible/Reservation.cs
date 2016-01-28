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
using MXTires.Microdata.Intangible.Enumeration;
using MXTires.Microdata.Validators;
using Newtonsoft.Json;

namespace MXTires.Microdata.Intangible
{
    /// <summary>
    /// Describes a reservation for travel, dining or an event. Some reservations require tickets.
    /// </summary>
    public class Reservation : Thing
    {
        /// <summary>
        /// DateTime - The date and time the reservation was booked.
        /// </summary>
        [JsonProperty("bookingTime")]
        public DateTime? BookingTime { get; set; }

        Thing broker;
        /// <summary>
        /// Person  or Organization - An entity that arranges for an exchange between a buyer and a seller.
        /// </summary>
        [JsonProperty("broker")]
        public Thing Broker
        {
            get { return this.broker; }
            set
            {
                TypeValidator validator = new TypeValidator(typeof(Organization), typeof(Person));
                validator.Validate(value);
                this.broker = value;
            }
        }

        /// <summary>
        /// DateTime - The date and time the reservation was modified.
        /// </summary>
        [JsonProperty("modifiedTime")]
        public DateTime? ModifiedTime { get; set; }

        ///Text - The currency (in 3-letter ISO 4217 format) of the price or a price component, when attached to PriceSpecification and its subtypes.
        [JsonProperty("priceCurrency")]
        public String PriceCurrency { get; set; }

        /// <summary>
        /// ProgramMembership - Any membership in a frequent flyer, hotel loyalty program, etc. being applied to the reservation.
        /// </summary>
        [JsonProperty("programMembershipUsed")]
        public ProgramMembership ProgramMembershipUsed { get; set; }

        Thing provider;
        /// <summary>
        /// Person  or Organization - The service provider, service operator, or service performer; the goods producer. Another party (a seller) may offer those services or goods on behalf of the provider. A provider may also serve as the seller. Supersedes carrier.
        /// </summary>
        [JsonProperty("provider")]
        public Thing Provider
        {
            get { return this.provider; }
            set
            {
                TypeValidator validator = new TypeValidator(typeof(Organization), typeof(Person));
                validator.Validate(value);
                this.provider = value;
            }
        }

        /// <summary>
        /// Thing - The thing -- flight, event, restaurant, etc. being reserved.
        /// </summary>
        [JsonProperty("reservationFor")]
        public Thing ReservationFor { get; set; }

        /// <summary>
        /// Text 	A unique identifier for the reservation.
        /// </summary>
        [JsonProperty("reservationId")]
        public String ReservationId { get; set; }

        /// <summary>
        /// ReservationStatusType 	The current status of the reservation.
        /// </summary>
        [JsonProperty("reservationStatus")]
        public ReservationStatusType ReservationStatus { get; set; }

        /// <summary>
        /// Ticket - A ticket associated with the reservation.
        /// </summary>
        [JsonProperty("reservedTicket")]
        public Ticket ReservedTicket { get; set; }

        object totalPrice;
        /// <summary>
        /// PriceSpecification  or Number  or Text - The total price for the reservation or ticket, including applicable taxes, shipping, etc.
        /// </summary>
        [JsonProperty("totalPrice")]
        public object TotalPrice
        {
            get { return this.totalPrice; }
            set
            {
                TypeValidator validator = new TypeValidator(new List<Type>() { typeof(PriceSpecification), typeof(Decimal), typeof(String) });
                validator.Validate(value);
                this.totalPrice = value;
            }
        }

        Thing underName;
        /// <summary>
        /// Person  or Organization - The person or organization the reservation or ticket is for.
        /// </summary>
        [JsonProperty("underName")]
        public Thing UnderName
        {
            get { return this.underName; }
            set
            {
                TypeValidator validator = new TypeValidator(typeof(Organization), typeof(Person));
                validator.Validate(value);
                this.underName = value;
            }
        }

    }
}
