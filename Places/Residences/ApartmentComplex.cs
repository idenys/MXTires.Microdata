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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MXTires.Microdata.Validators;
using Newtonsoft.Json;

namespace MXTires.Microdata.Places.Residences
{
    /// <summary>
    /// Residence type: Apartment complex.
    /// </summary>
    public class ApartmentComplex : Residence
    {
        /// <summary>
        /// QuantitativeValue - Indicates the total (available plus unavailable) number of accommodation units in an ApartmentComplex, or the number of accommodation units for a specific FloorPlan.
        /// </summary>
        [JsonProperty("numberOfAccommodationUnits")]
        public QuantitativeValue NumberOfAccommodationUnits { get; set; }

        /// <summary>
        /// QuantitativeValue - Indicates the number of available accommodation units in an ApartmentComplex, or the number of accommodation units for a specific FloorPlan.
        /// </summary>
        [JsonProperty("numberOfAvailableAccommodationUnits")]
        public QuantitativeValue NumberOfAvailableAccommodationUnits { get; set; }

        private object numberOfBedrooms;
        /// <summary>
        /// Number or QuantitativeValue - The number of bedrooms.
        /// </summary>
        [JsonProperty("numberOfBedrooms")]
        public object NumberOfBedrooms
        {
            get { return numberOfBedrooms; }
            set
            {
                var validator = new TypeValidator(new List<Type>() { typeof(float?), typeof(QuantitativeValue), typeof(Int32?) });
                validator.Validate(value);
                numberOfBedrooms = value;
            }
        }

        private object petsAllowed;
        /// <summary>
        /// Boolean or Text - Indicates whether pets are allowed to enter the accommodation or lodging business. More detailed information can be put in a text value.
        /// </summary>
        [JsonProperty("petsAllowed")]
        public object PetsAllowed
        {
            get { return petsAllowed; }
            set
            {
                var validator = new TypeValidator(typeof(bool), typeof(string));
                validator.Validate(value);
                petsAllowed = value;
            }
        }
    }
}
