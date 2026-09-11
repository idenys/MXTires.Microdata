#region License
// Copyright (c) 2017 1010Tires.com
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
using MXTires.Microdata.Intangible.StructuredValues;
using MXTires.Microdata.Validators;
using Newtonsoft.Json;

namespace MXTires.Microdata.Intangible.Services
{
    /// <summary>
    /// A payment method using a credit, debit, store or other card to associate the payment with an account.
    /// </summary>
    public class PaymentCard : FinancialProduct
    {
        private object cashBack;
        /// <summary>
        /// Boolean or Number - A cardholder benefit that pays the cardholder a small percentage of their purchase back.
        /// </summary>
        [JsonProperty("cashBack")]
        public object CashBack
        {
            get { return cashBack; }
            set
            {
                var validator = new TypeValidator(typeof(bool), typeof(decimal));
                validator.Validate(value);
                cashBack = value;
            }
        }

        /// <summary>
        /// Boolean - A secure method for consumers to purchase products or services via debit, credit or smartcards by using RFID or NFC technology.
        /// </summary>
        [JsonProperty("contactlessPayment")]
        public bool? ContactlessPayment { get; set; }

        /// <summary>
        /// MonetaryAmount - A floor limit is the amount of money above which credit card transactions must be authorized.
        /// </summary>
        [JsonProperty("floorLimit")]
        public MonetaryAmount FloorLimit { get; set; }

        private object monthlyMinimumRepaymentAmount;
        /// <summary>
        /// MonetaryAmount or Number - The minimum payment is the lowest amount of money that one is required to pay on a monthly bill.
        /// </summary>
        [JsonProperty("monthlyMinimumRepaymentAmount")]
        public object MonthlyMinimumRepaymentAmount
        {
            get { return monthlyMinimumRepaymentAmount; }
            set
            {
                var validator = new TypeValidator(typeof(MonetaryAmount), typeof(decimal));
                validator.Validate(value);
                monthlyMinimumRepaymentAmount = value;
            }
        }
    }
}
