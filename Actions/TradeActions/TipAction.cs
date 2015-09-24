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
    /// The act of giving money voluntarily to a beneficiary in recognition of services rendered.
    /// </summary>
    public class TipAction : TradeAction
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
