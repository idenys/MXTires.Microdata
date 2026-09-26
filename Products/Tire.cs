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

using System.Collections.Generic;
using MXTires.Microdata.Intangible.StructuredValues;
using Newtonsoft.Json;

namespace MXTires.Microdata
{
    /// <summary>
    /// A tire. Serializes as a schema.org Product with the productontology Tire class as its additionalType.
    /// The typed tire specifications below are written into additionalProperty as PropertyValue entries,
    /// after any values set on <see cref="Product.AdditionalProperty"/>.
    /// </summary>
    public class Tire : Product
    {
        /// <summary>
        /// Specific product type definition
        /// </summary>
        /// <value>The type.</value>
        [JsonProperty("@type", Order = 2)]
        public new string Type { get { return "Product"; } }

        string additionalType = "http://www.productontology.org/id/Tire";
        /// <summary>
        /// Additional type of product override
        /// </summary>
        /// <value>The type of the additional.</value>
        [JsonProperty("additionalType")]
        public new string AdditionalType { get { return additionalType; } set { additionalType = value; } }

        /// <summary>Speed rating, e.g. "H" or "V".</summary>
        [JsonIgnore] public string SpeedRating { get; set; }

        /// <summary>Sidewall style, e.g. "Black Sidewall".</summary>
        [JsonIgnore] public string SideWall { get; set; }

        /// <summary>Section (tread) width, e.g. "225".</summary>
        [JsonIgnore] public string TreadWidth { get; set; }

        /// <summary>Profile (aspect ratio), e.g. "45".</summary>
        [JsonIgnore] public string Profile { get; set; }

        /// <summary>Rim diameter, e.g. "17".</summary>
        [JsonIgnore] public string RimDiameter { get; set; }

        /// <summary>Load index, e.g. "94" or "121/118".</summary>
        [JsonIgnore] public string LoadIndex { get; set; }

        /// <summary>Uniform Tire Quality Grading, e.g. "500 A A".</summary>
        [JsonIgnore] public string UTQG { get; set; }

        /// <summary>Ply rating or load range, e.g. "10" or "E".</summary>
        [JsonIgnore] public string PlyRating { get; set; }

        /// <summary>Approved rim width range.</summary>
        [JsonIgnore] public QuantitativeValue ApprovedRimWidthRange { get; set; }

        /// <summary>Maximum load, e.g. "1477 lbs".</summary>
        [JsonIgnore] public string MaxLoad { get; set; }

        /// <summary>Exterior noise level, e.g. "71 dB".</summary>
        [JsonIgnore] public string NoiseLevel { get; set; }

        /// <summary>Season designation, e.g. "All Season" or "Winter".</summary>
        [JsonIgnore] public string SeasonDesignation { get; set; }

        /// <summary>Subcategory, e.g. "Touring".</summary>
        [JsonIgnore] public string Subcategory { get; set; }

        /// <summary>Vehicle class designation, e.g. "P-Metric" or "LT".</summary>
        [JsonIgnore] public string VehicleClassDesignation { get; set; }

        /// <summary>Whether the tire is run-flat.</summary>
        [JsonIgnore] public bool? RunFlat { get; set; }

        /// <summary>Whether the tire can be studded.</summary>
        [JsonIgnore] public bool? Studdable { get; set; }

        /// <summary>Whether the tire comes pre-studded from the factory.</summary>
        [JsonIgnore] public bool? FactoryPreStudded { get; set; }

        /// <summary>Overall diameter.</summary>
        [JsonIgnore] public QuantitativeValue OverallDiameter { get; set; }

        [JsonProperty("additionalProperty")]
        private object SerializedAdditionalProperty
        {
            get
            {
                var specs = new List<PropertyValue>();
                AddSpec(specs, "Speed Rating", "speedRating", SpeedRating);
                AddSpec(specs, "Sidewall", "sideWall", SideWall);
                AddSpec(specs, "Tread Width", "treadWidth", TreadWidth);
                AddSpec(specs, "Profile", "profile", Profile);
                AddSpec(specs, "Rim Diameter", "rimDiameter", RimDiameter);
                AddSpec(specs, "Load Index", "loadIndex", LoadIndex);
                AddSpec(specs, "UTQG", "UTQG", UTQG);
                AddSpec(specs, "Ply Rating", "plyRating", PlyRating);
                AddSpec(specs, "Approved Rim Width Range", "approvedRimWidthRange", ApprovedRimWidthRange);
                AddSpec(specs, "Max Load", "maxLoad", MaxLoad);
                AddSpec(specs, "Noise Level", "noiseLevel", NoiseLevel);
                AddSpec(specs, "Season", "seasonDesignation", SeasonDesignation);
                AddSpec(specs, "Subcategory", "subcategory", Subcategory);
                AddSpec(specs, "Vehicle Class", "vehicleClassDesignation", VehicleClassDesignation);
                AddSpec(specs, "Run Flat", "runFlat", RunFlat);
                AddSpec(specs, "Studdable", "studdable", Studdable);
                AddSpec(specs, "Factory Pre-Studded", "factoryPreStudded", FactoryPreStudded);
                AddSpec(specs, "Overall Diameter", "overallDiameter", OverallDiameter);

                if (specs.Count == 0)
                {
                    return AdditionalProperty;
                }

                var all = new List<PropertyValue>();
                if (AdditionalProperty is PropertyValue single)
                {
                    all.Add(single);
                }
                else if (AdditionalProperty is IEnumerable<PropertyValue> many)
                {
                    all.AddRange(many);
                }
                all.AddRange(specs);
                return all;
            }
        }

        private static void AddSpec(List<PropertyValue> specs, string name, string propertyId, object value)
        {
            if (value == null || (value is string text && text.Length == 0))
            {
                return;
            }
            specs.Add(new PropertyValue { Name = name, PropertyID = propertyId, Value = value });
        }
    }
}
