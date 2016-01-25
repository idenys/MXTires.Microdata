using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MXTires.Microdata.CreativeWorks;
using MXTires.Microdata.Events;
using MXTires.Microdata.Intangible.Quantities;
using MXTires.Microdata.LocalBusinesses;
using MXTires.Microdata.Organizations;
using MXTires.Microdata.Validators;
using Newtonsoft.Json;

namespace MXTires.Microdata.Actions.PlayActions
{
    /// <summary>
    /// The act of participating in exertive activity for the purposes of improving health and fitness.
    /// </summary>
    public class ExerciseAction : PlayAction
    {
        object purpose;

        /// <summary>
        /// Thing  or MedicalDevicePurpose - A goal towards aA goal towards an action is taken. Can be concrete or abstract.
        /// </summary>
        [JsonProperty("purpose")]
        public object Purpose
        {
            get { return purpose; }
            set
            {
                var validator = new TypeValidator(typeof(Thing), typeof(MedicalDevicePurpose));
                validator.Validate(value);
                purpose = value;
            }
        }

        /// <summary>
        /// Distance 	The distance travelled, e.g. exercising or travelling.
        /// </summary>
        [JsonProperty("distance")]
        public Distance Distance { get; set; }

        /// <summary>
        /// Place 	A sub property of location. The course where this action was taken. Supersedes course.
        /// </summary>
        [JsonProperty("exerciseCourse")]
        public Place ExerciseCourse { get; set; }

        /// <summary>
        /// ExercisePlan 	A sub property of instrument. The exercise plan used on this action.
        /// </summary>
        [JsonProperty("exercisePlan")]
        public ExercisePlan ExercisePlan { get; set; }

        /// <summary>
        /// Diet - A sub property of instrument. The diet used in this action. Supersedes diet
        /// </summary>
        [JsonProperty("exerciseRelatedDiet")]
        public Diet ExerciseRelatedDiet { get; set; }

        /// <summary>
        /// Text 	Type(s) of exercise or activity, such as strength training, flexibility training, aerobics, cardiac rehabilitation, etc.
        /// </summary>
        [JsonProperty("exerciseType")]
        public string exerciseType { get; set; }

        /// <summary>
        /// Place - A sub property of location. The original location of the object or the agent before the action.
        /// </summary>
        [JsonProperty("fromLocation")]
        public Place FromLocation { get; set; }

        /// <summary>
        /// Person 	A sub property of participant. The opponent on this action.
        /// </summary>
        [JsonProperty("opponent")]
        public Person Opponent { get; set; }


        /// <summary>
        /// SportsActivityLocation 	A sub property of location. The sports activity location where this action occurred.
        /// </summary>
        [JsonProperty("sportsActivityLocation")]
        public SportsActivityLocation SportsActivityLocation { get; set; }

        /// <summary>
        /// SportsEvent - A sub property of location. The sports event where this action occurred.
        /// </summary>
        [JsonProperty("sportsEvent")]
        public SportsEvent SportsEvent { get; set; }

        /// <summary>
        /// SportsTeam 	A sub property of participant. The sports team that participated on this action.
        /// </summary>
        [JsonProperty("sportsTeam")]
        public SportsTeam sportsTeam { get; set; }

        /// <summary>
        /// Place 	A sub property of location. The final location of the object or the agent after the action.
        /// </summary>
        [JsonProperty("toLocation")]
        public Place ToLocation { get; set; }
    }
}
