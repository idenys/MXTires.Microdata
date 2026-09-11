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
using MXTires.Microdata.Intangible.Quantities;
using MXTires.Microdata.Validators;
using Newtonsoft.Json;

namespace MXTires.Microdata.Intangible.Services
{
    /// <summary>
    /// A financial product for the loaning of an amount of money under agreed terms and charges.
    /// </summary>
    public class LoanOrCredit : FinancialProduct
    {
        /// <summary>
        /// MonetaryAmount or Number - The amount of money.
        /// </summary>
        [JsonProperty("amount")]
        public object Amount { get; set; }

        /// <summary>
        /// Text - The currency in which the monetary amount is expressed (in 3-letter ISO 4217 format).
        /// </summary>
        [JsonProperty("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// Duration - A grace period is the window during which the borrower can make payments that are not yet due without incurring late fees.
        /// </summary>
        [JsonProperty("gracePeriod")]
        public Duration GracePeriod { get; set; }

        /// <summary>
        /// RepaymentSpecification - A form of paying back money previously borrowed from a lender, usually in form of periodical payments.
        /// </summary>
        [JsonProperty("loanRepaymentForm")]
        public string LoanRepaymentForm { get; set; }

        /// <summary>
        /// Text or URL - The type of a loan or credit.
        /// </summary>
        [JsonProperty("loanType")]
        public string LoanType { get; set; }

        /// <summary>
        /// QuantitativeValue - The duration of the loan or credit agreement.
        /// </summary>
        [JsonProperty("loanTerm")]
        public QuantitativeValue LoanTerm { get; set; }

        /// <summary>
        /// Boolean - The only way you can then collect on the loan is through possession or repossession of the collateral.
        /// </summary>
        [JsonProperty("recourseLoan")]
        public bool? RecourseLoan { get; set; }

        /// <summary>
        /// Boolean - Whether the terms for payment of interest can be renegotiated during the life of the loan.
        /// </summary>
        [JsonProperty("renegotiableLoan")]
        public bool? RenegotiableLoan { get; set; }

        object requiredCollateral;
        /// <summary>
        /// Text  or Thing - Assets required to secure loan or credit repayments. It may take form of third party pledge, goods, financial instruments (cash, securities, etc.)
        /// </summary>
        [JsonProperty("requiredCollateral")]
        public object RequiredCollateral
        {
            get { return requiredCollateral; }
            set
            {
                var validator = new TypeValidator(typeof(string), typeof(Thing));
                validator.Validate(value);
                requiredCollateral = value;
            }
        }
    }
}
