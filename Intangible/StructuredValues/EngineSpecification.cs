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

using System.Collections.Generic;
using MXTires.Microdata.Validators;
using Newtonsoft.Json;

namespace MXTires.Microdata.Intangible.StructuredValues
{
    /// <summary>
    /// Information about the engine of the vehicle. A vehicle can have multiple engines represented by multiple engine specification entities.
    /// </summary>
    public class EngineSpecification : Thing
    {
        /// <summary>
        /// QuantitativeValue - The volume swept by all of the pistons inside the cylinders of an internal combustion engine in a single movement.
        /// </summary>
        [JsonProperty("engineDisplacement")]
        public QuantitativeValue EngineDisplacement { get; set; }

        /// <summary>
        /// QuantitativeValue - The power of the vehicle's engine. Typical unit code(s): KWT for kilowatt, N12 for horsepower (hp).
        /// </summary>
        [JsonProperty("enginePower")]
        public QuantitativeValue EnginePower { get; set; }

        /// <summary>
        /// QualitativeValue, Text, or URL - The type of engine or engines powering the vehicle.
        /// </summary>
        [JsonProperty("engineType")]
        public string EngineType { get; set; }

        /// <summary>
        /// QuantitativeValue - The torque (turning force) of the vehicle's engine. Typical unit code(s): NU for newton-meter (N-m), F17 for pound-force per foot, or F48 for pound-force per inch.
        /// </summary>
        [JsonProperty("torque")]
        public QuantitativeValue Torque { get; set; }

        object fuelType;
        /// <summary>
        /// QualitativeValue  or Text  or URL - The type of fuel suitable for the engine or engines of the vehicle. 
        /// If the vehicle has only one engine, this property can be attached directly to the vehicle.
        /// </summary>
        [JsonProperty("fuelType")]
        public object FuelType
        {
            get { return this.fuelType; }
            set
            {
                this.fuelType = value;
            }
        }
    }
}
