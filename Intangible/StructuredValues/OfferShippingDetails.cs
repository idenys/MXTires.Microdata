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


using MXTires.Microdata.Intangible.Quantities;
using MXTires.Microdata.Validators;
using Newtonsoft.Json;

namespace MXTires.Microdata.Intangible.StructuredValues
{
    /// <summary>
    /// OfferShippingDetails represents information about shipping destinations.
    /// Multiple of these entities can be used to represent different shipping rates for different destinations:
    /// One entity for Alaska/Hawaii.A different one for continental US.A different one for all France.
    /// Multiple of these entities can be used to represent different shipping costs and delivery times.
    /// Two entities that are identical but differ in rate and time:
    /// e.g.Cheaper and slower: $5 in 5-7 days or Fast and expensive: $15 in 1-2 days
    /// </summary>
    public class OfferShippingDetails: Thing
    {
        /// <summary>
        /// ShippingDeliveryTime - The total delay between the receipt of the order and the goods reaching the final customer.
        /// </summary>
        [JsonProperty("deliveryTime")]
        public ShippingDeliveryTime DeliveryTime { get; set; }

        private Thing depth;
        /// <summary>
        /// Distance or QuantitativeValue - The depth of the item.
        /// </summary>
        [JsonProperty("depth")]
        public Thing Depth
        {
            get { return depth; }
            set
            {
                var validator = new TypeValidator(typeof(Distance), typeof(QuantitativeValue));
                validator.Validate(value);
                depth = value;
            }
        }

        /// <summary>
        /// Boolean - Indicates when shipping to a particular <see cref="ShippingDestination"/> is not available.
        /// </summary>
        [JsonProperty("doesNotShip")]
        public bool? DoesNotShip { get; set; }

        private Thing height;
        /// <summary>
        /// Distance or QuantitativeValue - The height of the item.
        /// </summary>
        [JsonProperty("height")]
        public Thing Height
        {
            get { return height; }
            set
            {
                var validator = new TypeValidator(typeof(Distance), typeof(QuantitativeValue));
                validator.Validate(value);
                height = value;
            }
        }

        /// <summary>
        /// DefinedRegion 	indicates (possibly multiple) shipping destinations. These can be defined in several ways e.g. postalCode ranges.
        /// </summary>
        [JsonProperty("shippingDestination")]
        public DefinedRegion ShippingDestination { get; set; }

        /// <summary>
        /// Text - Label to match an <see cref="OfferShippingDetails"/> with a <see cref="ShippingRateSettings"/> (within the context of a <see cref="ShippingSettingsLink"/>  cross-reference).
        /// </summary>
        [JsonProperty("shippingLabel")]
        public string ShippingLabel { get; set; }

        /// <summary>
        /// MonetaryAmount - The shipping rate is the cost of shipping to the specified destination. 
        /// Typically, the maxValue and currency values (of the <see cref="MonetaryAmount"/>) are most appropriate.
        /// </summary>
        [JsonProperty("shippingRate")]
        public MonetaryAmount ShippingRate { get; set; }

        /// <summary>
        /// URL - Link to a page containing ShippingRateSettings and DeliveryTimeSettings details.
        /// </summary>
        [JsonProperty("shippingSettingsLink")]
        public string ShippingSettingsLink { get; set; }

        /// <summary>
        /// Text - Label to match an <see cref="OfferShippingDetails"/> with a <see cref="DeliveryTimeSettings"/>(within the context of a <see cref="ShippingSettingsLink"/> cross-reference).
        /// </summary>
        [JsonProperty("transitTimeLabel")]
        public string TransitTimeLabel { get; set; }

        /// <summary>
        /// QuantitativeValue - The weight of the product or person..
        /// </summary>
        [JsonProperty("weight")]
        public QuantitativeValue Weight { get; set; }

        private Thing width;
        /// <summary>
        /// Distance or QuantitativeValue - The width of the item.
        /// </summary>
        [JsonProperty("width")]
        public Thing Width
        {
            get { return width; }
            set
            {
                var validator = new TypeValidator(typeof(Distance), typeof(QuantitativeValue));
                validator.Validate(value);
                width = value;
            }
        }
    }
}
