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
        /// QuantitativeValue - The duration of the loan or credit agreement.
        /// </summary>
        [JsonProperty("loanTerm")]
        public QuantitativeValue LoanTerm { get; set; }

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
