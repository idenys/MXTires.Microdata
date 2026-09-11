#region License
// Copyright (c) 2026 1010Tires.com
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
using MXTires.Microdata.Intangible.StructuredValues;
using MXTires.Microdata.Validators;
using Newtonsoft.Json;

namespace MXTires.Microdata.Intangible
{
    /// <summary>
    /// A membership program tier, for example a club card tier, frequent flyer tier, etc.
    /// </summary>
    public class MemberProgramTier : Thing
    {
        /// <summary>
        /// TierBenefitEnumeration - A member benefit for a particular tier of a member program.
        /// </summary>
        [JsonProperty("hasTierBenefit")]
        public string HasTierBenefit { get; set; }

        /// <summary>
        /// CreditCard, MonetaryAmount, Text, or UnitPriceSpecification - A requirement for a user to join a membership tier, for example: a CreditCard if the tier requires sign up for a credit card, a UnitPriceSpecification if the user is required to pay a periodic fee, or a MonetaryAmount if the user needs to spend a minimum amount to join the tier.
        /// </summary>
        [JsonProperty("hasTierRequirement")]
        public string HasTierRequirement { get; set; }

        /// <summary>
        /// MemberProgram - The member program this tier is a part of.
        /// </summary>
        [JsonProperty("isTierOf")]
        public MemberProgram IsTierOf { get; set; }

        private object membershipPointsEarned;
        /// <summary>
        /// Number or QuantitativeValue - The number of membership points earned by the member.
        /// </summary>
        [JsonProperty("membershipPointsEarned")]
        public object MembershipPointsEarned
        {
            get { return membershipPointsEarned; }
            set
            {
                var validator = new TypeValidator(new List<Type>()
                {
                    typeof(Byte), typeof(SByte), typeof(Int16), typeof(UInt16),
                    typeof(Int32), typeof(UInt32), typeof(Int64), typeof(UInt64),
                    typeof(Single), typeof(Double), typeof(Decimal),
                    typeof(QuantitativeValue)
                });
                validator.Validate(value);
                membershipPointsEarned = value;
            }
        }

        /// <summary>
        /// Text - A requirement for a user to join a membership tier, for example: a CreditCard if the tier requires sign up for a credit card,
        /// A textual summary of the required threshold or expectations to meet the tier.
        /// </summary>
        /// <value>The tier requirement.</value>
        [JsonProperty("tierRequirement")]
        public string TierRequirement { get; set; }
    }
}
