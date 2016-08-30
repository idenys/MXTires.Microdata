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
using MXTires.Microdata.Validators;
using Newtonsoft.Json;

namespace MXTires.Microdata.Intangible
{
    /// <summary>
    /// An entity holding detailed information about the available bed types, 
    /// e.g. the quantity of twin beds for a hotel room. 
    /// For the single case of just one bed of a certain type, you can use bed directly with a text. See also BedType (under development).
    /// </summary>
    public class BedDetails : Thing
    {

        object numberOfBeds;
        /// <summary>
        /// Number - The quantity of the given bed type available in the HotelRoom, Suite, House, or Apartment.
        /// </summary>
        [JsonProperty("numberOfBeds")]
        public object NumberOfBeds
        {
            get { return numberOfBeds; }
            set
            {
                List<Type> typeList = new List<System.Type>() { typeof(Int32), typeof(String), typeof(float) };
                var validator = new TypeValidator(typeList);
                validator.Validate(value);
                numberOfBeds = value;
            }
        }	

        /// <summary>
        /// Text - The type of bed to which the BedDetail refers, i.e. the type of bed available in the quantity indicated by quantity
        /// </summary>
        [JsonProperty("numberOfBeds")]
        public String typeOfBed { get; set; }	
    }
}
