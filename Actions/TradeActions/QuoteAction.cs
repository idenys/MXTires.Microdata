using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace MXTires.Microdata.Actions.TradeActions
{
    /// <summary>
    /// An agent quotes/estimates/appraises an object/product/service with a price at a location/store.
    /// </summary>
    public class QuoteAction : TradeAction
    {
        /// <summary>
        /// The offer price of a product, or of a price component when attached to PriceSpecification and its subtypes. 
        /// <list type="bullet">        
        ///     <listheader>
        ///         <term>Usage guidelines:</term>
        ///     </listheader>
        ///     <item>   
        ///     <description>
        ///         Use the priceCurrency property (with ISO 4217 codes e.g. "USD") instead of including ambiguous symbols such as '$' in the value.
        ///         </description>
        ///     </item>
        ///     <item>
        ///         <description>
        ///         Use '.' (Unicode 'FULL STOP' (U+002E)) rather than ',' to indicate a decimal point. Avoid using these symbols as a readability separator.
        ///         Note that both RDFa and Microdata syntax allow the use of a "content=" attribute for publishing simple machine-readable values alongside more human-friendly formatting.
        ///         </description>
        ///     </item>
        ///         <description>
        ///         Use values from 0123456789 (Unicode 'DIGIT ZERO' (U+0030) to 'DIGIT NINE' (U+0039)) rather than superficially similiar Unicode symbols.
        ///         </description>
        ///      </item>
        /// </list>
        /// </summary>
        [JsonProperty("price")]
        public string Price { get; set; }

        /// <summary>
        /// One or more detailed price specifications, indicating the unit price and delivery or payment charges.
        /// </summary>
        [JsonProperty("priceSpecification")]
        public PriceSpecification PriceSpecification { get; set; }
    }
}
