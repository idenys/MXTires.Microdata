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
namespace MXTires.Microdata
{
    /// <summary>
    /// An automobile.
    /// </summary>
    public class Car : Vehicle
    {
        /// <summary>
        /// The ACRISS Car Classification Code is a code used by many car rental companies, for classifying vehicles. 
        /// ACRISS stands for Association of Car Rental Industry Systems and Standards.
        /// </summary>
        [JsonProperty("acrissCode")]
        public string AcrissCode { get; set; }

        /// <summary>
        /// The permitted total weight of cargo and installations (e.g. a roof rack) on top of the vehicle.
        /// Typical unit code(s): KGM for kilogram, LBR for pound
        /// Note 1: You can indicate additional information in the name of the QuantitativeValue node.
        /// Note 2: You may also link to a QualitativeValue node that provides additional information using valueReference
        /// Note 3: Note that you can use minValue and maxValue to indicate ranges.
        /// </summary>
        [JsonProperty("roofLoad")]
        public QuantitativeValue RoofLoad { get; set; }
    }
}