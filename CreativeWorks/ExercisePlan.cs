using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MXTires.Microdata.Intangible.Quantity;
using MXTires.Microdata.Validators;
using Newtonsoft.Json;

namespace MXTires.Microdata.CreativeWorks
{
    /// <summary>
    /// Fitness-related activity designed for a specific health-related purpose, including defined exercise routines as well as activity prescribed by a clinician.
    /// </summary>
    public class ExercisePlan : CreativeWork
    {
        /// <summary>
        /// Duration - Length of time to engage in the activity.
        /// </summary>
        [JsonProperty("activityDuration")]
        public Duration ActivityDuration { get; set; }

        /// <summary>
        /// Text 	How often one should engage in the activity.
        /// </summary>
        [JsonProperty("activityFrequency")]
        public string ActivityFrequency { get; set; }

        /// <summary>
        /// Text - Any additional component of the exercise prescription that may need to be articulated to the patient. This may include the order of exercises, the number of repetitions of movement, quantitative distance, progressions over time, etc.
        /// </summary>
        [JsonProperty("additionalVariable")]
        public string AdditionalVariable { get; set; }

        /// <summary>
        /// Text 	Type(s) of exercise or activity, such as strength training, flexibility training, aerobics, cardiac rehabilitation, etc.
        /// </summary>
        [JsonProperty("exerciseType")]
        public string ExerciseType { get; set; }

        /// <summary>
        /// Text 	Quantitative measure gauging the degree of force involved in the exercise, for example, heartbeats per minute. May include the velocity of the movement.
        /// </summary>
        [JsonProperty("intensity")]
        public string Intensity { get; set; }

        /// <summary>
        /// Number 	Number of times one should repeat the activity.
        /// </summary>
        [JsonProperty("repetitions")]
        public Int32? Repetitions { get; set; }

        /// <summary>
        /// Text 	How often one should break from the activity.
        /// </summary>
        [JsonProperty("restPeriods")]
        public string RestPeriods { get; set; }

        /// <summary>
        /// Energy - Quantitative measure of the physiologic output of the exercise; also referred to as energy expenditure.
        /// </summary>
        [JsonProperty("workload")]
        public Energy Workload { get; set; } 	
    }
}
