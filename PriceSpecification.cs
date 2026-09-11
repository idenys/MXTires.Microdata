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

using MXTires.Microdata.Intangible;
using MXTires.Microdata.Validators;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MXTires.Microdata
{
    /// <summary>
    /// Class PriceSpecification.
    /// </summary>
    public class PriceSpecification : Thing
    {

        #region Properties

        /// <summary>
        /// QuantitativeValue - The interval and unit of measurement of ordering quantities for which the offer or price specification is valid.
        /// This allows e.g. specifying that a certain freight charge is valid only for a certain quantity.
        /// </summary>
        /// <value>The eligible quantity.</value>
        [JsonProperty("eligibleQuantity")]
        public QuantitativeValue EligibleQuantity { get; set; }

        /// <summary>
        /// PriceSpecification - The transaction volume, in a monetary unit, for which the offer or price specification is valid,
        /// e.g. for indicating a minimal purchasing volume, to express free shipping above a certain order volume,
        /// or to limit the acceptance of credit cards to purchases to a certain minimal amount.
        /// </summary>
        /// <value>The eligible transaction volume.</value>
        [JsonProperty("eligibleTransactionVolume")]
        public PriceSpecification EligibleTransactionVolume { get; set; }
        /// <summary>
        /// Number 	The highest price if the price is a range.
        /// </summary>
        /// <value>The maximum price.</value>
        [JsonProperty("maxPrice")]
        public string MaxPrice { get; set; }
        /// <summary>
        /// Number 	The lowest price if the price is a range.
        /// </summary>
        /// <value>The minimum price.</value>
        [JsonProperty("minPrice")]
        public string MinPrice { get; set; }

        /// <summary>
        /// Number  or Text. The offer price of a product, or of a price component when attached to PriceSpecification and its subtypes.
        /// </summary>
        /// <value>The price.</value>
        [JsonProperty("price")]
        public string Price { get; set; }

        /// <summary>
        /// Text. The currency (in 3-letter ISO 4217 format) of the price or a price component, when attached to PriceSpecification and its subtypes.
        /// </summary>
        /// <value>The price currency.</value>
        [JsonProperty("priceCurrency")]
        public string PriceCurrency { get; set; }

        object membershipPointsEarned;
        /// <summary>
        /// Number or QuantitativeValue - The number of membership points earned by the member.
        /// If necessary, the unitText can be used to express the units the points are issued in. (E.g. stars, miles, etc.)
        /// </summary>
        /// <value>The membership points earned.</value>
        [JsonProperty("membershipPointsEarned")]
        public object MembershipPointsEarned
        {
            get { return membershipPointsEarned; }
            set
            {
                var validator = new TypeValidator(new List<Type>()
                {
                    typeof(Byte),
                    typeof(SByte),
                    typeof(Int16),
                    typeof(UInt16),
                    typeof(Int32),
                    typeof(UInt32),
                    typeof(Int64),
                    typeof(UInt64),
                    typeof(Single),
                    typeof(Double),
                    typeof(Decimal),
                    typeof(QuantitativeValue)
                });
                validator.Validate(value);
                membershipPointsEarned = value;
            }
        }

        /// <summary>
        /// MemberProgramTier - The membership program tier an Offer (or a PriceSpecification, OfferShippingDetails,
        /// or MerchantReturnPolicy under an Offer) is valid for.
        /// </summary>
        /// <value>The eligible member tier.</value>
        [JsonProperty("eligibleMemberTier")]
        public MemberProgramTier EligibleMemberTier { get; set; }

        /// <summary>
        /// MemberProgramTier - The membership program tier an Offer (or a PriceSpecification, OfferShippingDetails,
        /// or MerchantReturnPolicy under an Offer) is valid for. This is the current schema.org name for eligibleMemberTier.
        /// </summary>
        [JsonProperty("validForMemberTier")]
        public MemberProgramTier ValidForMemberTier { get; set; }

        /// <summary>
        /// The date when the item becomes valid.
        /// </summary>
        /// <value>The valid from.</value>
        [JsonProperty("validFrom")]
        public DateTime? ValidFrom { get; set; }
        
        /// <summary>
        /// The end of the validity of offer, price specification, or opening hours data.
        /// </summary>
        /// <value>The valid through.</value>
        [JsonProperty("validThrough")]
        public DateTime? ValidThrough { get; set; }

        /// <summary>
        /// Boolean 	Specifies whether the applicable value-added tax (VAT) is included in the price specification or not.
        /// </summary>
        /// <value><c>true</c> if [value added tax included]; otherwise, <c>false</c>.</value>
        [JsonProperty("valueAddedTaxIncluded")]
        public bool ValueAddedTaxIncluded { get; set; }

        #endregion
    }
}