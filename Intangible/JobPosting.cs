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
    /// A listing that describes a job opening in a certain organization.
    /// </summary>
    public class JobPosting : Thing
    {

        /// <summary>
        /// AdministrativeArea - The location(s) applicants can apply from. This is usually used for telecommuting jobs where the applicant does not need to be in a physical office.
        /// Note: This should not be used for citizenship or work visa requirements.
        /// </summary>
        [JsonProperty("applicantLocationRequirements")]
        public AdministrativeArea ApplicantLocationRequirements { get; set; }

        /// <summary>
        /// Number  or PriceSpecification - The base salary of the job or of an employee in an EmployeeRole.
        /// </summary>
        [JsonProperty("baseSalary")]
        public object BaseSalary { get; set; }

        /// <summary>
        /// Date - Publication date for the job posting.
        /// </summary>
        [JsonProperty("datePosted")]
        public DateTime? DatePosted { get; set; }

        /// <summary>
        /// Text - Educational background needed for the position.
        /// </summary>
        [JsonProperty("educationRequirements")]
        public string EducationRequirements { get; set; }
        /// <summary>
        /// Text - Type of employment (e.g. full-time, part-time, contract, temporary, seasonal, internship).
        /// </summary>
        [JsonProperty("employmentType")]
        public string EmploymentType { get; set; }

        private object estimatedSalary;
        /// <summary>
        /// MonetaryAmount  or MonetaryAmountDistribution or Number - An estimated salary for a job posting or occupation, based on a variety of variables including, but not limited to industry, job title, and location.
        /// Estimated salaries are often computed by outside organizations rather than the hiring organization, who may not have committed to the estimated value.
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
        /// Text - Description of skills and experience needed for the position.
        /// </summary>
        [JsonProperty("experienceRequirements")]
        public string ExperienceRequirements { get; set; }

        private object hiringOrganization;
        /// <summary>
        /// Organization or Person - Organization or Person offering the job position.
        /// </summary>
        [JsonProperty("hiringOrganization")]
        public object HiringOrganization
        {
            get { return this.hiringOrganization; }
            set
            {
                TypeValidator validator = new TypeValidator(typeof(Person), typeof(Organization));
                validator.Validate(value);
                this.hiringOrganization = value;
            }
        }
        /// <summary>
        /// Text - Description of bonus and commission compensation aspects of the job. Supersedes incentives.
        /// </summary>
        [JsonProperty("incentiveCompensation")]
        public string IncentiveCompensation { get; set; }

        /// <summary>
        /// Text - The industry associated with the job position.
        /// </summary>
        public string Industry
        {
            set
            {
                Industries = Industries ?? new List<string>();
                Industries.Add(value);
            }
        }

        /// <summary>
        /// Text - The industries associated with the job position.
        /// </summary>
        [JsonProperty("industry")]
        public List<string> Industries { get; set; }

        /// <summary>
        /// Text - Description of benefits associated with the job. Supersedes <code>Benefits</code>.
        /// </summary>
        [JsonProperty("jobBenefits")]
        public string JobBenefits { get; set; }

        /// <summary>
        /// Text - Description of benefits associated with the job. Superseded by <code>JobBenefits</code>.
        /// </summary>
        [JsonProperty("benefits")]
        public string Benefits { get; set; }

        /// <summary>
        /// Boolean - An indicator as to whether a position is available for an immediate start.
        /// </summary>
        [JsonProperty("jobImmediateStart")]
        public bool? jobImmediateStart { get; set; }

        /// <summary>
        /// Place - A (typically single) geographic location associated with the job position.
        /// </summary>
        public Place JobLocation
        {
            set
            {
                JobLocations = JobLocations ?? new List<Place>();
                JobLocations.Add(value);
            }
        }

        /// <summary>
        /// Places - Multiple geographic location associated with the job position.
        /// </summary>
        [JsonProperty("jobLocation")]
        public List<Place> JobLocations { get; set; }

        object jobStartDate;
        /// <summary>
        /// Date  or Text - The date on which a successful applicant for this job would be expected to start work.Choose a specific date in the future or use the jobImmediateStart property to indicate the position is to be filled as soon as possible.
        /// </summary>
        [JsonProperty("jobStartDate")]
        public object JobStartDate
        {
            get { return jobStartDate; }
            set
            {
                var validator = new TypeValidator(new List<Type> { typeof(DateTime), typeof(string) });
                validator.Validate(value);
                jobStartDate = value;
            }
        }

        /// <summary>
        /// Text - A description of the job location(e.g TELECOMMUTE for telecommute jobs).
        /// </summary>
        [JsonProperty("jobLocationType")]
        public string JobLocationType { get; set; }

        /// <summary>
        /// Text - Category or categories describing the job. Use BLS O*NET-SOC taxonomy: http://www.onetcenter.org/taxonomy.html. Ideally includes textual label and formal code, with the property repeated for each applicable value.
        /// </summary>
        [JsonProperty("occupationalCategory")]
        public string OccupationalCategory { get; set; }

        /// <summary>
        /// Text - Specific qualifications required for this role.
        /// </summary>
        [JsonProperty("qualifications")]
        public string Qualifications { get; set; }

        /// <summary>
        /// Text - Responsibilities associated with this role.
        /// </summary>
        [JsonProperty("responsibilities")]
        public string Responsibilities { get; set; }

        /// <summary>
        /// Text - The currency (coded using ISO 4217, http://en.wikipedia.org/wiki/ISO_4217 ) used for the main salary information in this job posting or for this employee.
        /// </summary>
        [JsonProperty("salaryCurrency")]
        public string SalaryCurrency { get; set; }

        /// <summary>
        /// Text - Skills required to fulfill this role.
        /// </summary>
        [JsonProperty("skills")]
        public string Skills { get; set; }

        /// <summary>
        /// Text - Any special commitments associated with this job posting. Valid entries include VeteranCommit, MilitarySpouseCommit, etc.
        /// </summary>
        [JsonProperty("specialCommitments")]
        public string SpecialCommitments { get; set; }

        /// <summary>
        /// Text - The title of the job.
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }

        /// <summary>
        /// DateTime? - The date when the job posting will expire.
        /// </summary>
        [JsonProperty("validThrough")]
        public DateTime? ValidThrough { get; set; }
        
        /// <summary>
        /// Text - The typical working hours for this job (e.g. 1st shift, night shift, 8am-5pm).
        /// </summary>
        [JsonProperty("workHours")]
        public string WorkHours { get; set; }

        private object identifier;
        /// <summary>
        /// PropertyValue  or Text or URL - The identifier property represents any kind of identifier for any kind of Thing, such as ISBNs, GTIN codes, UUIDs etc.
        /// Schema.org provides dedicated properties for representing many of these, either as textual strings or as URL(URI) links. See background notes for more details.
        /// </summary>
        [JsonProperty("identifier")]
        public object Identifier {
            get { return identifier; }
            set
            {
                var validator = new TypeValidator(new List<Type> { typeof(PropertyValue), typeof(string), typeof(List<PropertyValue>), typeof(IList<PropertyValue>) });
                validator.Validate(value);
                identifier = value;
            }
        }

    }
}
