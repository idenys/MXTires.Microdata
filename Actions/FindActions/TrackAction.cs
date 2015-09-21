using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MXTires.Microdata.Intangible.Enumeration;
using Newtonsoft.Json;

namespace MXTires.Microdata.Actions.FindActions
{
    /// <summary>
    /// An agent tracks an object for updates.
    /// </summary>
    public class TrackAction
    {
        /// <summary>
        /// DeliveryMethod - A sub property of instrument. The method of delivery.
        /// </summary>
        [JsonProperty("deliveryMethod")]
        DeliveryMethod DeliveryMethod { get; set; }
    }
}
