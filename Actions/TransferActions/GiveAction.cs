using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MXTires.Microdata.Intangible;
using MXTires.Microdata.Validators;
using Newtonsoft.Json;

namespace MXTires.Microdata.Actions.TransferActions
{
    /// <summary>
    /// The act of transferring ownership of an object to a destination. Reciprocal of TakeAction.
    /// Related actions:
    /// <see cref="TakeAction"/>: Reciprocal of GiveAction.
    /// <see cref="SendAction"/>: Unlike SendAction, GiveAction implies that ownership is being transferred (e.g. I may send my laptop to you, but that doesn't mean I'm giving it to you)
    /// </summary>
    public class GiveAction : TransferAction
    {
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
