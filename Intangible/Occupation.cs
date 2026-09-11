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
using MXTires.Microdata.Validators;
using Newtonsoft.Json;

namespace MXTires.Microdata.Intangible
{
    /// <summary>
    /// A profession, may involve prolonged training and/or a formal qualification.
    /// </summary>
    public class Occupation : Thing
    {
        private object estimatedSalary;
        /// <summary>
        /// MonetaryAmount, MonetaryAmountDistribution, or Number - An estimated salary for a job posting or occupation, based on a variety of variables.
        /// </summary>
        [JsonProperty("estimatedSalary")]
        public object EstimatedSalary
        {
            get { return estimatedSalary; }
            set
            {
                var validator = new TypeValidator(new List<Type> { typeof(MonetaryAmount), typeof(MonetaryAmountDistribution), typeof(decimal) });
                validator.Validate(value);
                estimatedSalary = value;
            }
        }

        /// <summary>
        /// CategoryCode or Text - A category describing the job, preferably using a term from a taxonomy such as BLS O*NET-SOC.
        /// </summary>
        [JsonProperty("occupationalCategory")]
        public string OccupationalCategory { get; set; }

        /// <summary>
        /// Credential or Text - Specific qualifications required for this role or Occupation.
        /// </summary>
        [JsonProperty("qualifications")]
        public string Qualifications { get; set; }

        /// <summary>
        /// Text - Responsibilities associated with this role or Occupation.
        /// </summary>
        [JsonProperty("responsibilities")]
        public string Responsibilities { get; set; }

        /// <summary>
        /// DefinedTerm or Text - A statement of knowledge, skill, ability, task or any other assertion expressing a competency that is desired or required.
        /// </summary>
        [JsonProperty("skills")]
        public string Skills { get; set; }
    }
}
