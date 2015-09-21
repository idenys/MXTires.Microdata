using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace MXTires.Microdata.Actions.InteractActions.CommunicateActions
{
    /// <summary>
    /// The act of posing a question / favor to someone.
    /// Related actions:
    /// ReplyAction: Appears generally as a response to AskAction
    /// </summary>
    public class AskAction : CommunicateAction
    {
        /// <summary>
        /// Question - A sub property of object. A question.
        /// </summary>
        [JsonProperty("question")]
        public Question Question { get; set; }
    }
}
