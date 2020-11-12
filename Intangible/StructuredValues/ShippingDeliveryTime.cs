#region License
// Copyright (c) 2020 1010Tires.com
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
using System;

namespace MXTires.Microdata.Intangible.StructuredValues
{
    public class ShippingDeliveryTime : Thing
    {
        /// <summary>
        /// OpeningHoursSpecification - Days of the week when the merchant typically operates, indicated via opening hours markup.
        /// </summary>
        [JsonProperty("businessDays")]
        public OpeningHoursSpecification BusinessDays { get; set; }

        /// <summary>
        /// Time - Order cutoff time allows merchants to describe the time after which they will no longer process orders received on that day.
        /// For orders processed after cutoff time, one day gets added to the delivery time estimate.
        /// This property is expected to be most typically used via the ShippingRateSettings publication pattern.
        /// The time is indicated using the ISO-8601 Time format, e.g. "23:30:00-05:00" would represent 6:30 pm Eastern Standard Time(EST) 
        /// which is 5 hours behind Coordinated Universal Time(UTC).
        /// </summary>
        [JsonProperty("cutoffTime")]
        public DateTime? CutoffTime { get; set; }

        /// <summary>
        /// QuantitativeValue - The typical delay between the receipt of the order and the goods either leaving the warehouse or being prepared for pickup, 
        /// in case the delivery method is on site pickup.Typical properties: minValue, maxValue, unitCode(d for DAY). 
        /// This is by common convention assumed to mean business days(if a unitCode is used, coded as "d"), i.e.only counting days when the business normally operates.
        /// </summary>
        [JsonProperty("handlingTime")]
        public QuantitativeValue HandlingTime { get; set; }

        /// <summary>
        /// QuantitativeValue - The typical delay the order has been sent for delivery and the goods reach the final customer. 
        /// Typical properties: minValue, maxValue, unitCode (d for DAY).
        /// </summary>
        [JsonProperty("transitTime")]
        public QuantitativeValue TransitTime { get; set; }
    }
}
