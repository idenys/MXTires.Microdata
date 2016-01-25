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
using MXTires.Microdata.Intangible.Enumeration.Medical;
using MXTires.Microdata.Intangible.Quantities;
using MXTires.Microdata.Validators;
using Newtonsoft.Json;

namespace MXTires.Microdata.Intangible
{
    /// <summary>
    /// A class, also often called a 'Type'; equivalent to rdfs:Invoice.
    /// </summary>
    public class Invoice : Thing
    {
        //Thing supersededBy;
        ///// <summary>
        ///// Enumeration  or Invoice  or Property 	Relates a term (i.e. a property, class or enumeration) to one that supersedes it.
        ///// </summary>
        //[JsonProperty("supersededBy")]
        //public Thing SupersededBy
        //{
        //    get { return this.supersededBy; }
        //    set
        //    {
        //        this.supersededBy = value;
        //    }
        //}

        /// <summary>
        /// Text - The identifier for the account the payment will be applied to.
        /// </summary>
        [JsonProperty("accountId")]
        public String AccountId { get; set; }

        /// <summary>
        /// Duration  - The time interval used to compute the invoice.
        /// </summary>
        [JsonProperty("billingPeriod")]
        public Duration BillingPeriod { get; set; }

        Thing broker;
        /// <summary>
        /// Person  or Organization - An entity that arranges for an exchange between a buyer and a seller. In most cases a broker never acquires or releases ownership of a product or service involved in an exchange. If it is not clear whether an entity is a broker, seller, or buyer, the latter two terms are preferred. Supersedes bookingAgent.
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

        object category;
        /// <summary>
        /// Text  or PhysicalActivityCategory  or Thing - A category for the item. 
        /// Greater signs or slashes can be used to informally indicate a category hierarchy.
        /// </summary>
        [JsonProperty("category")]
        public object Category
        {
            get { return category; }
            set
            {
                var validator = new TypeValidator(new List<Type>() { typeof(PhysicalActivityCategory), typeof(Thing), typeof(String) });
                validator.Validate(value);
                category = value;
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
        /// PriceSpecification - The minimum payment required at this time.
        /// </summary>
        [JsonProperty("minimumPaymentDue")]
        public PriceSpecification MinimumPaymentDue { get; set; }

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

        object paymentStatus;
        /// <summary>
        /// PaymentStatusType  or Text - The status of payment; whether the invoice has been paid or not.
        /// </summary>
        [JsonProperty("paymentStatus")]
        public object PaymentStatus
        {
            get { return paymentStatus; }
            set
            {
                var validator = new TypeValidator(typeof(PaymentStatusType), typeof(String));
                validator.Validate(value);
                paymentStatus = value;
            }
        }

        Thing provider;
        /// <summary>
        /// Person  or Organization - The service provider, service operator, or service performer; the goods producer. Another party (a seller) may offer those services or goods on behalf of the provider. A provider may also serve as the seller. Supersedes carrier.
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
        /// Order - The Order(s) related to this Invoice. One or more Orders may be combined into a single Invoice.
        /// </summary>
        [JsonProperty("referencesOrder")]
        public Order ReferencesOrder { get; set; }

        /// <summary>
        /// Date - The date the invoice is scheduled to be paid.
        /// </summary>
        [JsonProperty("scheduledPaymentDate")]
        public String ScheduledPaymentDate { get; set; }

        /// <summary>
        /// PriceSpecification - The total amount due.
        /// </summary>
        [JsonProperty("totalPaymentDue")]
        public PriceSpecification TotalPaymentDue { get; set; }
    }
}
