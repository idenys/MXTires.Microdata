using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MXTires.Microdata.Intangible.Quantity;

namespace MXTires.Microdata.Actions.MoveActions
{
    /// <summary>
    /// The act of traveling from an fromLocation to a destination by a specified mode of transport, optionally with participants.
    /// </summary>
    public class TravelAction : Action
    {
        /// <summary>
        /// Distance - The distance travelled, e.g. exercising or travelling.
        /// </summary>
        Distance Distance { get; set; }	 	
    }
}
