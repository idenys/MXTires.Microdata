using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MXTires.Microdata
{
    public class EntryPoint:Thing
    {
        /// <summary>
        /// Text - An url template (RFC6570) that will be used to construct the target of the execution of the action.
        /// </summary>
        [JsonProperty("urlTemplate")]
        public string UrlTemplate {get;set;}
    }
}
