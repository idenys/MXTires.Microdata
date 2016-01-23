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
using MXTires.Microdata.LocalBusinesses.EmergencyServices;
using MXTires.Microdata.MedicalEntities;
using Newtonsoft.Json;

namespace MXTires.Microdata.LocalBusinesses.MedicalOrganizations
{
    /// <summary>
    /// A doctor's office.
    /// </summary>
    public class Physician : MedicalOrganization
    {
        /// <summary>
        /// MedicalTest  or MedicalTherapy  or MedicalProcedure - A medical service available from this provider
        /// </summary>
        [JsonProperty("availableService")]
        public Thing AvailableService { get; set; }

        /// <summary>
        /// Hospital - A hospital with which the physician or office is affiliated.
        /// </summary>
        [JsonProperty("hospitalAffiliation")]
        public Hospital hospitalAffiliation { get; set; }	
        
         /// <summary>
        /// MedicalSpecialty - A medical specialty of the provider.
        /// </summary>
        [JsonProperty("medicalSpecialty")]
        public object MedicalSpecialty { get; set; }	
    }
}
