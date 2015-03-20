using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace MXTires.Microdata
{
    /// <summary>
    /// Organization: A business corporation.
    /// </summary>
    public class Corporation : Organization
    {
        /// <summary>
        /// The exchange traded instrument associated with a Corporation object. The tickerSymbol is expressed as an exchange and an instrument name separated by a space character. 
        /// For the exchange component of the tickerSymbol attribute, we reccommend using the controlled vocaulary of Market Identifier Codes (MIC) specified in ISO15022.
        /// </summary>
        [JsonProperty("tickerSymbol")]
        public string TickerSymbol { get; set; }
    }
}