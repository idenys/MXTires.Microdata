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
using System.Runtime.Serialization;

namespace MXTires.Microdata.Intangible.Enumeration
{
    /// <summary>
    /// Any specific branch of medical science or practice.
    /// Medical specialties include clinical specialties that pertain to particular organ systems and their respective disease states,
    /// as well as allied health specialties.
    /// Enumerated type.
    /// </summary>
    public enum MedicalSpecialty
    {
        /// <summary>
        /// The anesthesia
        /// </summary>
        [EnumMember(Value = "https://schema.org/Anesthesia")]
        Anesthesia,
        /// <summary>
        /// The cardiovascular
        /// </summary>
        [EnumMember(Value = "https://schema.org/Cardiovascular")]
        Cardiovascular,
        /// <summary>
        /// The community health
        /// </summary>
        [EnumMember(Value = "https://schema.org/CommunityHealth")]
        CommunityHealth,
        /// <summary>
        /// The dentistry
        /// </summary>
        [EnumMember(Value = "https://schema.org/Dentistry")]
        Dentistry,
        /// <summary>
        /// The dermatologic
        /// </summary>
        [Obsolete("Superseded in schema.org by Dermatology.")]
        [EnumMember(Value = "https://schema.org/Dermatologic")]
        Dermatologic,
        /// <summary>
        /// The diet nutrition
        /// </summary>
        [EnumMember(Value = "https://schema.org/DietNutrition")]
        DietNutrition,
        /// <summary>
        /// The emergency
        /// </summary>
        [EnumMember(Value = "https://schema.org/Emergency")]
        Emergency,
        /// <summary>
        /// The endocrine
        /// </summary>
        [EnumMember(Value = "https://schema.org/Endocrine")]
        Endocrine,
        /// <summary>
        /// The gastroenterologic
        /// </summary>
        [EnumMember(Value = "https://schema.org/Gastroenterologic")]
        Gastroenterologic,
        /// <summary>
        /// The genetic
        /// </summary>
        [EnumMember(Value = "https://schema.org/Genetic")]
        Genetic,
        /// <summary>
        /// The geriatric
        /// </summary>
        [EnumMember(Value = "https://schema.org/Geriatric")]
        Geriatric,
        /// <summary>
        /// The gynecologic
        /// </summary>
        [EnumMember(Value = "https://schema.org/Gynecologic")]
        Gynecologic,
        /// <summary>
        /// The hematologic
        /// </summary>
        [EnumMember(Value = "https://schema.org/Hematologic")]
        Hematologic,
        /// <summary>
        /// The infectious
        /// </summary>
        [EnumMember(Value = "https://schema.org/Infectious")]
        Infectious,
        /// <summary>
        /// The laboratory science
        /// </summary>
        [EnumMember(Value = "https://schema.org/LaboratoryScience")]
        LaboratoryScience,
        /// <summary>
        /// The midwifery
        /// </summary>
        [EnumMember(Value = "https://schema.org/Midwifery")]
        Midwifery,
        /// <summary>
        /// The musculoskeletal
        /// </summary>
        [EnumMember(Value = "https://schema.org/Musculoskeletal")]
        Musculoskeletal,
        /// <summary>
        /// The neurologic
        /// </summary>
        [EnumMember(Value = "https://schema.org/Neurologic")]
        Neurologic,
        /// <summary>
        /// The nursing
        /// </summary>
        [EnumMember(Value = "https://schema.org/Nursing")]
        Nursing,
        /// <summary>
        /// The obstetric
        /// </summary>
        [EnumMember(Value = "https://schema.org/Obstetric")]
        Obstetric,
        /// <summary>
        /// The occupational therapy
        /// </summary>
        [EnumMember(Value = "https://schema.org/OccupationalTherapy")]
        OccupationalTherapy,
        /// <summary>
        /// The oncologic
        /// </summary>
        [EnumMember(Value = "https://schema.org/Oncologic")]
        Oncologic,
        /// <summary>
        /// The optometic
        /// </summary>
        [Obsolete("Misspelled; use Optometric.")]
        [EnumMember(Value = "https://schema.org/Optometric")]
        Optometic,
        /// <summary>
        /// The otolaryngologic
        /// </summary>
        [EnumMember(Value = "https://schema.org/Otolaryngologic")]
        Otolaryngologic,
        /// <summary>
        /// The pathology
        /// </summary>
        [EnumMember(Value = "https://schema.org/Pathology")]
        Pathology,
        /// <summary>
        /// The pediatric
        /// </summary>
        [EnumMember(Value = "https://schema.org/Pediatric")]
        Pediatric,
        /// <summary>
        /// The pharmacy specialty
        /// </summary>
        [EnumMember(Value = "https://schema.org/PharmacySpecialty")]
        PharmacySpecialty,
        /// <summary>
        /// The physiotherapy
        /// </summary>
        [EnumMember(Value = "https://schema.org/Physiotherapy")]
        Physiotherapy,
        /// <summary>
        /// The plastic surgery
        /// </summary>
        [EnumMember(Value = "https://schema.org/PlasticSurgery")]
        PlasticSurgery,
        /// <summary>
        /// The podiatric
        /// </summary>
        [EnumMember(Value = "https://schema.org/Podiatric")]
        Podiatric,
        /// <summary>
        /// The primary care
        /// </summary>
        [EnumMember(Value = "https://schema.org/PrimaryCare")]
        PrimaryCare,
        /// <summary>
        /// The psychiatric
        /// </summary>
        [EnumMember(Value = "https://schema.org/Psychiatric")]
        Psychiatric,
        /// <summary>
        /// The public health
        /// </summary>
        [EnumMember(Value = "https://schema.org/PublicHealth")]
        PublicHealth,
        /// <summary>
        /// The pulmonary
        /// </summary>
        [EnumMember(Value = "https://schema.org/Pulmonary")]
        Pulmonary,
        /// <summary>
        /// The radiograpy
        /// </summary>
        [Obsolete("Radiography is a schema.org MedicalImagingTechnique, not a MedicalSpecialty.")]
        [EnumMember(Value = "https://schema.org/Radiography")]
        Radiograpy,
        /// <summary>
        /// The renal
        /// </summary>
        [EnumMember(Value = "https://schema.org/Renal")]
        Renal,
        /// <summary>
        /// The respiratory therapy
        /// </summary>
        [EnumMember(Value = "https://schema.org/RespiratoryTherapy")]
        RespiratoryTherapy,
        /// <summary>
        /// The rheumatologic
        /// </summary>
        [EnumMember(Value = "https://schema.org/Rheumatologic")]
        Rheumatologic,
        /// <summary>
        /// The speech pathology
        /// </summary>
        [EnumMember(Value = "https://schema.org/SpeechPathology")]
        SpeechPathology,
        /// <summary>
        /// The surgical
        /// </summary>
        [EnumMember(Value = "https://schema.org/Surgical")]
        Surgical,
        /// <summary>
        /// The toxicologic
        /// </summary>
        [EnumMember(Value = "https://schema.org/Toxicologic")]
        Toxicologic,
        /// <summary>
        /// The urologic
        /// </summary>
        [EnumMember(Value = "https://schema.org/Urologic")]
        Urologic,
        /// <summary>
        /// Audiology
        /// </summary>
        [EnumMember(Value = "https://schema.org/Audiology")]
        Audiology,
        /// <summary>
        /// Dermatology
        /// </summary>
        [EnumMember(Value = "https://schema.org/Dermatology")]
        Dermatology,
        /// <summary>
        /// Ophthalmology
        /// </summary>
        [EnumMember(Value = "https://schema.org/Ophthalmology")]
        Ophthalmology,
        /// <summary>
        /// Optometric
        /// </summary>
        [EnumMember(Value = "https://schema.org/Optometric")]
        Optometric,
    }
}
