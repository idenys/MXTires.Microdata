#region License
// Copyright (c) 2019 1010Tires.com
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

namespace MXTires.Microdata.CreativeWorks
{
    /// <summary>
    /// A strategy of regulating the intake of food to achieve or maintain a specific health-related goal.
    /// </summary>
    public class Diet : CreativeWork
    {
        /// <summary>
        /// Nutritional information specific to the dietary plan. May include dietary recommendations on what foods to avoid, what foods to consume, and specific alterations/deviations from the USDA or other regulatory body's approved dietary guidelines.
        /// </summary>
        [JsonProperty("dietFeatures")]
        public string DietFeatures {get;set;}

        Thing endorsers;
        /// <summary>
        /// Person or Organization - People or organizations that endorse the plan.
        /// </summary>
        [JsonProperty("endorsers")]
        public Thing Endorsers
        {
            get { return endorsers; }
            set
            {
                var validator = new TypeValidator(typeof(Organization), typeof(Person));
                validator.Validate(value);
                endorsers = value;
            }
        }

        /// <summary>
        /// Text - Medical expert advice related to the plan.
        /// </summary>
        [JsonProperty("expertConsiderations")]
        public string ExpertConsiderations { get; set; }

        /// <summary>
        /// Text - Descriptive information establishing the overarching theory/philosophy of the plan. May include the rationale for the name, the population where the plan first came to prominence, etc.
        /// </summary>
        [JsonProperty("overview")]
        public string Overview { get; set; }

        /// <summary>
        /// Text - Specific physiologic benefits associated to the plan.
        /// </summary>
        [JsonProperty("physiologicalBenefits")]
        public string PhysiologicalBenefits { get; set; }

        /// <summary>
        /// Text - Proprietary name given to the diet plan, typically by its originator or creator.
        /// </summary>
        [JsonProperty("proprietaryName")]
        public string ProprietaryName { get; set; }

        /// <summary>
        /// Text - Specific physiologic risks associated to the plan.
        /// </summary>
        [JsonProperty("risks")]
        public string Risks { get; set; }
    }
}
