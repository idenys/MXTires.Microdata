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
    /// The act of editing a recipient by replacing an old object with a new object.
    /// </summary>
    public class ReplaceAction : UpdateAction
    {
        /// <summary>
        /// Thing - A sub property of object. The object that is being replaced.
        /// </summary>
        [JsonProperty("replacee")]
        public Thing Replacee { get; set; }

        /// <summary>
        /// Thing - A sub property of object. The object that replaces.
        /// </summary>
        [JsonProperty("replacer")]
        public Thing Replacer { get; set; }
    }
}
