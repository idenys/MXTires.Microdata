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
using MXTires.Microdata.Intangible;
using MXTires.Microdata.Intangible.StructuredValues;
using Newtonsoft.Json;

namespace MXTires.Microdata
{
    /// <summary>
    /// Class Tire.
    /// </summary>
    public class Tire : Product
    {
        /// <summary>
        /// Specific product type definition
        /// </summary>
        /// <value>The type.</value>
        [JsonProperty("@type", Order = 2)]
        public new string Type { get { return "Product/Tire"; } }

        string additionalType = "http://www.productontology.org/id/Tire";
        /// <summary>
        /// Additional type of product override
        /// </summary>
        /// <value>The type of the additional.</value>
        [JsonProperty("additionalType")]
        public new string AdditionalType { get { return additionalType; } set { additionalType = value; } }

        /// <summary>
        /// Default constructor
        /// </summary>
        public Tire()
        {
            base.SameAs = new List<string>();
            SameAs.Add("http://en.wikipedia.org/wiki/Tire");
            SameAs.Add("http://www.1010tires.com/About/Tire-Tech");

            ExternalExtensions = new List<Property>() { new Property() { Name = "auto", Description = "www.1010Tires.com", } };
        }

        //[JsonProperty("speedRating")]
        //public string SpeedRating { get; set; }

        //[JsonProperty("sideWall")] public string SideWall { get; set; }
        //[JsonProperty("treadWidth")] public string TreadWidth { get; set; }
        //[JsonProperty("profile")] public string Profile { get; set; }
        //[JsonProperty("rimDiameter")] public string RimDiameter { get; set; }
        //[JsonProperty("loadIndex")] public string LoadIndex { get; set; }
        //[JsonProperty("UTQG")] public string UTQG { get; set; }
        //[JsonProperty("plyRating")] public string PlyRating { get; set; }
        //[JsonProperty("approvedRimWidthRange")] public QuantitativeValue ApprovedRimWidthRange { get; set; }

        //[JsonProperty("maxLoad")] public string MaxLoad { get; set; }

        //[JsonProperty("noiseLevel")] public string NoiseLevel { get; set; }
        //[JsonProperty("seasonDesignation")] public string SeasonDesignation { get; set; }
        //[JsonProperty("subcategory")] public string Subcategory { get; set; }
        //[JsonProperty("vehicleClassDesignation")] public string VehicleClassDesignation { get; set; }

        //[JsonProperty("runFlat")] public bool? RunFlat { get; set; }
        //[JsonProperty("studdable")] public bool? Studdable { get; set; }
        //[JsonProperty("factoryPreStudded")] public bool? FactoryPreStudded { get; set; }

        //[JsonProperty("overallDiameter")] public QuantitativeValue OverallDiameter { get; set; }

        //[JsonProperty("properties")]
        //public IList<Property> Properties { get; set; }

        


    }
}
