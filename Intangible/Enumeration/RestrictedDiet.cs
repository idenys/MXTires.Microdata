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
using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace MXTires.Microdata.Intangible.Enumeration
{
    /// <summary>
    /// A diet restricted to certain foods or preparations for cultural, religious, health or lifestyle reasons.
    /// </summary>
    [Flags]
    public enum RestrictedDiet
    {
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        [EnumMember(Value = "https://schema.org/DiabeticDiet")]
        DiabeticDiet = 1 << 0,
        [EnumMember(Value = "https://schema.org/GlutenFreeDiet")]
        GlutenFreeDiet = 1 << 1,
        [EnumMember(Value = "https://schema.org/HalalDiet")]
        HalalDiet = 1 << 2,
        [EnumMember(Value = "https://schema.org/HinduDiet")]
        HinduDiet = 1 << 3,
        [EnumMember(Value = "https://schema.org/KosherDiet")]
        KosherDiet = 1 << 4,
        [EnumMember(Value = "https://schema.org/LowCalorieDiet")]
        LowCalorieDiet = 1 << 5,
        [EnumMember(Value = "https://schema.org/LowFatDiet")]
        LowFatDiet = 1 << 6,
        [EnumMember(Value = "https://schema.org/LowLactoseDiet")]
        LowLactoseDiet = 1 << 7,
        [EnumMember(Value = "https://schema.org/LowSaltDiet")]
        LowSaltDiet = 1 << 8,
        [EnumMember(Value = "https://schema.org/VeganDiet")]
        VeganDiet = 1 << 9,
        [EnumMember(Value = "https://schema.org/VegetarianDiet")]
        VegetarianDiet = 1 << 10,
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
    }
}
