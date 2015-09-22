using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MXTires.Microdata.Intangible;
using MXTires.Microdata.Validators;
using Newtonsoft.Json;

namespace MXTires.Microdata.Actions.OrganizeActions
{
    /// <summary>
    /// The act of organizing tasks/objects/events by associating resources to it.
    /// </summary>
    public class AuthorizeAction : OrganizeAction
    {
        object recipient;

        /// <summary>
        /// Organization  or Person  or Audience - A sub property of participant. The participant who is at the receiving end of the action.
        /// </summary>
        [JsonProperty("recipient")]
        public object Recipient
        {
            get { return recipient; }
            set
            {
                List<Type> typeList = new List<System.Type> { typeof(Organization), typeof(Person), typeof(Audience) };
                var validator = new TypeValidator(typeList);
                validator.Validate(value);
                recipient = value;
            }
        }
    }
}
