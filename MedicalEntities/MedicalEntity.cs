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
using MXTires.Microdata.Intangible;
using Newtonsoft.Json;

namespace MXTires.Microdata.MedicalEntities
{
    /// <summary>
    /// The most generic type of entity related to health and the practice of medicine.
    /// </summary>
    public class MedicalEntity : Thing
    {
        /// <summary>
        /// MedicalCode - A medical code for the entity, taken from a controlled vocabulary or ontology such as ICD-9, DiseasesDB, MeSH, SNOMED-CT, RxNorm, etc.
        /// </summary>
        [JsonProperty("code")]
        public string Code { get; set; }

        /// <summary>
        /// Grant - A Grant that directly or indirectly provided funding or sponsorship for this medical entity.
        /// </summary>
        [JsonProperty("funding")]
        public Grant Funding { get; set; }

        /// <summary>
        /// MedicalGuideline - A medical guideline related to this entity.
        /// </summary>
        [JsonProperty("guideline")]
        public string Guideline { get; set; }

        /// <summary>
        /// DrugLegalStatus, MedicalEnumeration, or Text - The drug or supplement's legal status, including any controlled substance schedules that apply.
        /// </summary>
        [JsonProperty("legalStatus")]
        public string LegalStatus { get; set; }

        /// <summary>
        /// MedicineSystem - The system of medicine that includes this MedicalEntity, for example 'evidence-based', 'homeopathic', 'chiropractic', etc.
        /// </summary>
        [JsonProperty("medicineSystem")]
        public string MedicineSystem { get; set; }

        /// <summary>
        /// Organization - If applicable, the organization that officially recognizes this entity as part of its endorsed system of medicine.
        /// </summary>
        [JsonProperty("recognizingAuthority")]
        public Organization RecognizingAuthority { get; set; }

        /// <summary>
        /// MedicalSpecialty - If the entity is related to practices, interventions, drugs, therapies, or medical technologies, the specialty is the relevant specialty.
        /// </summary>
        [JsonProperty("relevantSpecialty")]
        public string RelevantSpecialty { get; set; }

        /// <summary>
        /// MedicalStudy - A medical study or trial related to this entity.
        /// </summary>
        [JsonProperty("study")]
        public string Study { get; set; }
    }
}
