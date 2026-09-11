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
using MXTires.Microdata.Intangible.Quantities;
using MXTires.Microdata.Intangible.StructuredValues;
using MXTires.Microdata.Validators;
using Newtonsoft.Json;

namespace MXTires.Microdata.Places
{
    /// <summary>
    /// The act of posing a question / favor to someone.
    /// Related actions:
    /// ReplyAction: Appears generally as a response to Accommodation
    /// </summary>
    public class Accommodation : Place
    {
        /// <summary>
        /// Text - Category of an Accommodation, following real estate conventions, e.g. RentalApartment, ApartmentComplex, etc.
        /// </summary>
        [JsonProperty("accommodationCategory")]
        public string AccommodationCategory { get; set; }

        /// <summary>
        /// FloorPlan - A floorplan of some Accommodation.
        /// </summary>
        [JsonProperty("accommodationFloorPlan")]
        public string AccommodationFloorPlan { get; set; }

        /// <summary>
        /// LocationFeatureSpecification - An amenity feature (e.g. a characteristic or service) of the Accommodation. This generic property does not make a statement about whether the feature is included in an offer for the main accommodation or available at extra costs.
        /// </summary>
        [JsonProperty("amenityFeature")]
        public new LocationFeatureSpecification AmenityFeature { get; set; }

        private object bed;
        /// <summary>
        /// BedDetails or Text - The type of bed or beds included in the accommodation.
        /// </summary>
        [JsonProperty("bed")]
        public object Bed
        {
            get { return bed; }
            set
            {
                var validator = new TypeValidator(typeof(BedDetails), typeof(string));
                validator.Validate(value);
                bed = value;
            }
        }

        /// <summary>
        /// Text - The floor level for an accommodation in a multi-storey building.
        /// </summary>
        [JsonProperty("floorLevel")]
        public string FloorLevel { get; set; }

        /// <summary>
        /// QuantitativeValue - The size of the accommodation, e.g. in square meter or squarefoot. Typical unit code(s): MTK for square meter, FTK for square foot, or YDK for square yard
        /// </summary>
        [JsonProperty("floorSize")]
        public QuantitativeValue FloorSize	{ get; set; }

        private object leaseLength;
        /// <summary>
        /// Duration or QuantitativeValue - Length of the lease for some Accommodation, either particular to some Offer or in some cases intrinsic to the property.
        /// </summary>
        [JsonProperty("leaseLength")]
        public object LeaseLength
        {
            get { return leaseLength; }
            set
            {
                var validator = new TypeValidator(typeof(Duration), typeof(QuantitativeValue));
                validator.Validate(value);
                leaseLength = value;
            }
        }

        /// <summary>
        /// Integer - The total integer number of bathrooms in some Accommodation.
        /// </summary>
        [JsonProperty("numberOfBathroomsTotal")]
        public Int32? NumberOfBathroomsTotal { get; set; }

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

        /// <summary>
        /// Number - The number of full bathrooms.
        /// </summary>
        [JsonProperty("numberOfFullBathrooms")]
        public double? NumberOfFullBathrooms { get; set; }

        /// <summary>
        /// Number - The number of partial bathrooms.
        /// </summary>
        [JsonProperty("numberOfPartialBathrooms")]
        public double? NumberOfPartialBathrooms { get; set; }

        /// <summary>
        /// QuantitativeValue - The allowed total occupancy for the accommodation in persons (including infants etc).
        /// </summary>
        [JsonProperty("occupancy")]
        public QuantitativeValue Occupancy { get; set; }

        /// <summary>
        /// Number - The year an Accommodation was constructed.
        /// </summary>
        [JsonProperty("yearBuilt")]
        public double? YearBuilt { get; set; }

        object numberOfRooms;
       /// <summary>
       ///  Number  or QuantitativeValue - The number of rooms (excluding bathrooms and closets) of the acccommodation or lodging business. Typical unit code(s): ROM for room or C62 for no unit. The type of room can be put in the unitText property of the QuantitativeValue.
       /// </summary>
        [JsonProperty("numberOfRooms")]
        public object NumberOfRooms
        {
            get { return numberOfRooms; }
            set
            {
                List<Type> typeList = new List<System.Type>() { typeof(float?), typeof(QuantitativeValue), typeof(Int32?), };
                var validator = new TypeValidator(typeList);
                validator.Validate(value);
                numberOfRooms = value;
            }
        }
	
        /// <summary>
        /// Text - Indications regarding the permitted usage of the accommodation.
        /// </summary>
        [JsonProperty("permittedUsage")]
        public String PermittedUsage{ get; set; }	

        object petsAllowed;
        /// <summary>
        /// Boolean  or Text - Indicates whether pets are allowed to enter the accommodation or lodging business. More detailed information can be put in a text value.
        /// </summary>
        [JsonProperty("petsAllowed")]
        public object PetsAllowed
        {
            get { return petsAllowed; }
            set
            {
                var validator = new TypeValidator(typeof(Boolean), typeof(String));
                validator.Validate(value);
                petsAllowed = value;
            }
        }
    }
}
