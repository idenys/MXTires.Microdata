using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MXTires.Microdata.Intangible;
using MXTires.Microdata.Validators;
using Newtonsoft.Json;

namespace MXTires.Microdata.Actions.TradeActions
{
    /// <summary>
    /// An agent pays a price to a participant.
    /// </summary>
    public class PayAction : TradeAction
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

        object recipient;

        /// <summary>
        /// Audience  or Organization  or Person - A sub property of participant. The participant who is at the receiving end of the action.
        /// </summary>
        [JsonProperty("recipient")]
        public object Recipient
        {
            get { return recipient; }
            set
            {
                List<Type> typeList = new List<System.Type>() { typeof(Audience), typeof(Organization), typeof(Person), };
                var validator = new TypeValidator(typeList);
                validator.Validate(value);
                recipient = value;
            }
        }
    }
}
