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
using MXTires.Microdata.Validators;
using Newtonsoft.Json;

namespace MXTires.Microdata.Intangible
{
    /// <summary>
    /// An order is a confirmation of a transaction (a receipt), which can contain multiple line items, each represented by an Offer that has been accepted by the customer.
    /// </summary>
    public class Order : Thing
    {
        /// <summary>
        /// Offer - The offer(s) -- e.g., product, quantity and price combinations -- included in the order.
        /// </summary>
        [JsonProperty("acceptedOffer")]
        public Offer AcceptedOffer { get; set; }


        /// <summary>
        /// PostalAddress - The billing address for the order.
        /// </summary>
        [JsonProperty("billingAddress")]
        public PostalAddress BillingAddress { get; set; }

        Thing broker;
        /// <summary>
        /// Person  or Organization - An entity that arranges for an exchange between a buyer and a seller. In most cases a broker never acquires or releases ownership of a product or service involved in an exchange. If it is not clear whether an entity is a broker, seller, or buyer, the latter two terms are preferred. 
        /// Supersedes bookingAgent.
        /// </summary>
        [JsonProperty("broker")]
        public Thing Broker
        {
            get { return broker; }
            set
            {
                var validator = new TypeValidator(typeof(Organization), typeof(Person));
                validator.Validate(value);
                broker = value;
            }
        }

        /// <summary>
        /// Text - A number that confirms the given order or payment has been received.
        /// </summary>
        [JsonProperty("confirmationNumber")]
        public String ConfirmationNumber { get; set; }

        Thing customer;
        /// <summary>
        /// Person  or Organization - Party placing the order or paying the invoice.
        /// </summary>
        [JsonProperty("customer")]
        public Thing Customer
        {
            get { return customer; }
            set
            {
                var validator = new TypeValidator(typeof(Organization), typeof(Person));
                validator.Validate(value);
                customer = value;
            }
        }

        /// <summary>
        /// Number  or Text - Any discount applied (to an Order).
        /// </summary>
        [JsonProperty("discount")]
        public String Discount { get; set; }

    }
}
