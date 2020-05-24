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
using MXTires.Microdata.Intangible.StructuredValues;
using Newtonsoft.Json;
namespace MXTires.Microdata
{
    /// <summary>
    /// A car is a wheeled, self-powered motor vehicle used for transportation.
    /// </summary>
    public class Vehicle : Product
    {
        /// <summary>
        /// QuantitativeValue - The available volume for cargo or luggage. For automobiles, this is usually the trunk volume.
        /// Typical unit code(s): LTR for liters, FTQ for cubic foot/feet
        /// Note: You can use minValue and maxValue to indicate ranges.
        /// </summary>
        [JsonProperty("cargoVolume")]
        public QuantitativeValue CargoVolume { get; set; }

        /// <summary>
        /// Date - The date of the first registration of the vehicle with the respective public authorities.
        /// </summary>
        [JsonProperty("dateVehicleFirstRegistered")]
        public DateTime? DateVehicleFirstRegistered { get; set; }

        /// <summary>
        /// Text  or DriveWheelConfigurationValue - The drive wheel configuration, i.e. which roadwheels will receive torque from the vehicle's engine via the drivetrain.
        /// </summary>
        [JsonProperty("driveWheelConfiguration")]
        public object DriveWheelConfiguration { get; set; }

        /// <summary>
        /// QuantitativeValue - The amount of fuel consumed for traveling a particular distance or temporal duration with the given vehicle (e.g. liters per 100 km).
        /// Note 1: There are unfortunately no standard unit codes for liters per 100 km.
        ///     Use unitText to indicate the unit of measurement, e.g. L/100 km. 
        /// Note 2: There are two ways of indicating the fuel consumption, 
        ///     fuelConsumption (e.g. 8 liters per 100 km) and fuelEfficiency (e.g. 30 miles per gallon). They are reciprocal.
        /// Note 3: Often, the absolute value is useful only when related to driving speed ("at 80 km/h") or usage pattern ("city traffic"). 
        ///     You can use valueReference to link the value for the fuel consumption to another value.
        /// </summary>
        [JsonProperty("fuelConsumption")]
        public QuantitativeValue FuelConsumption { get; set; }

        /// <summary>
        /// QuantitativeValue - The distance traveled per unit of fuel used; most commonly miles per gallon (mpg) or kilometers per liter (km/L).
        /// Note 1: There are unfortunately no standard unit codes for miles per gallon or kilometers per liter.
        ///     Use unitText to indicate the unit of measurement, e.g. mpg or km/L. 
        /// Note 2: There are two ways of indicating the fuel consumption, fuelConsumption (e.g. 8 liters per 100 km) and fuelEfficiency (e.g. 30 miles per gallon). They are reciprocal.
        /// Note 3: Often, the absolute value is useful only when related to driving speed ("at 80 km/h") or usage pattern ("city traffic"). You can use valueReference to link the value for the fuel economy to another value.
        /// </summary>
        [JsonProperty("fuelEfficiency")]
        public QuantitativeValue FuelEfficiency { get; set; }

        /// <summary>
        /// Text  or QualitativeValue  or URL - The type of fuel suitable for the engine or engines of the vehicle. If the vehicle has only one engine, this property can be attached directly to the vehicle.
        /// </summary>
        [JsonProperty("fuelType")]
        public object FuelType { get; set; }

        /// <summary>
        /// Text - A textual description of known damages, both repaired and unrepaired.
        /// </summary>
        [JsonProperty("knownVehicleDamages")]
        public object KnownVehicleDamages { get; set; }

        /// <summary>
        /// QuantitativeValue - The total distance travelled by the particular vehicle since its initial production, as read from its odometer.
        /// Typical unit code(s): KMT for kilometers, SMI for statute miles
        /// </summary>
        [JsonProperty("mileageFromOdometer")]
        public QuantitativeValue MileageFromOdometer { get; set; }

        /// <summary>
        /// Text  or Number - The number or type of airbags in the vehicle.
        /// </summary>
        [JsonProperty("NumberOfAirbags")]
        public string NumberOfAirbags { get; set; }

        /// <summary>
        /// Number  or QuantitativeValue - The number of axles.
        /// Typical unit code(s): C62
        /// </summary>
        [JsonProperty("numberOfAxles")]
        public object NumberOfAxles { get; set; }

        /// <summary>
        /// Number  or QuantitativeValue - The number of doors.
        /// Typical unit code(s): C62
        /// </summary>
        [JsonProperty("numberOfDoors")]
        public object NumberOfDoors { get; set; }

