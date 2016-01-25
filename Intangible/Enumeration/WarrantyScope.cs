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
using System.Runtime.Serialization;

//Acknowledgments
//This class is derived from the GoodRelations Vocabulary for E-Commerce, created by Martin Hepp. GoodRelations is a data model for sharing e-commerce data on the Web that can be expressed in a variety of syntaxes, including RDFa and HTML5 Microdata. More information about GoodRelations can be found at http://purl.org/goodrelations/

namespace MXTires.Microdata.Intangible.Enumeration
{
    /// <summary>
    /// A range of of services that will be provided to a customer free of charge in case of a defect or malfunction of a product. Commonly used values: http://purl.org/goodrelations/v1#Labor-BringIn http://purl.org/goodrelations/v1#PartsAndLabor-BringIn http://purl.org/goodrelations/v1#PartsAndLabor-PickUp
    /// </summary>
    [Flags]
    public enum WarrantyScope
    {
        /// <summary>
        /// The labor bring in
        /// </summary>
        [EnumMember(Value = "http://purl.org/goodrelations/v1#Labor-BringIn")]
        LaborBringIn = 1 << 0,
        /// <summary>
        /// The parts and labor bring in
        /// </summary>
        [EnumMember(Value = "http://purl.org/goodrelations/v1#PartsAndLabor-BringIn")]
        PartsAndLaborBringIn = 1 << 1,
        /// <summary>
        /// The parts and labor pick up
        /// </summary>
        [EnumMember(Value = "http://purl.org/goodrelations/v1#PartsAndLabor-PickUp")]
        PartsAndLaborPickUp = 1 << 2,

    }
}