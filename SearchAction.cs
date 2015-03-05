using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MXTires.Microdata
{
    public class SearchAction : Microdata.Action
    {
        /// <summary>
        /// Class  or Text - A sub property of instrument. The query used on this action.
        /// </summary>
        [JsonProperty("query-input")]
        public string Query { get; set; }
    }
}