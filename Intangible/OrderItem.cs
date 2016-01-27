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
using MXTires.Microdata.Intangible.Enumeration;
using MXTires.Microdata.Validators;
using Newtonsoft.Json;

namespace MXTires.Microdata.Intangible
{
    /// <summary>
    /// An order item is a line of an order. It includes the quantity and shipping details of a bought offer.
    /// </summary>
    public class OrderItem : Thing
    {
        /// <summary>
        /// ParcelDelivery - The delivery of the parcel related to this order or order item.
        /// </summary>
        [JsonProperty("orderDelivery")]
        public ParcelDelivery OrderDelivery { get; set; }

        /// <summary>
        /// Text - The identifier of the order item.
        /// </summary>
        [JsonProperty("orderItemNumber")]
        public String OrderItemNumber { get; set; }

        /// <summary>
        /// OrderStatus - The current status of the order item.
        /// </summary>
        [JsonProperty("orderItemNumber")]
        public OrderStatus OrderItemStatus { get; set; }

        /// <summary>
        /// Number - The number of the item ordered. If the property is not set, assume the quantity is one.
        /// </summary>
        [JsonProperty("orderItemNumber")]
        public Int32? OrderQuantity { get; set; }

        Thing orderedItem;
        /// <summary>
        /// OrderItem  or Product - The item ordered.
        /// </summary>
        [JsonProperty("orderedItem")]
        public Thing OrderedItem
        {
            get { return orderedItem; }
            set
            {
                var validator = new TypeValidator(typeof(OrderItem), typeof(Product));
                validator.Validate(value);
                orderedItem = value;
            }
        }
    }
}