        /// <summary>
        /// Number  or QuantitativeValue - The total number of forward gears available for the transmission system of the vehicle.
        /// Typical unit code(s): C62
        /// </summary>
        [JsonProperty("numberOfForwardGears")]
        public object NumberOfForwardGears { get; set; }

        /// <summary>
        /// Number  or QuantitativeValue - The number of owners of the vehicle, including the current one.
        /// Typical unit code(s): C62
        /// </summary>
        [JsonProperty("numberOfPreviousOwners")]
        public object NumberOfPreviousOwners { get; set; }

        /// <summary>
        /// QuantitativeValue - The permitted weight of passengers and cargo, EXCLUDING the weight of the empty vehicle.
        /// Typical unit code(s) : KGM for kilogram, LBR for pound
        /// Note 1: Many databases specify the permitted TOTAL weight instead, which is the sum of weight and payload
        /// Note 2: You can indicate additional information in the name of the QuantitativeValue node.
        /// Note 3: You may also link to a QualitativeValue node that provides additional information using valueReference.
        /// Note 4: Note that you can use minValue and maxValue to indicate ranges.
        /// </summary>
        [JsonProperty("numberOfPreviousOwners")]
        public QuantitativeValue payload { get; set; }

        /// <summary>
        /// SteeringPositionValue - The position of the steering wheel or similar device (mostly for cars).
        /// </summary>
        [JsonProperty("steeringPosition")]
        public DateTime? SteeringPosition { get; set; }

        /// <summary>
        /// QuantitativeValue - The permitted vertical load(TWR) of a trailer attached to the vehicle.Also referred to as Tongue Load Rating(TLR) or Vertical Load Rating(VLR)
        /// Typical unit code(s) : KGM for kilogram, LBR for pound
        ///  Note 1: You can indicate additional information in the name of the QuantitativeValue node.
        /// Note 2: You may also link to a QualitativeValue node that provides additional information using valueReference.
        /// Note 3: Note that you can use minValue and maxValue to indicate ranges.
        /// </summary>
        [JsonProperty("tongueWeight")]
        public QuantitativeValue TongueWeight { get; set; }

        /// <summary>
        /// QuantitativeValue 	The permitted weight of a trailer attached to the vehicle.
        /// Typical unit code(s) : KGM for kilogram, LBR for pound
        /// * Note 1: You can indicate additional information in the name of the QuantitativeValue node. 
        /// * Note 2: You may also link to a QualitativeValue node that provides additional information using valueReference. 
        /// * Note 3: Note that you can use minValue and maxValue to indicate ranges.
        /// </summary>
        [JsonProperty("trailerWeight")]
        public QuantitativeValue TrailerWeight { get; set; }

        /// <summary>
        /// Text - A short text indicating the configuration of the vehicle, e.g. '5dr hatchback ST 2.5 MT 225 hp' or 'limited edition'.
        /// </summary>
        [JsonProperty("vehicleConfiguration")]
        public string VehicleConfiguration { get; set; }

        /// <summary>
        /// EngineSpecification - Information about the engine or engines of the vehicle.
        /// </summary>
        [JsonProperty("vehicleEngine")]
        public EngineSpecification VehicleEngine { get; set; }

        /// <summary>
        /// EngineSpecification - Information about the engine or engines of the vehicle.
        /// </summary>
        [JsonProperty("vehicleEngines")]
        public IList<EngineSpecification> VehicleEngines { get; set; }

        /// <summary>
        /// Text - The Vehicle Identification Number (VIN) is a unique serial number used by the automotive industry to identify individual motor vehicles.
        /// </summary>
        [JsonProperty("VehicleEngine")]
        public string VehicleIdentificationNumber { get; set; }

        /// <summary>
        /// Text - The color or color combination of the interior of the vehicle.
        /// </summary>
        [JsonProperty("vehicleInteriorColor")]
        public string VehicleInteriorColor { get; set; }

        /// <summary>
        /// Text - The type or material of the interior of the vehicle (e.g. synthetic fabric, leather, wood, etc.). While most interior types are characterized by the material used, an interior type can also be based on vehicle usage or target audience.
        /// </summary>
        [JsonProperty("vehicleInteriorType")]
        public string VehicleInteriorType { get; set; }

        /// <summary>
        /// Date - The release date of a vehicle model (often used to differentiate versions of the same make and model).
        /// </summary>
        [JsonProperty("vehicleModelDate")]
        public DateTime? VehicleModelDate { get; set; }

