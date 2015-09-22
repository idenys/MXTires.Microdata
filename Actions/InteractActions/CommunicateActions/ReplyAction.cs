using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace MXTires.Microdata.Actions.InteractActions.CommunicateActions
{
    /// <summary>
    /// The act of responding to a question/message asked/sent by the object. Related to <see cref="AskAction"/>.
    /// Related actions:
    /// <see cref="AskAction"/>: Appears generally as an origin of a ReplyAction
    /// </summary>
    public class ReplyAction : CommunicateAction
    {
        /// <summary>
        /// Comment - A sub property of result. The Comment created or sent as a result of this action.
        /// </summary>
        [JsonProperty("resultComment")]
        public Comment ResultComment { get; set; }
    }
}
