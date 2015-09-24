using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MXTires.Microdata.Validators;
using Newtonsoft.Json;

namespace MXTires.Microdata.Actions.UpdateActions
{
    /// <summary>
    /// The act of managing by changing/editing the state of the object.
    /// </summary>
    public class UpdateAction : Action
    {
        /// <summary>
        /// Thing  - A sub property of object. The collection target of the action. Supersedes <see cref="collection"/>.
        /// </summary>
        [JsonProperty("targetCollection	")]
        public Thing TargetCollection { get; set; }
    }
}
