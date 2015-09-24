using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MXTires.Microdata.Intangible;
using MXTires.Microdata.Intangible.Enumeration;
using MXTires.Microdata.Validators;
using Newtonsoft.Json;

namespace MXTires.Microdata.Actions.TransferActions
{
    /// <summary>
    /// The act of physically/electronically dispatching an object for transfer from an origin to a destination.
    /// Related actions:
    /// <see cref="ReceiveAction"/>: Reciprocal of SendAction
    /// <see cref="GiveAction"/>: Unlike GiveAction, SendAction does not imply the transfer of ownership (e.g. I can send you my laptop, but I'm not necessarily giving it to you)
    /// </summary>
    public class SendAction : TransferAction
    {

        /// <summary>
        /// DeliveryMethod  - A sub property of instrument. The method of delivery.
        /// </summary>
        [JsonProperty("deliveryMethod")]
        public DeliveryMethod DeliveryMethod { get; set; }

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
