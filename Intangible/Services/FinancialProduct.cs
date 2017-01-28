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
using Newtonsoft.Json;

namespace MXTires.Microdata.Intangible.Services
{
    /// <summary>
    /// A technical article - Example: How-to (task) topics, step-by-step, procedural troubleshooting, specifications, etc.
    /// </summary>
    public class FinancialProduct : Service
    {
        object annualPercentageRate;
        /// <summary>
        /// Number or QuantitativeValue - The annual rate that is charged for borrowing (or made by investing), expressed as a single percentage number that represents the actual yearly cost of funds over the term of a loan. This includes any fees or additional costs associated with the transaction.
        /// </summary>
        [JsonProperty("annualPercentageRate")]
        public object AnnualPercentageRate { get; set; }

        /// <summary>
        /// Text  or URL - Description of fees, commissions, and other terms applied either to a class of financial product, or by a financial service organization.
        /// </summary>
        [JsonProperty("feesAndCommissionsSpecification")]
        public String FeesAndCommissionsSpecification { get; set; }

        object interestRate;
        /// <summary>
        /// Number  or QuantitativeValue - The interest rate, charged or paid, applicable to the financial product. Note: This is different from the calculated annualPercentageRate.
        /// </summary>
        [JsonProperty("interestRate")]
        public object InterestRate { get; set; }
    }
}
