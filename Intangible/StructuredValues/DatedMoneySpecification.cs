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

using Newtonsoft.Json;
namespace MXTires.Microdata.Intangible.StructuredValues
{
    /// <summary>
    /// A DatedMoneySpecification represents monetary values with optional start and end dates.
    /// For example, this could represent an employee's salary over a specific period of time.
    /// </summary>
    public class DatedMoneySpecification : Thing
    {
        /// <summary>
        /// Number - The amount of money.
        /// </summary>
        /// <value>The amount.</value>
        [JsonProperty("amount")]
        public string Amount { get; private set; }

        /// <summary>
        /// Text - The currency in which the monetary amount is expressed (in 3-letter ISO 4217 format).
        /// </summary>
        /// <value>The currency.</value>
        [JsonProperty("currency")]
        public string Currency { get; private set; }

        /// <summary>
        /// Date - The end date and time of the item (in ISO 8601 date format).
        /// </summary>
        /// <value>The end date.</value>
        [JsonProperty("endDate")]
        public string EndDate { get; private set; }

        /// <summary>
        /// Date - The start date and time of the item (in ISO 8601 date format).
        /// </summary>
        /// <value>The start date.</value>
        [JsonProperty("startDate")]
        public string StartDate { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="DatedMoneySpecification"/> class.
        /// </summary>
        /// <param name="amount">The amount.</param>
        /// <param name="currency">The currency.</param>
        /// <param name="endDate">The end date.</param>
        /// <param name="startDate">The start date.</param>
        public DatedMoneySpecification(float amount, string currency, string endDate, string startDate)
        {
            Amount = amount.ToString("c2");
            Currency = currency;
            EndDate = endDate;
            StartDate = startDate;
        }
    }
}