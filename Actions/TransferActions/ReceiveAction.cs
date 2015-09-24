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
    /// The act of physically/electronically taking delivery of an object thathas been transferred from an origin to a destination. Reciprocal of SendAction.
    /// Related actions:
    /// <see cref="SendAction"/>: Reciprocal of ReceiveAction
    /// <see cref="TakeAction"/>: Unlike TakeAction, ReceiveAction does not imply that the ownership has been transfered 
    /// (e.g. I can receive a package, but it does not mean the package is now mine)
    /// </summary>
    public class ReceiveAction : TransferAction
    {
        object sender;

        /// <summary>
        /// Audience  or Organization  or Person - A sub property of participant. The participant who is at the receiving end of the action.
        /// </summary>
        [JsonProperty("sender")]
        public object Sender
        {
            get { return sender; }
            set
            {
                List<Type> typeList = new List<System.Type>() { typeof(Audience), typeof(Organization), typeof(Person), };
                var validator = new TypeValidator(typeList);
                validator.Validate(value);
                sender = value;
            }
        }

        /// <summary>
        /// DeliveryMethod  - A sub property of instrument. The method of delivery.
        /// </summary>
        [JsonProperty("deliveryMethod")]
        public DeliveryMethod DeliveryMethod { get; set; }
    }
}
