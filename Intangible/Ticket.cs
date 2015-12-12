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

using System;
using MXTires.Microdata.Validators;
using Newtonsoft.Json;
namespace MXTires.Microdata.Intangible
{
    /// <summary>
    /// Class Ticket.
    /// </summary>
    public class Ticket : Thing
    {
        /// <summary>
        /// DateTime - The date the ticket was issued.
        /// </summary>
        /// <value>The date issued.</value>
        [JsonProperty("dateIssued")]
        public DateTime? DateIssued { get; set; }

        /// <summary>
        /// Organization 	The organization issuing the ticket or permit.
        /// </summary>
        /// <value>The issued by.</value>
        [JsonProperty("issuedBy")]
        public Organization IssuedBy { get; set; }

        /// <summary>
        /// Text - The currency (in 3-letter ISO 4217 format) of the price or a price component, when attached to PriceSpecification and its subtypes.
        /// </summary>
        /// <value>The price currency.</value>
        [JsonProperty("priceCurrency")]
        public string PriceCurrency { get; set; }

        /// <summary>
        /// Text - The unique identifier for the ticket.
        /// </summary>
        /// <value>The ticket number.</value>
        [JsonProperty("ticketNumber")]
        public string TicketNumber { get; set; }

        /// <summary>
        /// Text  or URL - Reference to an asset (e.g., Barcode, QR code image or PDF) usable for entrance.
        /// </summary>
        /// <value>The ticket token.</value>
        [JsonProperty("ticketToken")]
        public string TicketToken { get; set; }

        /// <summary>
        /// Seat - The seat associated with the ticket.
        /// </summary>
        /// <value>The ticketed seat.</value>
        [JsonProperty("ticketedSeat")]
        public Seat TicketedSeat { get; set; }

        /// <summary>
        /// Text  or  PriceSpecification  or  Number 	The total price for the reservation or ticket, including applicable taxes, shipping, etc.
        /// </summary>
        /// <value>The total price.</value>
        [JsonProperty("totalPrice")]
        public object TotalPrice { get; set; }

        /// <summary>
        /// The under name
        /// </summary>
        private Thing underName;
        /// <summary>
        /// Organization  or Person - The person or organization the reservation or ticket is for.
        /// </summary>
        /// <value>The name of the under.</value>
        [JsonProperty("underName")]
        public Thing UnderName
        {
            get { return underName; }
            set
            {
                var validator = new TypeValidator(typeof(Organization), typeof(Person));
                validator.Validate(value);
                underName = value;
            }
        }
    }
}