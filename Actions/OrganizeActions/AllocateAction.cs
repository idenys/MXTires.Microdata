using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MXTires.Microdata.Validators;
using Newtonsoft.Json;

namespace MXTires.Microdata.Actions.OrganizeActions
{
    /// <summary>
    /// The act of organizing tasks/objects/events by associating resources to it.
    /// </summary>
    public class AllocateAction : OrganizeAction
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
    }
}
