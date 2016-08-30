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
using System.Collections.Generic;
using MXTires.Microdata.Intangible;
using MXTires.Microdata.Validators;
using Newtonsoft.Json;

namespace MXTires.Microdata.Places.Accommodations
{
    /// <summary>
    /// A hotel room is a single room in a hotel. 
    /// </summary>
    public class HotelRoom : Room
    {
        /// <summary>
        /// QuantitativeValue - The allowed total occupancy for the accommodation in persons (including infants etc). 
        /// For individual accommodations, this is not necessarily the legal maximum but defines the permitted usage as per the contractual agreement 
        /// (e.g. a double room used by a single person). Typical unit code(s): C62 for person
        /// </summary>
        [JsonProperty("occupancy")]
        public QuantitativeValue Occupancy { get; set; }

        object bed;
        /// <summary>
        /// BedDetails  or Text - The type of bed or beds included in the accommodation. 
        /// For the single case of just one bed of a certain type, you use bed directly with a text. 
        /// If you want to indicate the quantity of a certain kind of bed, use an instance of BedDetails. 
        /// For more detailed information, use the amenityFeature property.
        /// </summary>
        [JsonProperty("bed")]
        public object Bed
        {
            get { return bed; }
            set
            {
                List<Type> typeList = new List<System.Type>() { typeof(BedDetails), typeof(String), };
                var validator = new TypeValidator(typeList);
                validator.Validate(value);
                bed = value;
            }
        }	
    }
}
