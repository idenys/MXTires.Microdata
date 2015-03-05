using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace MXTires.Microdata
{
    public class Corporation:Organization
    {
        [JsonProperty("tickerSymbol")]
        public string TickerSymbol { get; set; }
    }
}