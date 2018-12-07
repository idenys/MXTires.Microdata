using MXTires.Microdata.Events;
using MXTires.Microdata.Intangible;
using MXTires.Microdata.Validators;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MXTires.Microdata.CreativeWorks
{
    /// <summary>
    /// A description of an educational course which may be offered as distinct instances at which take place at different times or take place at different locations, 
    /// or be offered through different media or modes of study. An educational course is a sequence of one or more educational events 
    /// and/or creative works which aims to build knowledge, competence or ability of learners.
    /// </summary>
    public class Course : CreativeWork
    {
        /// <summary>
        /// Text - The identifier for the Course used by the course provider(e.g.CS101 or 6.001).
        /// </summary>
        [JsonProperty("courseCode")]
        public string CourseCode { get; set; }

        object coursePrerequisites;
        /// <summary>
        /// AlignmentObject or Course or Text - Requirements for taking the Course.May be completion of another Course or a textual description like "permission of instructor". 
        /// Requirements may be a pre-requisite competency, referenced using AlignmentObject.
        /// </summary>
        [JsonProperty("coursePrerequisites")]
        public object CoursePrerequisites
        {
            get { return coursePrerequisites; }
            set
            {
                var typeList = new List<Type>() { typeof(AlignmentObject), typeof(Course), typeof(String) };
                var validator = new TypeValidator(typeList);
                validator.Validate(value);
                coursePrerequisites = value;
            }
        }

        /// <summary>
        ///  Text or URL - A description of the qualification, award, certificate, diploma or other educational credential awarded 
        ///  as a consequence of successful completion of this course.
        /// </summary>
        [JsonProperty("educationalCredentialAwarded")]
        public object EducationalCredentialAwarded { get; set; }

        /// <summary>
        /// CourseInstance - An offering of the course at a specific time and place or through specific media or mode of study or to a specific section of students.
        /// </summary>
        [JsonProperty("hasCourseInstance")]
        public CourseInstance HasCourseInstance { get; set; }

    }
}
