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

        /// <summary>
        /// Text - Code used to redeem a discount.
        /// </summary>
        [JsonProperty("discount")]
        public String DiscountCode { get; set; }

        /// <summary>
        /// Text - The currency (in 3-letter ISO 4217 format) of the discount.
        /// </summary>
        [JsonProperty("DiscountCurrency")]
        public String discountCurrency { get; set; }

        /// <summary>
        /// Boolean - Was the offer accepted as a gift for someone other than the buyer.
        /// </summary>
        [JsonProperty("isGift")]
        public Boolean? IsGift { get; set; }

        /// <summary>
        /// DateTime - Date order was placed.
        /// </summary>
        [JsonProperty("orderDate")]
        public DateTime? OrderDate { get; set; }

        /// <summary>
        /// ParcelDelivery - The delivery of the parcel related to this order or order item.
        /// </summary>
        [JsonProperty("orderDelivery")]
        public ParcelDelivery OrderDelivery { get; set; }

        /// <summary>
        /// Text - The identifier of the transaction.
        /// </summary>
        [JsonProperty("orderNumber")]
        public String OrderNumber { get; set; }

        /// <summary>
        /// OrderStatus - The current status of the order.
        /// </summary>
        [JsonProperty("orderStatus")]
        public OrderStatus OrderStatus { get; set; }

        /// <summary>
        /// OrderItem  or Product - The item ordered.
        /// </summary>
        [JsonProperty("orderedItem")]
        public Thing OrderedItem { get; set; }

        /// <summary>
        /// Invoice - The order is being paid as part of the referenced Invoice.
        /// </summary>
        [JsonProperty("partOfInvoice")]
        public Invoice PartOfInvoice { get; set; }

        /// <summary>
        /// DateTime - The date that payment is due. Supersedes paymentDue.
        /// </summary>
        [JsonProperty("paymentDueDate")]
        public DateTime? PaymentDueDate { get; set; }

        /// <summary>
        /// PaymentMethod - The name of the credit card or other method of payment for the order.
        /// </summary>
        [JsonProperty("paymentMethod")]
        public PaymentMethod PaymentMethod { get; set; }

        /// <summary>
        /// Text - An identifier for the method of payment used (e.g. the last 4 digits of the credit card).
        /// </summary>
        [JsonProperty("paymentMethodId")]
        public String PaymentMethodId { get; set; }

        /// <summary>
        /// URL - The URL for sending a payment.
        /// </summary>
        [JsonProperty("paymentUrl")]
        public String PaymentUrl { get; set; }

        Thing seller;
        /// <summary>
        /// Person or Organization - An entity which offers (sells / leases / lends / loans) the services / goods. 
        /// A seller may also be a provider. Supersedes vendor, merchant.
        /// </summary>
        [JsonProperty("seller")]
        public Thing Seller
        {
            get { return seller; }
            set
            {
                var validator = new TypeValidator(typeof(Organization), typeof(Person));
                validator.Validate(value);
                seller = value;
            }
        }
    }
}