        /// <summary>
        /// Number  or QuantitativeValue - The number of passengers that can be seated in the vehicle, both in terms of the physical space available, and in terms of limitations set by law.
        /// Typical unit code(s): C62 for persons
        /// </summary>
        [JsonProperty("seatingCapacity")]
        public object VehicleSeatingCapacity { get; set; }

        /// <summary>
        /// QuantitativeValue - The speed range of the vehicle.If the vehicle is powered by an engine, the upper limit of the speed range (indicated by maxValue should be the maximum speed achievable under regular conditions.
        /// Typical unit code(s) : KMH for km/h, HM for mile per hour(0.447 04 m/s), KNT for knot
        /// * Note 1: Use minValue and maxValue to indicate the range.Typically, the minimal value is zero. * Note 2: There are many different ways of measuring the speed range. You can link to information about how the given value has been determined using the valueReference property.
        /// </summary>
        [JsonProperty("speed")]
        public QuantitativeValue Speed { get; set; }
        
        /// <summary>
        /// Text  or QualitativeValue  or URL - The type of component used for transmitting the power from a rotating power source to the wheels or other relevant component(s) ("gearbox" for cars).
        /// </summary>
        [JsonProperty("vehicleTransmission")]
        public object VehicleTransmission { get; set; }      

        /// <summary>
        /// The release date of a vehicle model (often used to differentiate versions of the same make and model).
        /// </summary>
        [JsonProperty("modelDate")]
        public DateTime ModelDate { get; set; }

        /// <summary>
        /// QualitativeValue  or Text  or URL - Indicates that the vehicle meets the respective emission standard.
        /// </summary>
        [JsonProperty("meetsEmissionStandard")]
        public object MeetsEmissionStandard { get; set; }

        /// <summary>
        /// Number 	The CO2 emissions in g/km. When used in combination with a QuantitativeValue, put "g/km" into the unitText property of that value, since there is no UN/CEFACT Common Code for "g/km".
        /// </summary>
        [JsonProperty("emissionsCO2")]
        public object EmissionsCO2 { get; set; }

        /// <summary>
        /// QuantitativeValue - The capacity of the fuel tank or in the case of electric cars, the battery. If there are multiple components for storage, this should indicate the total of all storage of the same type.
        /// Typical unit code(s): LTR for liters, GLL of US gallons, GLI for UK / imperial gallons, AMH for ampere-hours (for electrical vehicles).
        /// </summary>
        [JsonProperty("fuelCapacity")]
        public QuantitativeValue FuelCapacity { get; set; }

        /// <summary>
        /// QuantitativeValue - The time needed to accelerate the vehicle from a given start velocity to a given target velocity.
        /// Typical unit code(s): SEC for seconds
        /// Note: There are unfortunately no standard unit codes for seconds/0..100 km/h or seconds/0..60 mph. Simply use "SEC" for seconds and indicate the velocities in the name of the QuantitativeValue, or use valueReference with a QuantitativeValue of 0..60 mph or 0..100 km/h to specify the reference speeds.
        /// </summary>
        [JsonProperty("accelerationTime")]
        public QuantitativeValue AccelerationTime { get; set; }

        /// <summary>
        /// QualitativeValue  or Text  or URL - Indicates the design and body style of the vehicle (e.g. station wagon, hatchback, etc.).
        /// </summary>
        [JsonProperty("bodyType")]
        public object BodyType { get; set; }

        /// <summary>
        /// Text - A callsign, as used in broadcasting and radio communications to identify people, radio and TV stations, or vehicles.
        /// </summary>
        [JsonProperty("callSign")]
        public string CallSign { get; set; }


        /// <summary>
        /// QuantitativeValue   The permitted total weight of the loaded vehicle, including passengers and cargo and the weight of the empty vehicle.
        /// Typical unit code(s) : KGM for kilogram, LBR for pound
        /// Note 1: You can indicate additional information in the name of the QuantitativeValue node.
        /// Note 2: You may also link to a QualitativeValue node that provides additional information using valueReference.
        /// Note 3: Note that you can use minValue and maxValue to indicate ranges.
        /// </summary>
        [JsonProperty("weightTotal")]
        public QuantitativeValue WeightTotal	{ get; set; }

        /// <summary>
        /// The distance between the centers of the front and rear wheels.
        /// Typical unit code(s): CMT for centimeters, MTR for meters, INH for inches, FOT for foot/feet
        /// </summary>
        [JsonProperty("wheelbase")]
        public QuantitativeValue Wheelbase	{ get; set; }  	
    }
}