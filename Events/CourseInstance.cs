using MXTires.Microdata.CreativeWorks;
using Newtonsoft.Json;

namespace MXTires.Microdata.Events
{
    /// <summary>
    /// An instance of a <see cref="Course"/> which is distinct from other instances because it is offered at a different time or location or through different media or modes of study or to a specific section of students.
    /// </summary>
    public class CourseInstance : Event
    {

        /// <summary>
        /// Text or URL - The medium or means of delivery of the course instance or the mode of study, either as a text label (e.g. "online", "onsite" or "blended"; "synchronous" or "asynchronous"; "full-time" or "part-time") or as a URL reference to a term from a controlled vocabulary(e.g.https://ceds.ed.gov/element/001311#Asynchronous ).
        /// </summary>
        [JsonProperty("coursePrerequisites")]
        public object CourseMode { get; set; }

        /// <summary>
        /// Person - A person assigned to instruct or provide instructional assistance for the CourseInstance.
        /// </summary>
        [JsonProperty("instructor")]
        public Person Instructor { get; set; }
    }
}
