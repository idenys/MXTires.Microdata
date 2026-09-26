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

using System.Runtime.Serialization;

namespace MXTires.Microdata.Intangible.Enumeration
{
    /// <summary>
    /// NonprofitType enumerates several kinds of official non-profit types of which a non-profit organization can be.
    /// </summary>
    public enum NonprofitType
    {
        [EnumMember(Value = "https://schema.org/CharitableIncorporatedOrganization")]
        CharitableIncorporatedOrganization,
        [EnumMember(Value = "https://schema.org/LimitedByGuaranteeCharity")]
        LimitedByGuaranteeCharity,
        [EnumMember(Value = "https://schema.org/Nonprofit501a")]
        Nonprofit501a,
        [EnumMember(Value = "https://schema.org/Nonprofit501c1")]
        Nonprofit501c1,
        [EnumMember(Value = "https://schema.org/Nonprofit501c10")]
        Nonprofit501c10,
        [EnumMember(Value = "https://schema.org/Nonprofit501c11")]
        Nonprofit501c11,
        [EnumMember(Value = "https://schema.org/Nonprofit501c12")]
        Nonprofit501c12,
        [EnumMember(Value = "https://schema.org/Nonprofit501c13")]
        Nonprofit501c13,
        [EnumMember(Value = "https://schema.org/Nonprofit501c14")]
        Nonprofit501c14,
        [EnumMember(Value = "https://schema.org/Nonprofit501c15")]
        Nonprofit501c15,
        [EnumMember(Value = "https://schema.org/Nonprofit501c16")]
        Nonprofit501c16,
        [EnumMember(Value = "https://schema.org/Nonprofit501c17")]
        Nonprofit501c17,
        [EnumMember(Value = "https://schema.org/Nonprofit501c18")]
        Nonprofit501c18,
        [EnumMember(Value = "https://schema.org/Nonprofit501c19")]
        Nonprofit501c19,
        [EnumMember(Value = "https://schema.org/Nonprofit501c2")]
        Nonprofit501c2,
        [EnumMember(Value = "https://schema.org/Nonprofit501c20")]
        Nonprofit501c20,
        [EnumMember(Value = "https://schema.org/Nonprofit501c21")]
        Nonprofit501c21,
        [EnumMember(Value = "https://schema.org/Nonprofit501c22")]
        Nonprofit501c22,
        [EnumMember(Value = "https://schema.org/Nonprofit501c23")]
        Nonprofit501c23,
        [EnumMember(Value = "https://schema.org/Nonprofit501c24")]
        Nonprofit501c24,
        [EnumMember(Value = "https://schema.org/Nonprofit501c25")]
        Nonprofit501c25,
        [EnumMember(Value = "https://schema.org/Nonprofit501c26")]
        Nonprofit501c26,
        [EnumMember(Value = "https://schema.org/Nonprofit501c27")]
        Nonprofit501c27,
        [EnumMember(Value = "https://schema.org/Nonprofit501c28")]
        Nonprofit501c28,
        [EnumMember(Value = "https://schema.org/Nonprofit501c3")]
        Nonprofit501c3,
        [EnumMember(Value = "https://schema.org/Nonprofit501c4")]
        Nonprofit501c4,
        [EnumMember(Value = "https://schema.org/Nonprofit501c5")]
        Nonprofit501c5,
        [EnumMember(Value = "https://schema.org/Nonprofit501c6")]
        Nonprofit501c6,
        [EnumMember(Value = "https://schema.org/Nonprofit501c7")]
        Nonprofit501c7,
        [EnumMember(Value = "https://schema.org/Nonprofit501c8")]
        Nonprofit501c8,
        [EnumMember(Value = "https://schema.org/Nonprofit501c9")]
        Nonprofit501c9,
        [EnumMember(Value = "https://schema.org/Nonprofit501d")]
        Nonprofit501d,
        [EnumMember(Value = "https://schema.org/Nonprofit501e")]
        Nonprofit501e,
        [EnumMember(Value = "https://schema.org/Nonprofit501f")]
        Nonprofit501f,
        [EnumMember(Value = "https://schema.org/Nonprofit501k")]
        Nonprofit501k,
        [EnumMember(Value = "https://schema.org/Nonprofit501n")]
        Nonprofit501n,
        [EnumMember(Value = "https://schema.org/Nonprofit501q")]
        Nonprofit501q,
        [EnumMember(Value = "https://schema.org/Nonprofit527")]
        Nonprofit527,
        [EnumMember(Value = "https://schema.org/NonprofitANBI")]
        NonprofitANBI,
        [EnumMember(Value = "https://schema.org/NonprofitSBBI")]
        NonprofitSBBI,
        [EnumMember(Value = "https://schema.org/UKTrust")]
        UKTrust,
        [EnumMember(Value = "https://schema.org/UnincorporatedAssociationCharity")]
        UnincorporatedAssociationCharity,
    }
}
