#region License
// Copyright (c) 2023 1010Tires.com
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
using MXTires.Microdata.Intangible.StructuredValues;
using MXTires.Microdata.Intangible.Enumeration;

namespace MXTires.Microdata.Intangible
{
    /// <summary>
    /// A MerchantReturnPolicy provides information about product return policies associated with an <see cref="Organization"/> ,  <see cref="Product"/>, or  <see cref="Offer"/>.
    /// </summary>
    public class MerchantReturnPolicy : Thing
    {
        /// <summary>
        /// PropertyValue - A property-value pair representing an additional characteristic of the entity, e.g.a product feature or another characteristic for which there is no matching property in schema.org.
        /// </summary>
        /// <remarks> Note: Publishers should be aware that applications designed to use specific schema.org properties(e.g. https://schema.org/width, https://schema.org/color, https://schema.org/gtin13, ...) will typically expect such data to be provided using those properties, rather than using the generic property/value mechanism.</remarks>
        [JsonProperty("additionalProperty")]
        public PropertyValue AdditionalProperty { get; set; }

        /// <summary>
        /// Country  or Text A country where a particular merchant return policy applies to, for example the two-letter ISO 3166-1 alpha-2 country code.
        /// </summary>
        [JsonProperty("applicableCountry")]
        public object applicableCountry { get; set; }

        /// <summary>
        /// ReturnFeesEnumeration   The type of return fees if the product is returned due to customer remorse.
        /// </summary>
        [JsonProperty("customerRemorseReturnFees")]
        public ReturnFeesEnumeration CustomerRemorseReturnFees { get; set; }

        /// <summary>
        /// ReturnLabelSourceEnumeration    The method (from an enumeration) by which the customer obtains a return shipping label for a product returned due to customer remorse.
        /// </summary>
        [JsonProperty("customerRemorseReturnLabelSource")]
        public ReturnLabelSourceEnumeration CustomerRemorseReturnLabelSource { get; set; }

        /// <summary>
        /// MonetaryAmount  The amount of shipping costs if a product is returned due to customer remorse.Applicable when property customerRemorseReturnFees equals ReturnShippingFees.
        /// </summary>
        [JsonProperty("customerRemorseReturnShippingFeesAmount")]
        public MonetaryAmount CustomerRemorseReturnShippingFeesAmount { get; set; }

        /// <summary>
        ///  Boolean Are in-store returns offered? (For more advanced return methods use the returnMethod property.)
        /// </summary>
        [JsonProperty("inStoreReturnsOffered")]
        public bool? InStoreReturnsOffered { get; set; }

        /// <summary>
        /// OfferItemCondition  A predefined value from OfferItemCondition specifying the condition of the product or service, or the products or services included in the offer.
        /// Also used for product return policies to specify the condition of products accepted for returns.
        /// </summary>
        [JsonProperty("itemCondition")]
        public OfferItemCondition ItemCondition { get; set; }

        /// <summary>
        /// ReturnFeesEnumeration - The type of return fees for returns of defect products.
        /// </summary>
        [JsonProperty("itemDefectReturnFees")]
        public ReturnFeesEnumeration ItemDefectReturnFees { get; set; }

        /// <summary>
        /// ReturnLabelSourceEnumeration - The method (from an enumeration) by which the customer obtains a return shipping label for a defect product.
        /// </summary>
        [JsonProperty("itemDefectReturnLabelSource")]
        public ReturnLabelSourceEnumeration ItemDefectReturnLabelSource { get; set; }

        /// <summary>
        /// MonetaryAmount  Amount of shipping costs for defect product returns.Applicable when property itemDefectReturnFees equals ReturnShippingFees.
        /// </summary>
        [JsonProperty("itemDefectReturnShippingFeesAmount")]
        public MonetaryAmount ItemDefectReturnShippingFeesAmount { get; set; }

        /// <summary>
        /// Date or DateTime or Integer Specifies either a fixed return date or the number of days(from the delivery date) that a product can be returned.Used when the returnPolicyCategory property is specified as MerchantReturnFiniteReturnWindow.Supersedes productReturnDays.
        /// </summary>
        [JsonProperty("merchantReturnDays")]
        public object MerchantReturnDays { get; set; }

        /// <summary>
        /// URL Specifies a Web page or service by URL, for product returns.Supersedes productReturnLink.
        /// </summary>
        [JsonProperty("merchantReturnLink")]
        public string MerchantReturnLink { get; set; }

        /// <summary>
        ///  RefundTypeEnumeration   A refund type, from an enumerated list.
        /// </summary>
        [JsonProperty("refundType")]
        public RefundTypeEnumeration RefundType { get; set; }

        /// <summary>
        /// MonetaryAmount or Number - Use MonetaryAmount to specify a fixed restocking fee for product returns, or use Number to specify a percentage of the product price paid by the customer.
        /// </summary>
        [JsonProperty("restockingFee")]
        public object RestockingFee { get; set; }

        /// <summary>
        /// ReturnFeesEnumeration - The type of return fees for purchased products(for any return reason).
        /// </summary>
        [JsonProperty("returnFees")]
        public ReturnFeesEnumeration ReturnFees { get; set; }

        /// <summary>
        /// ReturnLabelSourceEnumeration - The method(from an enumeration) by which the customer obtains a return shipping label for a product returned for any reason.
        /// </summary>
        [JsonProperty("returnLabelSource")]
        public ReturnLabelSourceEnumeration ReturnLabelSource { get; set; }

        /// <summary>
        /// ReturnMethodEnumeration - The type of return method offered, specified from an enumeration.
        /// </summary>
        [JsonProperty("returnMethod")]
        public ReturnMethodEnumeration ReturnMethod { get; set; }

        /// <summary>
        /// MerchantReturnEnumeration - Specifies an applicable return policy(from an enumeration).
        /// </summary>
        [JsonProperty("returnPolicyCategory")]
        public MerchantReturnEnumeration ReturnPolicyCategory { get; set; }

        /// <summary>
        /// Country  or Text -  The country where the product has to be sent to for returns, for example "Ireland" using the name property of Country.You can also provide the two-letter ISO 3166-1 alpha-2 country code. Note that this can be different from the country where the product was originally shipped from or sent to.
        /// returnPolicySeasonalOverride MerchantReturnPolicySeasonalOverride    Seasonal override of a return policy.
        /// </summary>
        [JsonProperty("returnPolicyCountry")]
        public object ReturnPolicyCountry { get; set; }

        /// <summary>
        /// MonetaryAmount - Amount of shipping costs for product returns (for any reason). Applicable when property returnFees equals ReturnShippingFees.
        /// </summary>
        [JsonProperty("returnShippingFeesAmount")]
        public MonetaryAmount returnShippingFeesAmount { get; set; }
    }
}